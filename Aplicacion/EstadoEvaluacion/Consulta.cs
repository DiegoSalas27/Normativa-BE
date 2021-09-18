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

namespace Aplicacion.EstadoEvaluacion
{
    public class Consulta
    {
        public class Listar : IRequest<List<ListarEstadoEvaluacionDto>>
        {
            public string UserRol { get; set; }
        }

        public class Manejador : IRequestHandler<Listar, List<ListarEstadoEvaluacionDto>>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<List<ListarEstadoEvaluacionDto>> Handle(Listar request, CancellationToken cancellationToken)
            {
                var estadosTratamientos = await _context.EstadosEvaluacion
                       .Select(e => new ListarEstadoEvaluacionDto
                       {
                           EstadosEvaluacionId = e.EstadosEvaluacionId,
                           Nombre = e.Nombre,
                       })
                       .ToListAsync();

                return estadosTratamientos;
            }
        }
    }
}
