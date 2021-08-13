using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.PlanesTratamiento
{
    public class ConsultaCantidad
    {
        public class Listar : IRequest<int> { }

        public class Manejador : IRequestHandler<Listar, int>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(Listar request, CancellationToken cancellationToken)
            {
                var countTratamiento = await _context.Tratamiento.CountAsync();
                return countTratamiento;
            }
        }
    }
}
