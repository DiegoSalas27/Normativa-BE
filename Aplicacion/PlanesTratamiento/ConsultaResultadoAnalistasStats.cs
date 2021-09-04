using Aplicacion.Dtos.statistics.Tratamiento;
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

namespace Aplicacion.PlanesTratamiento
{
    public class ConsultaResultadoAnalistasStats
    {
        public class Listar : IRequest<StatisticsTratamientoResultAnalistasDto> {}

        public class Manejador : IRequestHandler<Listar, StatisticsTratamientoResultAnalistasDto>
        {
            private readonly NormativaContext _context;
            private readonly UserManager<Usuario> _userManager;
            public Manejador(NormativaContext context, UserManager<Usuario> userManager)
            {
                _context = context;
                _userManager = userManager;
            }
            public async Task<StatisticsTratamientoResultAnalistasDto> Handle(Listar request, CancellationToken cancellationToken)
            {
                List<Usuario> usuarios = (List<Usuario>)await _userManager.GetUsersInRoleAsync("Analistas");

                var usuarioIds = usuarios.Select(us => us.Id);

                var listasTratamientosStats = await _context.Tratamiento
                    .Select(tr => new TratamientoStatisticDto
                    {
                        Codigo = tr.Codigo,
                        EstadosTratamiento = tr.EstadosTratamiento,
                        Nombre = tr.Nombre,
                        TratamientoId = tr.TratamientoId,
                        UsuarioId = tr.UsuarioId,
                        Usuario = tr.Usuario
                    })
                    .Where(tr => usuarioIds.Contains(tr.UsuarioId) || tr.UsuarioId == null)
                    .ToListAsync();

                List<EstadoUsuariosDto> estadoUsuarios = new List<EstadoUsuariosDto>();
                var xAxisCategoriesStacked = new List<string>();

                estadoUsuarios.Add(new EstadoUsuariosDto
                {
                    Name = "Cancelado",
                    Data = new List<object>()
                });


                estadoUsuarios.Add(new EstadoUsuariosDto
                {
                    Name = "Sin asignar",
                    Data = new List<object>()
                });


                estadoUsuarios.Add(new EstadoUsuariosDto
                {
                    Name = "En proceso",
                    Data = new List<object>()
                });


                estadoUsuarios.Add(new EstadoUsuariosDto
                {
                    Name = "Solucionado",
                    Data = new List<object>()
                });


                estadoUsuarios.Add(new EstadoUsuariosDto
                {
                    Name = "Asignado",
                    Data = new List<object>()
                });

                xAxisCategoriesStacked.Add("Usuario Desconocido");

                foreach (var usuario in usuarios)
                {
                   xAxisCategoriesStacked.Add(usuario.Nombres + ' ' + usuario.Apellidos);
                }

                var estadoUsuarioCancelado = estadoUsuarios.Find(eu => eu.Name == "Cancelado");
                estadoUsuarioCancelado.Data.Add(null);

                var estadoUsuarioEnProceso = estadoUsuarios.Find(eu => eu.Name == "En proceso");
                estadoUsuarioEnProceso.Data.Add(null);

                var estadoUsuarioSolucionado = estadoUsuarios.Find(eu => eu.Name == "Solucionado");
                estadoUsuarioSolucionado.Data.Add(null);

                var estadoUsuarioAsignado = estadoUsuarios.Find(eu => eu.Name == "Asignado");
                estadoUsuarioAsignado.Data.Add(null);

                int countSinAsignar = listasTratamientosStats.Where(lt => lt.EstadosTratamiento.Nombre == "Sin asignar").Count();

                var estadoUsuarioSinAsignar = estadoUsuarios.Find(eu => eu.Name == "Sin asignar");
                estadoUsuarioSinAsignar.Data.Add(countSinAsignar > 0 ? countSinAsignar : null);


                foreach (var usuario in usuarios)
                {
                    var countCancelado = 0;
                    var countEnProceso = 0;
                    var countSolucionado = 0;
                    var countAsignado = 0;

                    foreach (var tratamiento in listasTratamientosStats)
                    {
                        if (tratamiento.UsuarioId == usuario.Id.ToUpper() || tratamiento.UsuarioId == usuario.Id)
                        {
                            switch (tratamiento.EstadosTratamiento.Nombre)
                            {
                                case "Cancelado":
                                    countCancelado++;
                                    break;
                                case "En proceso":
                                    countEnProceso++;
                                    break;
                                case "Solucionado":
                                    countSolucionado++;
                                    break;
                                case "Asignado":
                                    countAsignado++;
                                    break;
                            }
                        }
                    }


                    estadoUsuarioCancelado = estadoUsuarios.Find(eu => eu.Name == "Cancelado");
                    estadoUsuarioCancelado.Data.Add(countCancelado > 0 ? countCancelado : null);

                    estadoUsuarioEnProceso = estadoUsuarios.Find(eu => eu.Name == "En proceso");
                    estadoUsuarioEnProceso.Data.Add(countEnProceso > 0 ? countEnProceso : null);

                    estadoUsuarioSolucionado = estadoUsuarios.Find(eu => eu.Name == "Solucionado");
                    estadoUsuarioSolucionado.Data.Add(countSolucionado > 0 ? countSolucionado : null);

                    estadoUsuarioAsignado = estadoUsuarios.Find(eu => eu.Name == "Asignado");
                    estadoUsuarioAsignado.Data.Add(countAsignado > 0 ? countAsignado : null);

                    estadoUsuarioSinAsignar = estadoUsuarios.Find(eu => eu.Name == "Sin asignar");
                    estadoUsuarioSinAsignar.Data.Add(null);
                }


                var response = new StatisticsTratamientoResultAnalistasDto
                {
                    StackedBarSeries = estadoUsuarios,
                    XAxisCategoriesStacked = xAxisCategoriesStacked,
                };

                return response;
            }
        }
    }
}
