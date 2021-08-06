using Aplicacion.ManejadorError;
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Pruebas
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<Ejecuta>
        {
            public Guid EvaluacionId { get; set; }
            public string Codigo { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, Ejecuta>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                this._context = context;
            }
            public async Task<Ejecuta> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var pruebaExists = await _context.Prueba.Where(pr => pr.Codigo == request.Codigo).FirstOrDefaultAsync();

                if (pruebaExists != null && pruebaExists.Visbilidad)
                {
                    throw new ManejadorExcepcion(HttpStatusCode.BadRequest, new { mensaje = "Regresar" });
                }

                if (pruebaExists == null)
                {
                    var prueba = new Prueba
                    {
                        EvaluacionId = request.EvaluacionId,
                        Codigo = request.Codigo,
                        FechaCreacion = DateTime.Now,
                        PorcentajeCumplimiento = 0,
                    };

                    _context.Prueba.Add(prueba);
                }

                var valor = await _context.SaveChangesAsync();
                if (valor > 0)
                {
                    return request;
                }

                throw new Exception("No se pudo insertar la prueba");
            }
        }
    }
}
