using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Empleados
{
    public class Consulta
    {
        public class ListarEmpleados : IRequest<List<Empleado>> { }
        public class Manejador : IRequestHandler<ListarEmpleados, List<Empleado>>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                this._context = context;
            }
            public async Task<List<Empleado>> Handle(ListarEmpleados request, CancellationToken cancellationToken)
            {
                var usuarios = await _context.Empleado.ToListAsync();
                return usuarios;
            }
        }
    }
}
