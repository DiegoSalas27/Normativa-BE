//using Aplicacion.ManejadorError;
//using Dominio;
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
//    public class ConsultaId
//    {
//        public class EmpleadoUnico : IRequest<Empleado>
//        { 
//            public int Id { get; set; }
//        }
//        public class Manejador : IRequestHandler<EmpleadoUnico, Empleado>
//        {
//            private readonly NormativaContext _context;
//            public Manejador(NormativaContext context)
//            {
//                this._context = context;
//            }
//            public async Task<Empleado> Handle(EmpleadoUnico request, CancellationToken cancellationToken)
//            {
//                var usuario = await _context.Empleado.FindAsync(request.Id);
//                if (usuario == null)
//                {
//                    throw new ManejadorExcepcion(HttpStatusCode.NotFound, new { curso = "No se encontro el usuario" });
//                }
//                return usuario;
//            }
//        }
//    }
//}
