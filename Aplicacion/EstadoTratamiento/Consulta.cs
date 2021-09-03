using Aplicacion.Dtos;
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

namespace Aplicacion.EstadoTratamiento
{
    public class Consulta
    {
        public class Listar : IRequest<List<ListarEstadoTratamientoDto>>
        {
            public string UserRol { get; set; }
        }

        public class Manejador : IRequestHandler<Listar, List<ListarEstadoTratamientoDto>>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<List<ListarEstadoTratamientoDto>> Handle(Listar request, CancellationToken cancellationToken)
            {
                var estadosTratamientos = new List<ListarEstadoTratamientoDto>();

                if (request.UserRol == "Jefe de riesgos")
                {
                    estadosTratamientos = await _context.EstadosTratamiento
                        .Select(e => new ListarEstadoTratamientoDto
                        {
                            EstadosTratamientoId = e.EstadosTratamientoId,
                            Nombre = e.Nombre,
                        })
                        .Where(o => o.Nombre == "Asignado" || o.Nombre == "Sin asignar" || o.Nombre == "Solucionado" || o.Nombre == "Cancelado")
                        .ToListAsync();
                }

                if (request.UserRol == "Analistas")
                {
                    estadosTratamientos = await _context.EstadosTratamiento
                       .Select(e => new ListarEstadoTratamientoDto
                       {
                           EstadosTratamientoId = e.EstadosTratamientoId,
                           Nombre = e.Nombre,
                       })
                       .Where(o => o.Nombre == "En proceso" || o.Nombre == "Asignado")
                       .ToListAsync();
                }

                return estadosTratamientos;
            }
        }
    }
}
