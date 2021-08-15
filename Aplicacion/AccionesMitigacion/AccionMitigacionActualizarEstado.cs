using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.AccionesMitigacion
{
    public class AccionMitigacionActualizarEstado
    {
        public class Ejecuta : IRequest
        {
            public Guid AccionMitigacionId { get; set; }
            public bool Estado { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly NormativaContext _context;

            public Manejador(
                NormativaContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var accionMitigacion = await _context.AccionMitigacion.FindAsync(request.AccionMitigacionId);

                accionMitigacion.Estado = request.Estado;

                var resultado = await _context.SaveChangesAsync();

                if (resultado > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo actualizar accion mitigacion");
            }
        }
    }
}
