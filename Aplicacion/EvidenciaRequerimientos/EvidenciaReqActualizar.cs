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

namespace Aplicacion.EvidenciaRequerimientos
{
    public class EvidenciaReqActualizar
    {
        public class Ejecuta : IRequest
        {
            public Guid EvidenciaId { get; set; }
            public Guid PruebaId { get; set; }
            public Guid RequerimientoId { get; set; }

            public Guid TratamientoId { get; set; }
            public Guid AccionMitigacionId { get; set; }
            public string Descripcion { get; set; }
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
                var evidenciaRequerimientoExists = await _context.EvidenciaRequerimiento
                   .Where(evR => evR.EvidenciaId == request.EvidenciaId && evR.RequerimientoId == request.RequerimientoId
                   && evR.PruebaId == request.PruebaId)
                   .FirstOrDefaultAsync();

                //evidenciaRequerimientoExists.Recomendacion = request.Recomendacion;

                if (evidenciaRequerimientoExists.AccionMitigacionId != null)
                {
                    var accionMitigacion = await _context.AccionMitigacion.FindAsync(evidenciaRequerimientoExists.AccionMitigacionId);

                    accionMitigacion.Descripcion = request.Descripcion;
                }
                else
                {
                    var accionMitigacion = new AccionMitigacion
                    {
                        AccionMitigacionId = request.AccionMitigacionId,
                        Descripcion = request.Descripcion,
                        TratamientoId = request.TratamientoId
                    };

                    evidenciaRequerimientoExists.AccionMitigacionId = request.AccionMitigacionId;

                    _context.AccionMitigacion.Add(accionMitigacion);
                }

                var resultado = await _context.SaveChangesAsync();

                return Unit.Value;

                //throw new Exception("No se pudo actualizar evidencia requerimiento");
            }
        }
    }
}
