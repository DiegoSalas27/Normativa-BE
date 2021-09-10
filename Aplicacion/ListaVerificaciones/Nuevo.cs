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

namespace Aplicacion.ListaVerificaciones
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public string ListaVerificacionCodigo { get; set; }
            public string ListaVerificacionNombre { get; set; }
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
                var listaVerificacionExists = await _context.ListaVerificacion.Where(lv => lv.Codigo == request.ListaVerificacionCodigo).FirstOrDefaultAsync();

                if (listaVerificacionExists != null)
                {
                    throw new ManejadorExcepcion(HttpStatusCode.BadRequest, new { mensaje = "Regresar" });
                }

                if (listaVerificacionExists == null)
                {
                    var listaVerificacion = new ListaVerificacion
                    {
                        Codigo = request.ListaVerificacionCodigo,
                        FechaCreacion = DateTime.Now,
                        Nombre = request.ListaVerificacionNombre,
                    };

                    _context.ListaVerificacion.Add(listaVerificacion);
                }
                else
                {
                    listaVerificacionExists.Nombre = request.EvaluacionNombre;
                }

                var valor = await _context.SaveChangesAsync();
                if (valor > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo insertar la lista de verificacion");
            }
        }
    }
}