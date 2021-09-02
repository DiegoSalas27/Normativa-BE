using Aplicacion.Dtos;
using Aplicacion.helpers;
using Dominio;
using iText.IO.Font;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Events;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            public Manejador(NormativaContext context, IWebHostEnvironment webHostEnvironment)
            {
                _context = context;
                _webHostEnvironment = webHostEnvironment;
            }
            public async Task<MemoryStream> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var evaluacion = await _context.Evaluacion.Where(x =>
                x.Codigo == request.Codigo)
                    .Select(ev => new ObtenerEvaluacionDetalle
                    {
                        EvaluacionId = ev.EvaluacionId,
                        Codigo = ev.Codigo,
                        Estado = ev.Estado,
                        Visibilidad = ev.Visbilidad,
                        Nombre = ev.Nombre,
                        FechaCreacion = ev.FechaCreacion,
                        ListaVerificacionId = ev.ListaVerificacion.ListaVerificacionId,
                        CodigoListaVerificacion = ev.ListaVerificacion.Codigo,
                        CodigoConcatenadoListaVerificacion = ev.ListaVerificacion.Codigo + '-' + ev.ListaVerificacion.Nombre,
                        ListaVerificacionFechaCreacion = ev.ListaVerificacion.FechaCreacion,
                        RequerimientosCount = ev.ListaVerificacion.RequerimientoList.Count,
                        CodigoConcatenadoObra = ev.Obra.Codigo + '-' + ev.Obra.Nombre,
                        CodigoObra = ev.Obra.Codigo,
                        ObraId = ev.ObraId,
                        NivelesRiesgos = ev.ListaVerificacion.NivelesRiesgosList.Select(nr => new NivelesRiesgo
                        {
                            Nombre = nr.Nombre,
                            ExtMinimo = nr.ExtMinimo,
                            ExtMaximo = nr.ExtMaximo,
                        }),
                        PruebaList = ev.PruebaList.Select(pl => new PruebaDetalleListaDto
                        {
                            Codigo = pl.Codigo,
                            FechaCreacion = pl.FechaCreacion,
                            PruebaId = pl.PruebaId,
                            Visibilidad = pl.Visbilidad,
                            PorcentajeCumplimiento = pl.PorcentajeCumplimiento
                        })
                    })
                    .FirstOrDefaultAsync();

                MemoryStream ms = new MemoryStream();

                PdfWriter pw = new PdfWriter(ms);
                PdfDocument pdfDocument = new PdfDocument(pw);
                Document doc = new Document(pdfDocument, PageSize.LETTER);
                doc.SetMargins(75, 35, 70, 35);

                string contentRootPath = _webHostEnvironment.ContentRootPath;

                string pathLogo = System.IO.Path.Combine(contentRootPath, "Contents/Images/palermo.jpg");
                Image img = new Image(ImageDataFactory.Create(pathLogo));
                //pdfDocument.AddEventHandler(PdfDocumentEvent.START_PAGE, new HeaderEventHandler(img)); // añadir contenido cuando se crea la pag cuando se crea la pagina
                //pdfDocument.AddEventHandler(PdfDocumentEvent.END_PAGE, new FooterEventHandler()); // cuando ya se agrego contenido a todo el documento (cuando ya se agregó contenido a todo el documento)

                //PdfFont font = PdfFontFactory.CreateFont(FontConstants.HELVETICA);

                //Style styles = new Style()
                //    .SetFontSize(24)
                //    .SetFont(font)
                //    .SetFontColor(ColorConstants.BLUE)
                //    .SetBackgroundColor(ColorConstants.RED);

                //doc.Add(new Paragraph("Informe de evaluación " + evaluacion.Nombre).AddStyle(styles));

                Table table = new Table(1).UseAllAvailableWidth(); // usar ancho completo de la hoja
                Cell cell = new Cell().Add(new Paragraph("Informe de evaluación " + evaluacion.Nombre).SetFontSize(14))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                table.AddCell(cell);
                cell = new Cell().Add(new Paragraph("Madero San Miguel"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                table.AddCell(cell);
                table.SetMarginBottom(10f);

                doc.Add(table);

                Style styleCell = new Style()
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER);

                Table _table = new Table(6).UseAllAvailableWidth();
                Cell _cell = new Cell(2, 1).Add(new Paragraph("#"));
                _table.AddHeaderCell(_cell.AddStyle(styleCell));
                _cell = new Cell(1, 4).Add(new Paragraph("Prueba"));
                _table.AddHeaderCell(_cell.AddStyle(styleCell));
                _cell = new Cell(2, 1).Add(new Paragraph("Nivel de riesgo"));
                _table.AddHeaderCell(_cell.AddStyle(styleCell));
                _cell = new Cell().Add(new Paragraph("Código"));
                _table.AddHeaderCell(_cell.AddStyle(styleCell));
                _cell = new Cell().Add(new Paragraph("Fecha de creación"));
                _table.AddHeaderCell(_cell.AddStyle(styleCell));
                _cell = new Cell().Add(new Paragraph("Visiblidad"));
                _table.AddHeaderCell(_cell.AddStyle(styleCell));
                _cell = new Cell().Add(new Paragraph("Cumplimiento"));
                _table.AddHeaderCell(_cell.AddStyle(styleCell));

                int x = 0;
                foreach (var prueba in evaluacion.PruebaList)
                {
                    foreach (var nivel in evaluacion.NivelesRiesgos)
                    {
                        if (prueba.PorcentajeCumplimiento >= nivel.ExtMinimo &&
                            prueba.PorcentajeCumplimiento <= nivel.ExtMaximo)
                        {
                            prueba.NivelDeRiesgo = nivel.Nombre;
                        }
                    }

                    x++;
                    _cell = new Cell().Add(new Paragraph(x.ToString()));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(prueba.Codigo));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(prueba.FechaCreacion.ToString()));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(prueba.Visibilidad.ToString()));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(prueba.PorcentajeCumplimiento.ToString()));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(prueba.NivelDeRiesgo));
                    _table.AddCell(_cell);
                }

                doc.Add(_table);

                doc.Close();

                byte[] byteStream = ms.ToArray();
                ms = new MemoryStream();
                ms.Write(byteStream, 0, byteStream.Length);
                ms.Position = 0;

                return ms;
            }
        }
    }
}
