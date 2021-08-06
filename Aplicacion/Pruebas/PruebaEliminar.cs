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

namespace Aplicacion.Pruebas
{
    public class PruebaEliminar
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
                var prueba = await _context.Prueba.FindAsync(request.Id);
                if (prueba == null)
                {
                    throw new ManejadorExcepcion(HttpStatusCode.NotFound, new { mensaje = "La prueba no existe" });
                }

                var evidenciaRequerimiento = await _context.EvidenciaRequerimiento
                    .Where(evR => evR.PruebaId == prueba.PruebaId)
                    .ToListAsync();

                _context.EvidenciaRequerimiento.RemoveRange(evidenciaRequerimiento);

                _context.Prueba.Remove(prueba);

                var valor = await _context.SaveChangesAsync();

                if (valor > 0) 
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo eliminar la prueba");
            }
        }
    }
}
