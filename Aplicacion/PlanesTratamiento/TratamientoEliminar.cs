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


namespace Aplicacion.PlanesTratamiento
{
   public class TratamientoEliminar
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
                var tratamiento = await _context.Tratamiento.FindAsync(request.Id);
                if (tratamiento == null)
                {
                    throw new ManejadorExcepcion(HttpStatusCode.NotFound, new { mensaje = "El tratamiento no existe" });
                }

                var tratamientos = await _context.Tratamiento
                     .Where(T => T.TratamientoId == tratamiento.TratamientoId)
                     .ToListAsync();

                _context.Tratamiento.RemoveRange(tratamientos);

                _context.Tratamiento.Remove(tratamiento);

                var valor = await _context.SaveChangesAsync();

                if (valor > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo eliminar el tratamiento");
            }
        }
    }
}

