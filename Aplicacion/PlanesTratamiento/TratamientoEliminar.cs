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

                var accion = await _context.AccionMitigacion
                    .Where(t => t.TratamientoId == tratamiento.TratamientoId)
                    .ToListAsync();
                foreach (var element in accion)
                {
                    var evidenciaRequerimiento = await _context.EvidenciaRequerimiento

                    .Where(am => am.AccionMitigacionId== element.AccionMitigacionId)

                    .ToListAsync();

                    _context.EvidenciaRequerimiento.RemoveRange(evidenciaRequerimiento);
                }


                _context.AccionMitigacion.RemoveRange(accion);

                _context.Tratamiento.Remove(tratamiento);

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


