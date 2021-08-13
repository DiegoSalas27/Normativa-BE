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
    public class AccionMitigacionActualizar
    {
        public class Ejecuta : IRequest
        {
            public Guid AccionMitigacionId { get; set; }
            public string Descripcion { get; set; }
            public DateTime? FechaInicio { get; set; }
            public DateTime? FechaFin { get; set; }
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

                accionMitigacion.Descripcion = request.Descripcion;
                accionMitigacion.FechaInicio = request.FechaInicio ?? accionMitigacion.FechaInicio;
                accionMitigacion.FechaFin = request.FechaFin ?? accionMitigacion.FechaFin;

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
