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

namespace Aplicacion.Especialidades
{
    public class Consulta
    {
        public class Listar : IRequest<List<Especialidad>> 
        { 
            public string Rol { get; set; }
        }
        public class Manejador : IRequestHandler<Listar, List<Especialidad>>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
               _context = context;
            }
            public async Task<List<Especialidad>> Handle(Listar request, CancellationToken cancellationToken)
            {
                var rol = _context.Roles.Where(x => x.Name == request.Rol).First();
                return await _context.Especialidad.Where(x => x.RolId == new Guid(rol.Id)).ToListAsync();
            }
        }
    }
}
