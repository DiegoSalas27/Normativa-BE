using Dominio;
using FluentValidation;
using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Empleados
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

        public class EjecutaValidacion : AbstractValidator<Ejecuta>
        {
            public EjecutaValidacion()
            {
                RuleFor(x => x.RolId).NotEmpty();
                RuleFor(x => x.Correo).NotEmpty();
                RuleFor(x => x.Contrasena).NotEmpty();
                RuleFor(x => x.FechaNacimiento).NotEmpty();
                RuleFor(x => x.EspecialidadId).NotEmpty();
            }
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
                var empleado = new Empleado
                {
                    RolId = request.RolId,
                    Correo = request.Correo,
                    Contrasena = request.Contrasena,
                    FechaNacimiento = request.FechaNacimiento,
                    EspecialidadId = request.EspecialidadId
        };

                _context.Empleado.Add(empleado);
                var result = await _context.SaveChangesAsync();
                if (result > 0) 
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo insertar empleado");
            }
        }
    }
}
