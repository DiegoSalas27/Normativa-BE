using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Usuarios
{
    public class Consulta
    {
        public class ListarUsuarios : IRequest<List<Usuario>> { }
        public class Manejador : IRequestHandler<ListarUsuarios, List<Usuario>>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                this._context = context;
            }
            public async Task<List<Usuario>> Handle(ListarUsuarios request, CancellationToken cancellationToken)
            {
                var usuarios = await _context.Usuario.ToListAsync();
                return usuarios;
            }
        }
    }
}
