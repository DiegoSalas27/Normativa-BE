using Aplicacion.Dtos;
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Pruebas
{
    public class ObtenerResultadosPrueba
    {
        public class Listar : IRequest<ResultadoPruebaDto>
        {
            public Guid PruebaId { get; set; }
        }

        public class Manejador : IRequestHandler<Listar, ResultadoPruebaDto>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<ResultadoPruebaDto> Handle(Listar request, CancellationToken cancellationToken)
            {
                var pruebasResultado = await _context.Prueba // falta agregar la evidencia!!!
                    .Where(x => x.PruebaId == request.PruebaId)
                    .Select(pr => new ResultadoPruebaDto
                    {
                        RequerimientosResultado = pr.EvidenciaRequerimientoLink.Select(er => new ObtenerListaRequerimientoResultadoDto
                        {
                            Descripcion = er.Requerimiento.Descripcion,
                            RequerimientoId = er.RequerimientoId,
                            NivelesRiesgos = er.Requerimiento.VerificacionLista.NivelesRiesgosLink.Select(er => new NivelesRiesgo
                            { 
                                Nombre = er.NivelesRiesgo.Nombre,
                                ExtMinimo = er.NivelesRiesgo.ExtMinimo,
                                ExtMaximo = er.NivelesRiesgo.ExtMaximo,
                            }),
                            CriterioResultado = new CriterioResultadoDto
                            {
                                Descripcion = er.Requerimiento.Criterio.Descripcion,
                                Peso = er.Requerimiento.Criterio.Peso
                            },
                            EvidenciaPruebaLink = new ObtenerEvidenciaRequerimientoDto
                            {
                                Justificacion = er.Justificacion,
                                Recomendacion = er.Recomendacion,
                                RespuestaItem = er.RespuestaItem,
                            }
                        })
                    })
                    .FirstAsync();

                var criterios = new List<CriterioResultadoDto>();
                var nivelesDeRiesgo = new List<NivelesRiesgo>();

                foreach (var reqREsultado in pruebasResultado.RequerimientosResultado)
                {
                    if (!criterios.Any(x => x.Descripcion == reqREsultado.CriterioResultado.Descripcion))
                    {
                        criterios.Add(reqREsultado.CriterioResultado);
                    }
                }

                foreach (var criterio in criterios)
                {
                    foreach (var reqREsultado in pruebasResultado.RequerimientosResultado)
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

                pruebasResultado.CriteriosResultado = criterios;
                foreach (var criterio in criterios)
                {
                    pruebasResultado.PorcentajeCumplimientoTotal += Math.Round((decimal)criterio.PorcentajeCumplimiento * criterio.Peso, 2);
                }

                foreach (var reqREsultado in pruebasResultado.RequerimientosResultado)
                {
                    foreach (var nivelRiesgo in reqREsultado.NivelesRiesgos)
                    {
                        if (!nivelesDeRiesgo.Any(x => x.Nombre == nivelRiesgo.Nombre))
                        {
                            nivelesDeRiesgo.Add(nivelRiesgo);
                        }
                    }
                }

                foreach (var nivel in nivelesDeRiesgo)
                {
                    if (pruebasResultado.PorcentajeCumplimientoTotal >= nivel.ExtMinimo &&
                        pruebasResultado.PorcentajeCumplimientoTotal <= nivel.ExtMaximo)
                    {
                        pruebasResultado.NivelDeRiesgo = nivel.Nombre;
                    }
                }

                var pruebaGuardar = await _context.Prueba.FindAsync(request.PruebaId);

                pruebaGuardar.PorcentajeCumplimiento = (decimal)pruebasResultado.PorcentajeCumplimientoTotal;

                var valor = await _context.SaveChangesAsync();


                return pruebasResultado;
            }
        }
    }
}
