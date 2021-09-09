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
    public class ConsultaCumplimientoStats
    {
        public class Listar : IRequest<StatisticsEvaluacionCumplimiento> {}

        public class Manejador : IRequestHandler<Listar, StatisticsEvaluacionCumplimiento>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<StatisticsEvaluacionCumplimiento> Handle(Listar request, CancellationToken cancellationToken)
            {
                var pruebasEvaluacionList = await _context.Evaluacion
                    .Select(ev => new ListaPruebaEvaluacionDto
                    {
                        Prueba = ev.PruebaList.OrderByDescending(pl => pl.FechaCreacion).Where(pr => pr.Visbilidad == true).FirstOrDefault(),
                        Visbilidad = ev.Visbilidad
                    })
                    .Where(ev => ev.Prueba != null && ev.Visbilidad == true)
                    .ToListAsync();


                decimal porcentajePromedio = 0;
                int count = 0;

                foreach (var evaluacion in pruebasEvaluacionList)
                {
                    count++;
                    porcentajePromedio += evaluacion.Prueba.PorcentajeCumplimiento;
                }

                porcentajePromedio = Math.Round((porcentajePromedio / count), 2);

                var response = new StatisticsEvaluacionCumplimiento
                {
                    GaugeSeries = new List<decimal> { porcentajePromedio }
                };

                return response;
            }
        }
    }
}
