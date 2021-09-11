using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.ListaVerificaciones
{
    public class ListaVerificacionActualizar
    {
        public class Ejecuta : IRequest
        {
            public Guid ListaVerificacionId { get; set; }
            public string Nombre { get; set; }
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
                var listaVerificacion = await _context.ListaVerificacion.FindAsync(request.ListaVerificacionId);

                listaVerificacion.Nombre = request.Nombre;

                var resultado = await _context.SaveChangesAsync();

                if (resultado > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo actualizar lista de verificacion");
            }
        }
    }
}