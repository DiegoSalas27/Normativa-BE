using Aplicacion.Dtos;
using Aplicacion.Dtos.statistics;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Identity;
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
    public class ConsultaResultadoStats
    {
        public class Listar : IRequest<StatisticsEvaluacionResult>
        { 
            public string UsuarioId { get; set; }
        }

        public class Manejador : IRequestHandler<Listar, StatisticsEvaluacionResult>
        {
            private readonly NormativaContext _context;
            private readonly UserManager<Usuario> _userManager;
            public Manejador(NormativaContext context, UserManager<Usuario> userManager)
            {
                _context = context;
                _userManager = userManager;
            }
            public async Task<StatisticsEvaluacionResult> Handle(Listar request, CancellationToken cancellationToken)
            {
                var usuario = await _userManager.FindByIdAsync(request.UsuarioId);
                var resultadoRoles = await _userManager.GetRolesAsync(usuario);
                var listaRoles = new List<string>(resultadoRoles);

                var listasVerificacionesStats = await _context.ListaVerificacion
                    .Select(lv => new ListaVerificaionEvaResultDto
                    {
                        EvaluacionResultStatsList = lv.EvaluacionList.Select(ev => new EvaluacionResultStatsDto
                        {
                            EvaluacionId = ev.EvaluacionId,
                            Codigo = ev.Codigo,
                            Nombre = ev.Nombre,
                            Visbilidad = ev.Visbilidad,
                            Prueba = ev.PruebaList.OrderByDescending(pl => pl.FechaCreacion).Where(pr => pr.Visbilidad == true).FirstOrDefault(),
                            FechaCreacion = ev.FechaCreacion,
                            UsuarioId = ev.UsuarioId,
                        })
                        .Where(ev => (ev.UsuarioId == request.UsuarioId && ev.Visbilidad == true && ev.Prueba != null) 
                        || (listaRoles[0] == "Jefe de riesgos" && ev.Visbilidad == true && ev.Prueba != null))
                        .ToList(),
                        Nombre = lv.Nombre,
                        NivelesRiesgosList = lv.NivelesRiesgosList.Select(nl => new NivelesRiesgosDto
                        {
                            ExtMaximo = nl.ExtMaximo,
                            ExtMinimo = nl.ExtMinimo,
                            Nombre = nl.Nombre,
                        })
                    })
                    .ToListAsync();

                var nivelRiesgoBajo = new NivelRiesgoEvaDto
                {
                    Name = "Riesgo Bajo",
                    Data = new List<int>()
                };

                var nivelRiesgoMedio = new NivelRiesgoEvaDto
                {
                    Name = "Riesgo Medio",
                    Data = new List<int>()
                };

                var nivelRiesgoAlto = new NivelRiesgoEvaDto
                {
                    Name = "Riesgo Alto",
                    Data = new List<int>()
                };

                int rBajoCount = 0;
                int rMedioCount = 0;
                int rAltoCount = 0;

                foreach (var listaVerificacion in listasVerificacionesStats)
                {
                    foreach (var evaluacion in listaVerificacion.EvaluacionResultStatsList)
                    {
                        foreach (var nivelRiesgo in listaVerificacion.NivelesRiesgosList)
                        {
                            if (nivelRiesgo.ExtMinimo <= evaluacion.Prueba.PorcentajeCumplimiento
                           && nivelRiesgo.ExtMaximo >= evaluacion.Prueba.PorcentajeCumplimiento)
                            {
                                switch (nivelRiesgo.Nombre)
                                {
                                    case "Bajo":
                                        rBajoCount++;
                                        break;
                                    case "Medio":
                                        rMedioCount++;
                                        break;
                                    case "Alto":
                                        rAltoCount++;
                                        break;
                                }
                            }
                        }
                    }

                    nivelRiesgoBajo.Data.Add(rBajoCount);
                    nivelRiesgoMedio.Data.Add(rMedioCount);
                    nivelRiesgoAlto.Data.Add(rAltoCount);

                    rBajoCount = 0;
                    rMedioCount = 0;
                    rAltoCount = 0;
                }

                List<NivelRiesgoEvaDto> series = new List<NivelRiesgoEvaDto>
                {
                    nivelRiesgoBajo,
                    nivelRiesgoMedio,
                    nivelRiesgoAlto
                };

                var response = new StatisticsEvaluacionResult
                {
                    Series = series,
                    XAxisCategories = listasVerificacionesStats.Select(lv => lv.Nombre)
                }; 


                return response;
            }
        }
    }
}
