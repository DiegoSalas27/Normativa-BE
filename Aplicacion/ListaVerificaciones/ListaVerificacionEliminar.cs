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
    public class ListaVerificacionEliminar
    {
        public class Ejecuta : IRequest
        {
            public Guid ListaVerificacionId { get; set; }
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
                var listaVerificacion = await _context.ListaVerificacion.FindAsync(request.ListaVerificacionId);
                if (listaVerificacion == null)
                {
                    throw new ManejadorExcepcion(HttpStatusCode.NotFound, new { mensaje = "La lista de verificacion no existe" });
                }

                var requerimientos = await _context.Requerimiento
                    .Where(r => r.ListaVerificacionId == listaVerificacion.ListaVerificacionId)
                    .ToListAsync();
                var nivelesRiesgo = await _context.NivelesRiesgo
                    .Where(nr => nr.ListaVerificacionId == listaVerificacion.ListaVerificacionId)
                    .ToListAsync();
                _context.Requerimiento.RemoveRange(requerimientos);
                _context.NivelesRiesgo.RemoveRange(nivelesRiesgo);
                _context.ListaVerificacion.Remove(listaVerificacion);

                var valor = await _context.SaveChangesAsync();

                if (valor > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo eliminar la lista de verificacion");
            }
        }
    }
}