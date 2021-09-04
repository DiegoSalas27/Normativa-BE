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
            public Guid? EstadosTratamientoId { get; set; }
            public string UsuarioId { get; set; }
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
                try
                {
                    var tratamiento = await _context.Tratamiento.FindAsync(request.TratamientoId);

                    if (request.EstadosTratamientoId == new Guid("A2398FE0-9F21-4DE7-BA48-0B0B57B31E30"))
                    {
                        request.UsuarioId = null;
                    }

                    tratamiento.EvaluacionId = request.EvaluacionId;
                    tratamiento.UsuarioId = request.UsuarioId ?? null;
                    tratamiento.EstadosTratamientoId = request.EstadosTratamientoId ?? null;
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

                    return Unit.Value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw new Exception("No se pudo editar el tratamiento");
                }
            }
        }
    }
}
