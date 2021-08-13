using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.AccionesMitigacion
{
    public class ConsultaLista
    {
        public class Listar : IRequest<List<AccionMitigacion>>
        {
            public Guid TratamientoId { get; set; }
            public string CodigoPrueba { get; set; }
        }

        public class Manejador : IRequestHandler<Listar, List<AccionMitigacion>>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<List<AccionMitigacion>> Handle(Listar request, CancellationToken cancellationToken)
            {
                var accionesMitigacion = await _context.AccionMitigacion
                    .Where(acm => acm.TratamientoId == request.TratamientoId && acm.EvidenciaRequerimiento.Prueba.Codigo == request.CodigoPrueba)
                    .ToListAsync();

                return accionesMitigacion;
            }
        }
    }
}
