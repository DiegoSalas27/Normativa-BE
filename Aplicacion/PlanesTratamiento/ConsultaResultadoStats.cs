using Aplicacion.Dtos.statistics.Tratamiento;
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

namespace Aplicacion.PlanesTratamiento
{
    public class ConsultaResultadoStats
    {
        public class Listar : IRequest<StatisticsTratamientoResultDto>
        {
            public string UsuarioId { get; set; }
        }

        public class Manejador : IRequestHandler<Listar, StatisticsTratamientoResultDto>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<StatisticsTratamientoResultDto> Handle(Listar request, CancellationToken cancellationToken)
            {
                var listasTratamientosStats = await _context.Tratamiento
                    .Select(tr => new TratamientoStatisticDto
                    {
                        Codigo = tr.Codigo,
                        EstadosTratamiento = tr.EstadosTratamiento,
                        Nombre = tr.Nombre,
                        TratamientoId = tr.TratamientoId,
                        UsuarioId = tr.UsuarioId
                    })
                    .Where(tr => tr.UsuarioId == request.UsuarioId)
                    .ToListAsync();

                int canceladoNum = 0;
                //int sinAsignarNum = 0;
                int enProcesoNum = 0;
                int solucionadoNum = 0;
                int asignadoNum = 0;

                foreach (var tratamiento in listasTratamientosStats)
                {
                    switch (tratamiento.EstadosTratamiento.Nombre)
                    {
                        case "Cancelado":
                            canceladoNum++; break;
                        //case "Sin asignar":
                        //    sinAsignarNum++; break;
                        case "En proceso":
                            enProcesoNum++; break;
                        case "Solucionado":
                            solucionadoNum++; break;
                        case "Asignado":
                            asignadoNum++; break;
                    }
                }

                var pieChartSeries = new List<int>
                {
                    canceladoNum,
                    //sinAsignarNum,
                    enProcesoNum,
                    solucionadoNum,
                    asignadoNum,
                };


                var pieChartLabels = new List<string>
                {
                    "Cancelado",
                    "En proceso",
                    "Solucionado",
                    "Asignado"
                };

                var response = new StatisticsTratamientoResultDto
                {
                    PieChartSeries = pieChartSeries,
                    PieChartLabels = pieChartLabels,
                };

                return response;
            }
        }
    }
}
