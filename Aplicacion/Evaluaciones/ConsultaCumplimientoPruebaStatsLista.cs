using Aplicacion.Dtos.statistics;
using Aplicacion.Dtos.statistics.Evaluacion;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Evaluaciones
{
    public class ConsultaCumplimientoPruebaStatsLista
    {

        public class Listar : IRequest<StatisticsEvaluacionCumplimientoPruebaLista> { }

        public class Manejador : IRequestHandler<Listar, StatisticsEvaluacionCumplimientoPruebaLista>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<StatisticsEvaluacionCumplimientoPruebaLista> Handle(Listar request, CancellationToken cancellationToken)
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

                var pruebasEvaluacionList = await _context.Evaluacion
                      .Select(ev => new EvaluacionResultStatsDto
                      {
                            Prueba = ev.PruebaList.Where(pl => pl.Visbilidad == true).OrderByDescending(pl => pl.FechaCreacion).FirstOrDefault(),
                            Visbilidad = ev.Visbilidad,
                            Nombre=ev.Nombre
                      })

                        .Where(ev => ev.Prueba != null && ev.Visbilidad == true)


                      
                        .ToListAsync();

                var XAxisPruebaStacked = new List<string>();

                /*          foreach (var evaluacion in pruebasEvaluacionList)
                          {
                              // count++;
                              //porcentajePromedio += evaluacion.Prueba.PorcentajeCumplimiento;
                              XAxisPruebaStacked.add(evaluacion.nom)
                          }
                */
                //        porcentajePromedio = Math.Round((porcentajePromedio / count), 2);

                foreach (var evaluacion in pruebasEvaluacionList)
                {
                    // count++;
                    //porcentajePromedio += evaluacion.Prueba.PorcentajeCumplimiento;
                    XAxisPruebaStacked.Add(evaluacion.Nombre/*+ ' '+ evaluacion.Prueba.PorcentajeCumplimiento*/);
                }

                var StackedBarSeriesPrueba = new List<decimal>();

                foreach (var evaluacion in pruebasEvaluacionList)
                {
                    // count++;
                    //porcentajePromedio += evaluacion.Prueba.PorcentajeCumplimiento;
                    StackedBarSeriesPrueba.Add(evaluacion.Prueba.PorcentajeCumplimiento);
                }

                var response = new StatisticsEvaluacionCumplimientoPruebaLista
                {
                    StackedBarSeriesPrueba = StackedBarSeriesPrueba,
                    XAxisPruebaStacked = XAxisPruebaStacked,

                };

                return response;
            }
        }
    
}
}
