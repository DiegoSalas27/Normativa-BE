using Aplicacion.Dtos.statistics;
using Aplicacion.Dtos.statistics.ListaVerificacion;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.ListaVerificaciones
{
   public class ConsultaListaVerificacionStats
    {
        public class Listar : IRequest<StatisticsListaVerificacion> { }


        public class Manejador : IRequestHandler<Listar, StatisticsListaVerificacion>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }

            public async Task<StatisticsListaVerificacion> Handle(Listar request, CancellationToken cancellationToken)
            {

                /*    List<Evaluacion>evaluaciones=(List<Evaluacion>)

                    var pruebasEvaluacionList = await _context.Evaluacion
                        .Select(ev => new ListaPruebaEvaluacionDto
                        {
                            Prueba = ev.PruebaList.Where(pl => pl.Visbilidad == true).OrderByDescending(pl => pl.FechaCreacion).FirstOrDefault(),
                            Visbilidad = ev.Visbilidad
                        })
                        .Where(ev => ev.Prueba != null && ev.Visbilidad == true)
                        .ToListAsync();

                    */

                var evaluacionListaVerificacionList = await _context.Evaluacion
                      .Select(ev => new EvaluacionResultStatsDto
                      {
                          Prueba = ev.PruebaList.Where(pl => pl.Visbilidad == true).OrderByDescending(pl => pl.FechaCreacion).FirstOrDefault(),
                          Visbilidad = ev.Visbilidad,
                          Nombre = ev.Nombre
                      })

                        .Where(ev => ev.Prueba != null && ev.Visbilidad == true)

                        .ToListAsync();

                var XAxisListaVerificacionStacked = new List<DateTime>();

                foreach (var evaluacion in evaluacionListaVerificacionList)
                {
                    // count++;
                    //porcentajePromedio += evaluacion.Prueba.PorcentajeCumplimiento;
                    XAxisListaVerificacionStacked.Add(evaluacion.Prueba.FechaCreacion/*+ ' '+ evaluacion.Prueba.PorcentajeCumplimiento*/);
                }

                var StackedBarSeriesListaVerificacion = new List<decimal>();

                foreach (var evaluacion in evaluacionListaVerificacionList)
                {
                    // count++;
                    //porcentajePromedio += evaluacion.Prueba.PorcentajeCumplimiento;
                    StackedBarSeriesListaVerificacion.Add(evaluacion.Prueba.PorcentajeCumplimiento);
                }

                var response = new StatisticsListaVerificacion
                {
                    StackedBarSeriesListaVerificacion = StackedBarSeriesListaVerificacion,
                    XAxisListaVerificacionStacked = XAxisListaVerificacionStacked,

                };

                return response;
            }
        }

    }
}
