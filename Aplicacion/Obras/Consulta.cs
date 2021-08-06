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

namespace Aplicacion.Obras
{
    public class Consulta
    {
        public class Listar : IRequest<List<Obra>>
        { 
            public string QueryLike { get; set; }
        }

        public class Manejador : IRequestHandler<Listar, List<Obra>>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<List<Obra>> Handle(Listar request, CancellationToken cancellationToken)
            {
                var obras = await _context.Obra.Where(o => o.Nombre.Contains(request.QueryLike) || o.Codigo.Contains(request.QueryLike))
                    .ToListAsync();
                return obras;
            }
        }
    }
}
