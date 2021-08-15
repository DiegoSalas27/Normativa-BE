using Aplicacion.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Evaluaciones
{
    public class Consulta
    {
        public class Listar : IRequest<List<ObtenerEvaluacionesDto>>
        {
            public string QueryLike { get; set; }
        }

        public class Manejador : IRequestHandler<Listar, List<ObtenerEvaluacionesDto>>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<List<ObtenerEvaluacionesDto>> Handle(Listar request, CancellationToken cancellationToken)
            {
                var evluaciones = await _context.Evaluacion
                    .Select(ev => new ObtenerEvaluacionesDto
                    {
                        EvaluacionId = ev.EvaluacionId,
                        Codigo = ev.Codigo,
                        Nombre = ev.Nombre,
                        TieneTratamiento = ev.Tratamiento != null,
                        Visbilidad = ev.Visbilidad,
                        PruebaList = ev.PruebaList
                        .Where(ev => ev.Visbilidad == true)
                        .Select(pl => new PruebaDetalleListaDto
                        {
                            Codigo = pl.Codigo,
                            FechaCreacion = pl.FechaCreacion,
                            PruebaId = pl.PruebaId,
                            Visibilidad = pl.Visbilidad
                        })
                    })
                    .Where(o => (o.Nombre.Contains(request.QueryLike) || o.Codigo.Contains(request.QueryLike)) && o.Visbilidad == true && o.TieneTratamiento == false)
                    .ToListAsync();

                return evluaciones;
            }
        }
    }
}
