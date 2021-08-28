using Aplicacion.helpers;
using Dominio;
using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Comentarios
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public string Descripcion { get; set; }
            public string UsuarioId { get; set; }
            public Guid AccionMitigacionId { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly NormativaContext _context;

            public Manejador(NormativaContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var comentario = new Comentario
                {
                    AccionMitigacionId = request.AccionMitigacionId,
                    Descripcion = request.Descripcion,
                    FechaCreacion = CustomTimeZone.DateNow(),
                    UsuarioId = request.UsuarioId,
                };

                _context.Add(comentario);

                var result = await _context.SaveChangesAsync();

                if (result > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo insertar comentario");
            }
        }
    }
}
