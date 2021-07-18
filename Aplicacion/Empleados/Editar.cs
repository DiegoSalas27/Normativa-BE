//using Aplicacion.ManejadorError;
//using MediatR;
//using Persistencia;
//using System;
//using System.Collections.Generic;
//using System.Net;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Aplicacion.Empleados
//{
//    public class Editar
//    {
//        public class Ejecuta : IRequest 
//        {
//            public int Id { get; set; }
//            public int? RolId { get; set; }
//            public string Correo { get; set; }
//            public string Contrasena { get; set; }
//            public DateTime? FechaNacimiento { get; set; }
//            public int? EspecialidadId { get; set; }
//        }

//        public class Manejador : IRequestHandler<Ejecuta>
//        {
//            private readonly NormativaContext _context;
//            public Manejador(NormativaContext context)
//            {
//                this._context = context;
//            }

//            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
//            {
//                var empleado = await _context.Empleado.FindAsync(request.Id);
//                if (empleado == null)
//                {
//                    throw new ManejadorExcepcion(HttpStatusCode.NotFound, new { curso = "No se encontro el empleado" });
//                }

//                empleado.RolId = request.RolId ?? empleado.RolId;
//                empleado.Correo = request.Correo ?? empleado.Correo;
//                empleado.Contrasena = request.Contrasena ?? empleado.Contrasena;
//                empleado.FechaNacimiento = request.FechaNacimiento ?? empleado.FechaNacimiento;
//                empleado.EspecialidadId  = request.EspecialidadId ?? empleado.EspecialidadId;

//                var resultado = await _context.SaveChangesAsync();
//                if (resultado > 0)
//                {
//                    return Unit.Value;
//                }

//                throw new Exception("El empleado no pudo ser editado");
//            }
//        }
//    }
//}
