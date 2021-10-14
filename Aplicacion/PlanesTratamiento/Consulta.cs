using Aplicacion.Dtos;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Persistencia.DapperConexion.Paginacion;

namespace Aplicacion.PlanesTratamiento
{
    public class Consulta
    {
        public class Listar : IRequest<PaginacionModel>
        { //public string Titulo { get; set; } // filtrar por curso o cualquier propiedad (es dinamico)
           // public string Estado { get; set; }
            public int NumeroPagina { get; set; }
            public int CantidadElementos { get; set; }

            public Dictionary<string, object> Parametros { get; set; } = new Dictionary<string, object>();
        }

        public class Manejador : IRequestHandler<Listar, PaginacionModel>
        {
            //    private readonly NormativaContext _context;
            //    public Manejador(NormativaContext context)
            //    {
            //        _context = context;
            //    }
            //    public async Task<List<ListarTratamientoDto>> Handle(Listar request, CancellationToken cancellationToken)
            //    {
            //        var tratamientos = await _context.Tratamiento
            //            .Select(t => new ListarTratamientoDto
            //            {
            //                TratamientoId = t.TratamientoId,
            //                EvaluacionId = t.EvaluacionId,
            //                Codigo = t.Codigo,
            //                Nombre = t.Nombre,
            //                FechaInicio = t.FechaInicio,
            //                FechaFin = t.FechaFin,
            //                UsuarioId = t.UsuarioId,
            //                Evaluacion = t.Evaluacion.Codigo + " - " + t.Evaluacion.Nombre,
            //                Responsable = t.Usuario.Nombres
            //            })
            //            .Where(o => (o.Nombre.Contains(request.QueryLike) || o.Codigo.Contains(request.QueryLike)) )
            //            .ToListAsync();

            //        return tratamientos;
            //    }
            private readonly IPaginacion _paginacion;
            public Manejador(IPaginacion paginacion)
            {
                _paginacion = paginacion;
            }
            public async Task<PaginacionModel> Handle(Listar request, CancellationToken cancellationToken)
            {
                var storedProcedure = "usp_obtener_paginacion_plan_tratamientoV2";
                //var ordenamiento = "Titulo";
                //var parametros = new Dictionary<string, object>();
               // parametros.Add("Estado", request.Estado);
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