using MediatR;
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
    public class EvaluacionActualizar
    {
        public class Ejecuta : IRequest
        {
            public Guid EvaluacionId { get; set; }
            public string Nombre { get; set; }
            public Guid Estado { get; set; }
            public string CodigoEspecialista { get; set; }
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
                var evaluacion = await _context.Evaluacion.FindAsync(request.EvaluacionId);
                var estadoSelected = await _context.EstadosEvaluacion
                    .Where(eve => eve.EstadosEvaluacionId == request.Estado && eve.Nombre == "Aprobado")
                    .AnyAsync();

                if (estadoSelected)
                {
                    evaluacion.FechaAprobacion = DateTime.Now;
                }

                evaluacion.Nombre = request.Nombre;
                evaluacion.EstadosEvaluacionId = request.Estado;
                evaluacion.CodigoEspecialista = request.CodigoEspecialista ?? evaluacion.CodigoEspecialista;

                var resultado = await _context.SaveChangesAsync();

                if (resultado > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo actualizar evaluacion");
            }
        }
    }
}
