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
//    public class Eliminar
//    {
//        public class Ejecuta : IRequest
//        { 
//            public int Id { get; set; }
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

//                _context.Remove(empleado);
//                var result = await _context.SaveChangesAsync();
//                if (result > 0)
//                {
//                    return Unit.Value;
//                }

//                throw new Exception("No se pudo eliminar curso");
//            }
//        }
//    }
//}
