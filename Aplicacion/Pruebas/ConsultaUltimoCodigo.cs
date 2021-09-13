using Aplicacion.Constants;
using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Pruebas
{
    public class ConsultaUltimoCodigo
    {
        public class Listar : IRequest<object> { }

        public class Manejador : IRequestHandler<Listar, object>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<object> Handle(Listar request, CancellationToken cancellationToken)
            {
                string codigoPrueba = _context.Prueba.OrderByDescending(ev => ev.Codigo).FirstOrDefault().Codigo;
                string output = "";
                if (codigoPrueba == null)
                {
                    output = EntityCodes.Prueba + "001";
                }
                else
                {
                    string substr = codigoPrueba.Substring(2, 3);
                    output = EntityCodes.Prueba + (int.Parse(substr) + 1).ToString().PadLeft(substr.Length, '0');
                }

                return new { codigo = output };
            }
        }
    }
}
