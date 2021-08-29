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

namespace Aplicacion.Evidencias
{
    public class EvidenciaLista
    {
        public class Ejecuta : IRequest<List<Evidencia>> 
        { 
            public string QueryLike { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, List<Evidencia>>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<List<Evidencia>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var evidencias = await _context.Evidencia
                    .Where(ev => ev.Adjunto != "" && ev.Nombre.Contains(request.QueryLike) || ev.Codigo.Contains(request.QueryLike))
                    .ToListAsync();
                return evidencias;
            }
        }
    }
}
