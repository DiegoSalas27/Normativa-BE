using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistencia.DapperConexion.Paginacion;

namespace Aplicacion.Paginacion
{
    public class Paginacion
    {
        public class Ejecuta : IRequest<PaginacionModel>
        {
            //public string Titulo { get; set; } // filtrar por curso o cualquier propiedad (es dinamico)
            public string Rol { get; set; }
            public int NumeroPagina { get; set; }
            public int CantidadElementos { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, PaginacionModel>
        {
            private readonly IPaginacion _paginacion;
            public Manejador(IPaginacion paginacion)
            {
                _paginacion = paginacion;
            }
            public async Task<PaginacionModel> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var storedProcedure = "usp_obtener_paginacion_usuario";
                //var ordenamiento = "Titulo";
                var parametros = new Dictionary<string, object>();
                parametros.Add("Rol", request.Rol);
                return await _paginacion.devolverPaginacion(
                    storedProcedure,
                    request.NumeroPagina,
                    request.CantidadElementos,
                    parametros,
                    //ordenamiento
                    null
                );
            }
        }
    }
}
