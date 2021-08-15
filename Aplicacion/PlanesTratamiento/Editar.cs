using Dominio;
using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.PlanesTratamiento
{
    public class Editar
    {
        public class Ejecuta : IRequest
        {
            public Guid TratamientoId { get; set; }
            public Guid EvaluacionId { get; set; }
            public Guid UsuarioId { get; set; }
            public string Nombre { get; set; }
            public string Codigo { get; set; }
            public List<AccionMitigacion> AccionMitigacionList { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                this._context = context;
            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {

                var tratamiento = await _context.Tratamiento.FindAsync(request.TratamientoId);

                tratamiento.EvaluacionId = request.EvaluacionId;
                tratamiento.UsuarioId = request.UsuarioId;
                tratamiento.Nombre = request.Nombre;
                tratamiento.Codigo = request.Codigo;

                foreach (var accionMitigacion in request.AccionMitigacionList)
                {
                    var foundAccionMitigacion = await _context.AccionMitigacion.FindAsync(accionMitigacion.AccionMitigacionId);
                    foundAccionMitigacion.Descripcion = accionMitigacion.Descripcion;   
                    foundAccionMitigacion.FechaInicio = accionMitigacion.FechaInicio;
                    foundAccionMitigacion.FechaFin = accionMitigacion.FechaFin;
                }

                var valor = await _context.SaveChangesAsync();

                if (valor > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo editar el tratamiento");
            }
        }
    }
}
