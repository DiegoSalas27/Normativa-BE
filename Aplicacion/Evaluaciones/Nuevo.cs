using Aplicacion.ManejadorError;
using Dominio;
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
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public string EvaluacionCodigo { get; set; }
            public string EstadoEvaluacion { get; set; }
            public string EvaluacionNombre { get; set; }
            public Guid ObraId { get; set; }
            public Guid ListaVerificacionId { get; set; }
            public string UsuarioId { get; set; }
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
                var evaluacionExists = await _context.Evaluacion.Where(ev => ev.Codigo == request.EvaluacionCodigo).FirstOrDefaultAsync();

                if (evaluacionExists != null && evaluacionExists.Visbilidad)
                {
                    throw new ManejadorExcepcion(HttpStatusCode.BadRequest, new { mensaje = "Regresar" });
                }

                if (evaluacionExists == null)
                {
                    var evaluacion = new Evaluacion
                    {
                        ObraId = request.ObraId,
                        ListaVerificacionId = request.ListaVerificacionId,
                        UsuarioId = request.UsuarioId,
                        Codigo = request.EvaluacionCodigo,
                        FechaCreacion = DateTime.Now,
                        Estado = request.EstadoEvaluacion,
                        Nombre = request.EvaluacionNombre,
                        PorcentajeFinal = 0,
                    };

                    _context.Evaluacion.Add(evaluacion);
                }
                else
                {
                    evaluacionExists.Nombre = request.EvaluacionNombre;
                }

                var valor = await _context.SaveChangesAsync();
                if (valor > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo insertar la evaluacion");
            }
        }
    }
}
