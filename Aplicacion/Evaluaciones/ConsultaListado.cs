using Aplicacion.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using Persistencia.DapperConexion.Paginacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Evaluaciones
{
    public class ConsultaListado
    {
        public class Listar : IRequest<PaginacionModel>
        {
            public int NumeroPagina { get; set; }
            public int CantidadElementos { get; set; }
            public Dictionary<string, object> Parametros { get; set; } = new Dictionary<string, object>();
        }

        public class Manejador : IRequestHandler<Listar, PaginacionModel>
        {
            /* private readonly NormativaContext _context;
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

                 return evluaciones;  */

            private readonly IPaginacion _paginacion;
            public Manejador(IPaginacion paginacion)
            {
                _paginacion = paginacion;
            }
            public async Task<PaginacionModel> Handle(Listar request, CancellationToken cancellationToken)
            {
                var storedProcedure = "usp_obtener_paginacion_evaluacionV2";
                return await _paginacion.devolverPaginacion(
                    storedProcedure,
                    request.NumeroPagina,
                    request.CantidadElementos,
                    request.Parametros,
                    //ordenamiento
                    null
                );
            }
        }
    }
}