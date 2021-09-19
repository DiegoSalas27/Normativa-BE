using Aplicacion.ManejadorError;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Evaluaciones
{
    public class EvaluacionEliminar
    {
        public class Ejecuta : IRequest
        {
            public Guid Id { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly NormativaContext _context;

            public Manejador(NormativaContext normativaContext)
            {
                _context = normativaContext;

            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var evaluacion = await _context.Evaluacion.FindAsync(request.Id);
                if (evaluacion == null)
                {
                    throw new ManejadorExcepcion(HttpStatusCode.NotFound, new { mensaje = "La evaluacion no existe" });
                }

                var prueba= await _context.Prueba
                    .Where(ev => ev.EvaluacionId == evaluacion.EvaluacionId)
                    .ToListAsync();
                foreach (var element in prueba)
                {
                    var evidenciaRequerimiento = await _context.EvidenciaRequerimiento

                    .Where(evR => evR.PruebaId == element.PruebaId)

                    .ToListAsync();

                    _context.EvidenciaRequerimiento.RemoveRange(evidenciaRequerimiento);
                }

                
                _context.Prueba.RemoveRange(prueba);

                _context.Evaluacion.Remove(evaluacion);

                var valor = await _context.SaveChangesAsync();

                if (valor > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo eliminar la evaluacion");
            }
        }
    }
}
