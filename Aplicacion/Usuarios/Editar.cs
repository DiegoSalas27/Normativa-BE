using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Usuarios
{
    public class Editar
    {
        public class Ejecuta : IRequest 
        {
            public int Id { get; set; }
            public int? RolId { get; set; }
            public string Correo { get; set; }
            public string Contrasena { get; set; }
            public DateTime? FechaNacimiento { get; set; }
            public int? EspecialidadId { get; set; }
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
                var usuario = await _context.Usuario.FindAsync(request.Id);
                if (usuario == null)
                {
                    throw new Exception("Usuario no existe");
                }

                usuario.RolId = request.RolId ?? usuario.RolId;
                usuario.Correo = request.Correo ?? usuario.Correo;
                usuario.Contrasena = request.Contrasena ?? usuario.Contrasena;
                usuario.FechaNacimiento = request.FechaNacimiento ?? usuario.FechaNacimiento;
                usuario.EspecialidadId  = request.EspecialidadId ?? usuario.EspecialidadId;

                var resultado = await _context.SaveChangesAsync();
                if (resultado > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("El usuario no pudo ser editado");
            }
        }
    }
}
