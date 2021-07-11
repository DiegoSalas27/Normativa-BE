using Dominio;
using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Usuarios
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public int RolId { get; set; }
            public string Correo { get; set; }
            public string Contrasena { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public int EspecialidadId { get; set; }
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
                var usuario = new Usuario
                {
                    RolId = request.RolId,
                    Correo = request.Correo,
                    Contrasena = request.Contrasena,
                    FechaNacimiento = request.FechaNacimiento,
                    EspecialidadId = request.EspecialidadId
        };

                _context.Usuario.Add(usuario);
                var result = await _context.SaveChangesAsync();
                if (result > 0) 
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo insertar usuario");
            }
        }
    }
}
