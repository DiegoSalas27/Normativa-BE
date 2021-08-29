using Dominio;
using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Evidencias
{
    public class Editar
    {
        public class Ejecuta : IRequest<Evidencia>
        {
            public Guid? EvidenciaId { get; set; }
            public string NombreAdjunto { get; set; }
            public string AdjuntoURL { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, Evidencia>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                this._context = context;
            }
            public async Task<Evidencia> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var evidencia = await _context.Evidencia.FindAsync(request.EvidenciaId);

                if (evidencia != null) 
                {
                    evidencia.Adjunto = request.NombreAdjunto;
                    evidencia.AdjuntoURL = request.AdjuntoURL;
                }

                await _context.SaveChangesAsync();
     
                return evidencia;
            }
        }
    }
}
