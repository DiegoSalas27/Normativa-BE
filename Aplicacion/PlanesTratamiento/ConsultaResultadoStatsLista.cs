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
    public class ConsultaResultadoStatsLista
    {
        public class Listar : IRequest<StatisticsTratamientoResultListaDto>
        {
           
        }

        public class Manejador : IRequestHandler<Listar, StatisticsTratamientoResultListaDto>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<StatisticsTratamientoResultListaDto> Handle(Listar request, CancellationToken cancellationToken)
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

                var pieChartSeriesLista = new List<int>
                {
                    canceladoNum,
                    //sinAsignarNum,
                    enProcesoNum,
                    solucionadoNum,
                    asignadoNum,
                };


                var pieChartLabelsLista = new List<string>
                {
                    "Cancelado",
                    "En proceso",
                    "Solucionado",
                    "Asignado"
                };

                var response = new StatisticsTratamientoResultListaDto
                {
                    PieChartSeriesLista = pieChartSeriesLista,
                    PieChartLabelsLista = pieChartLabelsLista,
                };

                return response;
            }
        }
    }
}

