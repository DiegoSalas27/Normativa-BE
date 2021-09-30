using Aplicacion.Constants;
using Aplicacion.Dtos;
using Aplicacion.helpers;
using Dominio;
using iText.IO.Font;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Events;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Action;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistencia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Evaluaciones
{
    public class GenerarInforme
    {
        public class Ejecuta : IRequest<MemoryStream>
        { 
            public string Codigo { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, MemoryStream>
        {
            private readonly NormativaContext _context;
            private readonly IWebHostEnvironment _webHostEnvironment;
            private readonly ILogger<GenerarInforme> _logger;
            private readonly UserManager<Usuario> _userManager;
            public Manejador(NormativaContext context, 
                IWebHostEnvironment webHostEnvironment, 
                ILogger<GenerarInforme> logger,
                UserManager<Usuario> userManager)
            {
                _context = context;
                _webHostEnvironment = webHostEnvironment;
                _logger = logger;
                _userManager = userManager;
            }

            public async Task<MemoryStream> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                try
                {
                    var evaluacion = await _context.Evaluacion.Where(x =>
                    x.Codigo == request.Codigo)
                        .Select(ev => new ObtenerEvaluacionDetalle
                        {
                            EvaluacionId = ev.EvaluacionId,
                            Codigo = ev.Codigo,
                            CodigoEspecialista = ev.CodigoEspecialista,
                            Estado = ev.EstadosEvaluacion.Nombre,
                            Visibilidad = ev.Visbilidad,
                            Nombre = ev.Nombre,
                            FechaCreacion = ev.FechaCreacion,
                            FechaAprobacion = ev.FechaAprobacion,
                            ListaVerificacionId = ev.ListaVerificacion.ListaVerificacionId,
                            CodigoListaVerificacion = ev.ListaVerificacion.Codigo,
                            CodigoConcatenadoListaVerificacion = ev.ListaVerificacion.Codigo + '-' + ev.ListaVerificacion.Nombre,
                            ListaVerificacionFechaCreacion = ev.ListaVerificacion.FechaCreacion,
                            NombreListaVerificacion = ev.ListaVerificacion.Nombre,
                            RequerimientosCount = ev.ListaVerificacion.RequerimientoList.Count,
                            RequerimientoList = ev.ListaVerificacion.RequerimientoList,
                            CodigoConcatenadoObra = ev.Obra.Codigo + '-' + ev.Obra.Nombre,
                            CodigoObra = ev.Obra.Codigo,
                            ObraNombre = ev.Obra.Nombre,
                            ObraId = ev.ObraId,
                            NivelesRiesgos = ev.ListaVerificacion.NivelesRiesgosList.Select(nr => new NivelesRiesgo
                            {
                                Nombre = nr.Nombre,
                                ExtMinimo = nr.ExtMinimo,
                                ExtMaximo = nr.ExtMaximo,
                            }),
                            Prueba = ev.PruebaList.OrderByDescending(pl => pl.FechaCreacion).Where(pr => pr.Visbilidad == true).FirstOrDefault(),
                            RequerimientosResultado = ev.PruebaList.OrderByDescending(pl => pl.FechaCreacion).Where(pr => pr.Visbilidad == true).FirstOrDefault().EvidenciaRequerimientoLink.Select(er => new ObtenerListaRequerimientoResultadoDto
                            {
                                Criterio = new CriterioDto
                                {
                                    Descripcion = er.Requerimiento.Criterio.Descripcion,
                                    Peso = er.Requerimiento.Criterio.Peso
                                },
                                Descripcion = er.Requerimiento.Descripcion,
                                RequerimientoId = er.RequerimientoId,
                                CriterioResultado = new CriterioResultadoDto
                                {
                                    Descripcion = er.Requerimiento.Criterio.Descripcion,
                                    Peso = er.Requerimiento.Criterio.Peso
                                },
                                EvidenciaPruebaLink = new ObtenerEvidenciaRequerimientoDto
                                {
                                    Justificacion = er.Justificacion,
                                    Recomendacion = er.Requerimiento.Recomendacion,
                                    RespuestaItem = er.RespuestaItem,
                                    EvidenciaLink = er.Evidencia.AdjuntoURL
                                }
                            }),
                            NombreAnalista = ev.Usuario.Nombres + " " + ev.Usuario.Apellidos,
                            Observaciones = ev.ObservacionLista.Select(ol => new ObservacionDesc
                            {
                                Descripcion = ol.Descripcion
                            })
                        })
                        .FirstOrDefaultAsync();

                    Usuario especialista = await _userManager.FindByIdAsync(evaluacion.CodigoEspecialista);

                    var criterios = new List<CriterioResultadoDto>();
                    var nivelesDeRiesgo = new List<NivelesRiesgo>();

                    foreach (var reqREsultado in evaluacion.RequerimientosResultado)
                    {
                        if (!criterios.Any(x => x.Descripcion == reqREsultado.CriterioResultado.Descripcion))
                        {
                            criterios.Add(reqREsultado.CriterioResultado);
                        }
                    }


                    foreach (var criterio in criterios)
                    {
                        foreach (var reqREsultado in evaluacion.RequerimientosResultado)
                        {
                            if (reqREsultado.CriterioResultado.Descripcion == criterio.Descripcion)
                            {
                                if (reqREsultado.EvidenciaPruebaLink.RespuestaItem != null)
                                {
                                    criterio.Puntaje += reqREsultado.EvidenciaPruebaLink.RespuestaItem != null ? Convert.ToDecimal(reqREsultado.EvidenciaPruebaLink.RespuestaItem) : 1;
                                    criterio.CantidadPreguntas++;
                                }
                            }
                        }

                        criterio.NormalizedPuntaje = Math.Round(criterio.Puntaje, 2).ToString() + '/' + criterio.CantidadPreguntas.ToString();
                        criterio.PorcentajeCumplimiento = Math.Round((criterio.Puntaje / criterio.CantidadPreguntas) * 100, 2);
                    }

                    evaluacion.CriteriosResultado = criterios;
                    foreach (var criterio in criterios)
                    {
                        evaluacion.PorcentajeCumplimientoTotal += Math.Round((decimal)criterio.PorcentajeCumplimiento * criterio.Peso, 2);
                    }

                    foreach (var nivelRiesgo in evaluacion.NivelesRiesgos)
                    {
                        if (!nivelesDeRiesgo.Any(x => x.Nombre == nivelRiesgo.Nombre))
                        {
                            nivelesDeRiesgo.Add(nivelRiesgo);
                        }
                    }

                    foreach (var nivel in nivelesDeRiesgo)
                    {
                        if (evaluacion.PorcentajeCumplimientoTotal >= nivel.ExtMinimo &&
                            evaluacion.PorcentajeCumplimientoTotal <= nivel.ExtMaximo)
                        {
                            evaluacion.NivelDeRiesgo = nivel.Nombre;
                        }
                    }

                    MemoryStream ms = new MemoryStream();

                    PdfWriter pw = new PdfWriter(ms);
                    PdfDocument pdfDocument = new PdfDocument(pw);
                    Document doc = new Document(pdfDocument, PageSize.LETTER);
                    doc.SetMargins(75, 65, 70, 65);

                    string contentRootPath = _webHostEnvironment.ContentRootPath;

                    string pathLogo = System.IO.Path.Combine(contentRootPath, "wwwroot/Contents/Images/palermo.jpg");
                    Image img = new Image(ImageDataFactory.Create(pathLogo));
                    pdfDocument.AddEventHandler(PdfDocumentEvent.START_PAGE, new HeaderEventHandler(img)); // añadir contenido cuando se crea la pag cuando se crea la pagina
                                                                                                           //pdfDocument.AddEventHandler(PdfDocumentEvent.END_PAGE, new FooterEventHandler()); // cuando ya se agrego contenido a todo el documento (cuando ya se agregó contenido a todo el documento)

                    #region styles

                    // fonts and margins

                    PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
                    SolidBorder borderXL = new SolidBorder(ColorConstants.WHITE, 25, 0);
                    SolidBorder borderSM = new SolidBorder(ColorConstants.WHITE, 10, 0);

                    // cell styles

                    Style styleHeaderCell = new Style()
                        .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                        .SetTextAlignment(TextAlignment.CENTER);

                    Style styleDefinitionCell = new Style()
                        .SetTextAlignment(TextAlignment.CENTER);

                    Style stylePoliticaCell = new Style()
                       .SetBackgroundColor(ColorConstants.CYAN)
                       .SetTextAlignment(TextAlignment.LEFT);

                    Style styleLinkCell = new Style()
                       .SetBackgroundColor(ColorConstants.BLUE)
                       .SetTextAlignment(TextAlignment.CENTER);

                    Style styleFooter = new Style()
                      .SetBackgroundColor(ColorConstants.RED)
                      .SetTextAlignment(TextAlignment.LEFT);

                    #endregion styles


                    #region headers

                    Table table = new Table(1).UseAllAvailableWidth(); // usar ancho completo de la hoja

                    Image Img = img;

                    Img.ScaleToFit(PageSize.A4.GetWidth() / 2.5f, PageSize.A4.GetHeight() / 2.5f);
                    float xp = (PageSize.A4.GetWidth() - Img.GetImageScaledWidth()) / 3;
                    float yp = (PageSize.A4.GetHeight() - Img.GetImageScaledHeight()) / 2;
                    Img.SetRelativePosition(xp, 0, 0, 0);

                    Cell cell = new Cell().Add(Img)
                        .SetBorder(Border.NO_BORDER)
                        .SetBorderBottom(borderXL)
    ;
                    table.AddCell(cell);

                    cell = new Cell().Add(new Paragraph("Informe de Evaluación").SetFontSize(22).SetFont(bold))
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetBorder(Border.NO_BORDER)
                        .SetBorderBottom(borderSM);

                    table.AddCell(cell);

                    doc.Add(table);

                    #endregion headers

                    Table _table = new Table(3).UseAllAvailableWidth();
                    Cell _cell = new Cell().Add(new Paragraph("Elaborado por"));
                    _table.AddHeaderCell(_cell.AddStyle(styleHeaderCell));
                    _cell = new Cell().Add(new Paragraph("Revisado por "));
                    _table.AddHeaderCell(_cell.AddStyle(styleHeaderCell));
                    _cell = new Cell().Add(new Paragraph("Fecha de aprobación "));
                    _table.AddHeaderCell(_cell.AddStyle(styleHeaderCell));

                    _cell = new Cell().Add(new Paragraph(evaluacion.NombreAnalista));
                    _table.AddCell(_cell.AddStyle(styleDefinitionCell));
                    _cell = new Cell().Add(new Paragraph(especialista.Nombres + " " + especialista.Apellidos));
                    _table.AddCell(_cell.AddStyle(styleDefinitionCell));
                    _cell = new Cell().Add(new Paragraph(((DateTime)evaluacion.FechaAprobacion).ToString("dd/MM/yyyy")));
                    _table.AddCell(_cell.AddStyle(styleDefinitionCell));

                    _table.SetMarginBottom(50f);

                    Table _tableEvaluacionDetail = new Table(6).UseAllAvailableWidth();
                    _cell = new Cell().Add(new Paragraph("Código de Evaluación"));
                    _tableEvaluacionDetail.AddHeaderCell(_cell.AddStyle(styleHeaderCell));
                    _cell = new Cell().Add(new Paragraph("Evaluación"));
                    _tableEvaluacionDetail.AddHeaderCell(_cell.AddStyle(styleHeaderCell));
                    _cell = new Cell().Add(new Paragraph("Obra"));
                    _tableEvaluacionDetail.AddHeaderCell(_cell.AddStyle(styleHeaderCell));
                    _cell = new Cell().Add(new Paragraph("Código de Prueba"));
                    _tableEvaluacionDetail.AddHeaderCell(_cell.AddStyle(styleHeaderCell));
                    _cell = new Cell().Add(new Paragraph("Lista de verificación"));
                    _tableEvaluacionDetail.AddHeaderCell(_cell.AddStyle(styleHeaderCell));
                    _cell = new Cell().Add(new Paragraph("Fecha de creación"));
                    _tableEvaluacionDetail.AddHeaderCell(_cell.AddStyle(styleHeaderCell));

                    _cell = new Cell().Add(new Paragraph(evaluacion.Codigo));
                    _tableEvaluacionDetail.AddCell(_cell.AddStyle(styleDefinitionCell));
                    _cell = new Cell().Add(new Paragraph(evaluacion.Nombre));
                    _tableEvaluacionDetail.AddCell(_cell.AddStyle(styleDefinitionCell));
                    _cell = new Cell().Add(new Paragraph(evaluacion.ObraNombre));
                    _tableEvaluacionDetail.AddCell(_cell.AddStyle(styleDefinitionCell));
                    _cell = new Cell().Add(new Paragraph(evaluacion.Prueba.Codigo));
                    _tableEvaluacionDetail.AddCell(_cell.AddStyle(styleDefinitionCell));
                    _cell = new Cell().Add(new Paragraph(evaluacion.NombreListaVerificacion));
                    _tableEvaluacionDetail.AddCell(_cell.AddStyle(styleDefinitionCell));
                    _cell = new Cell().Add(new Paragraph(evaluacion.FechaCreacion.ToString("dd/MM/yyyy")));
                    _tableEvaluacionDetail.AddCell(_cell.AddStyle(styleDefinitionCell));

                    _tableEvaluacionDetail.SetMarginBottom(50f);

                    Table _tablePruebaHeading = new Table(1).UseAllAvailableWidth();

                    cell = new Cell().Add(new Paragraph("Detalles de la prueba:").SetFontSize(16).SetFont(bold))
                       .SetTextAlignment(TextAlignment.LEFT)
                       .SetBorder(Border.NO_BORDER);

                    _tablePruebaHeading.AddCell(cell);

                    doc.Add(_table);
                    doc.Add(_tableEvaluacionDetail);
                    doc.Add(_tablePruebaHeading);

                    foreach (var criterio in criterios)
                    {
                        Table _tablePruebaDetail = new Table(UnitValue.CreatePercentArray(new float[] { 8, 5, 6, 4 }));
                        _tablePruebaDetail.SetWidth(UnitValue.CreatePercentValue(100));
                        _tablePruebaDetail.SetFixedLayout();

                        _cell = new Cell(1, 4).Add(new Paragraph(criterio.Descripcion));
                        _tablePruebaDetail.AddHeaderCell(_cell.AddStyle(stylePoliticaCell).SetPaddingLeft(10f));
                        _cell = new Cell().Add(new Paragraph("Requerimiento"));
                        _tablePruebaDetail.AddHeaderCell(_cell.AddStyle(styleHeaderCell));
                        _cell = new Cell().Add(new Paragraph("Respuesta"));
                        _tablePruebaDetail.AddHeaderCell(_cell.AddStyle(styleHeaderCell));
                        _cell = new Cell().Add(new Paragraph("Justificación"));
                        _tablePruebaDetail.AddHeaderCell(_cell.AddStyle(styleHeaderCell));
                        _cell = new Cell().Add(new Paragraph("Evidencia"));
                        _tablePruebaDetail.AddHeaderCell(_cell.AddStyle(styleHeaderCell));

                        foreach (var evidenciaRequerimiento in evaluacion.RequerimientosResultado)
                        {
                            if (evidenciaRequerimiento.CriterioResultado.Descripcion == criterio.Descripcion)
                            {
                                string respuesta = "";
                                switch (evidenciaRequerimiento.EvidenciaPruebaLink.RespuestaItem)
                                {
                                    case 1: respuesta = "Totalmente"; break;
                                    case (decimal?)0.5f: respuesta = "Parcialmente"; break;
                                    case 0: respuesta = "No implementado "; break;
                                    default: respuesta = "No Aplica "; break;
                                }

                                _cell = new Cell().Add(new Paragraph(evidenciaRequerimiento.Descripcion));
                                _tablePruebaDetail.AddCell(_cell.AddStyle(styleDefinitionCell));
                                _cell = new Cell().Add(new Paragraph(respuesta));
                                _tablePruebaDetail.AddCell(_cell.AddStyle(styleDefinitionCell));
                                _cell = new Cell().Add(new Paragraph(evidenciaRequerimiento.EvidenciaPruebaLink.Justificacion));
                                _tablePruebaDetail.AddCell(_cell.AddStyle(styleDefinitionCell));

                                var paragraph = new Paragraph();

                                var link = new Link("Descargar archivo",
                                    PdfAction.CreateURI(
                                       AzureBlob.BASE_URL + evidenciaRequerimiento.EvidenciaPruebaLink.EvidenciaLink));

                                paragraph.Add(link.SetFontColor(ColorConstants.BLUE));

                                _cell = new Cell().Add(evidenciaRequerimiento.EvidenciaPruebaLink.EvidenciaLink != null ? paragraph :
                                    new Paragraph(""));
                                _tablePruebaDetail.AddCell(_cell.AddStyle(styleDefinitionCell));
                            }
                        }

                        _tablePruebaDetail.SetMarginBottom(50f);

                        doc.Add(_tablePruebaDetail);
                    }

                    Table _tablePruebaResultHeading = new Table(1).UseAllAvailableWidth();

                    cell = new Cell().Add(new Paragraph("Resultados de prueba: ").SetFontSize(16).SetFont(bold))
                       .SetTextAlignment(TextAlignment.LEFT)
                       .SetBorder(Border.NO_BORDER);

                    _tablePruebaResultHeading.AddCell(cell);

                    doc.Add(_tablePruebaResultHeading);

                    Table _tablePruebaResult = new Table(4).UseAllAvailableWidth();

                    _cell = new Cell().Add(new Paragraph("Peso"));
                    _tablePruebaResult.AddHeaderCell(_cell.AddStyle(styleHeaderCell));
                    _cell = new Cell().Add(new Paragraph("Criterio"));
                    _tablePruebaResult.AddHeaderCell(_cell.AddStyle(styleHeaderCell));
                    _cell = new Cell().Add(new Paragraph("Puntaje"));
                    _tablePruebaResult.AddHeaderCell(_cell.AddStyle(styleHeaderCell));
                    _cell = new Cell().Add(new Paragraph("Porcentaje"));
                    _tablePruebaResult.AddHeaderCell(_cell.AddStyle(styleHeaderCell));

                    foreach (var pruebaResultado in evaluacion.CriteriosResultado)
                    {
                        _cell = new Cell().Add(new Paragraph(Math.Round(pruebaResultado.Peso, 2).ToString()));
                        _tablePruebaResult.AddCell(_cell.AddStyle(styleDefinitionCell));
                        _cell = new Cell().Add(new Paragraph(pruebaResultado.Descripcion));
                        _tablePruebaResult.AddCell(_cell.AddStyle(styleDefinitionCell));
                        _cell = new Cell().Add(new Paragraph(pruebaResultado.NormalizedPuntaje));
                        _tablePruebaResult.AddCell(_cell.AddStyle(styleDefinitionCell));
                        _cell = new Cell().Add(new Paragraph(pruebaResultado.PorcentajeCumplimiento + " %"));
                        _tablePruebaResult.AddCell(_cell.AddStyle(styleDefinitionCell));
                    }

                    _tablePruebaResult.SetMarginBottom(50f);

                    doc.Add(_tablePruebaResult);

                    Table _tablePruebaSum = new Table(2).UseAllAvailableWidth();

                    _cell = new Cell().Add(new Paragraph("Porcentaje de cumplimiento total "));
                    _tablePruebaSum.AddHeaderCell(_cell.AddStyle(styleHeaderCell));
                    _cell = new Cell().Add(new Paragraph(evaluacion.PorcentajeCumplimientoTotal + " %"));
                    _tablePruebaSum.AddHeaderCell(_cell.AddStyle(styleDefinitionCell));
                    _cell = new Cell().Add(new Paragraph("Nivel de riesgo alcanzado"));
                    _tablePruebaSum.AddHeaderCell(_cell.AddStyle(styleHeaderCell));
                    _cell = new Cell().Add(new Paragraph(evaluacion.NivelDeRiesgo));
                    _tablePruebaSum.AddHeaderCell(_cell.AddStyle(styleDefinitionCell));

                    _tablePruebaSum.SetMarginBottom(50f);

                    // Observaciones

                    doc.Add(_tablePruebaSum);

                    Table _tableObsertions = new Table(1).UseAllAvailableWidth();

                    List list = new List();

                    foreach (var observacion in evaluacion.Observaciones) 
                    {
                        list.SetListSymbol("•  ");
                        list.Add(observacion.Descripcion);
                    }
                    cell = new Cell().Add(new Paragraph("Observaciones: \n").SetFontSize(16).SetFont(bold))
                       .SetTextAlignment(TextAlignment.LEFT)
                       .SetBorder(Border.NO_BORDER);

                    _tableObsertions.AddCell(cell);

                    //_tableObsertions.SetMarginBottom(100f);
                    list.SetMarginBottom(100f);

                    doc.Add(_tableObsertions);
                    doc.Add(list);

                    // footer

                    Table _tableFooter = new Table(1).UseAllAvailableWidth();

                    cell = new Cell().Add(new Paragraph("*Este documento es para uso de CONURAM y asociados. " +
                        "No comparta este documento de manera externa en ninguna circunstancia.")
                        .SetFontSize(12)
                        .SetFontColor(ColorConstants.RED))
                       .SetTextAlignment(TextAlignment.LEFT)
                       .SetBorder(Border.NO_BORDER);

                    _tableFooter.AddCell(cell);

                    doc.Add(_tableFooter);

                    doc.Close();

                    byte[] byteStream = ms.ToArray();
                    ms = new MemoryStream();
                    ms.Write(byteStream, 0, byteStream.Length);
                    ms.Position = 0;

                    return ms;
                }
                catch (Exception e)
                {
                    _logger.LogError(e, e.Message);
                    Console.WriteLine(e);
                    throw new Exception("No se pudo agregar al nuevo usuario", e);
                }
            }
        }
    }
}
