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

namespace Aplicacion.AccionesMitigacion
{
    public class EliminarAccion
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
                var accionMitigacion = await _context.AccionMitigacion.FindAsync(request.Id);
                if (accionMitigacion == null)
                {
                    throw new ManejadorExcepcion(HttpStatusCode.NotFound, new { mensaje = "La accion mitigacion no existe" });
                }

                var evidenciaRequerimiento = await _context.EvidenciaRequerimiento
                    .Where(evR => evR.AccionMitigacionId == request.Id)
                    .ToListAsync();

                var comentarios = await _context.Comentario
                    .Where(com => com.AccionMitigacionId == request.Id)
                    .ToListAsync();

                foreach (var evidencia in evidenciaRequerimiento)
                {
                    evidencia.AccionMitigacionId = null;
                }

                _context.RemoveRange(comentarios);

                _context.Remove(accionMitigacion);


                var valor = await _context.SaveChangesAsync();

                if (valor > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo eliminar la accionMitigacion");
            }
        }
    }
}
