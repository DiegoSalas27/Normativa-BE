using Aplicacion.Dtos;
using Aplicacion.ListaVerificaciones;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.Dtos.statistics.ListaVerificacion;
using Persistencia.DapperConexion.Paginacion;
using Aplicacion.Paginacion;

namespace WebAPI.Controllers
{
    public class ListaVerificacionesController : MiControllerBase
    {
        [HttpGet("count")]
        public async Task<ActionResult<int>> ObtenerNumeroListasVerificacionCount()
        {
            return await Mediator.Send(new ConsultaCantidad.Listar());
        }

        [HttpGet("ultimoCodigo")]
        public async Task<ActionResult<object>> ObtenerListaVerificacionLastCode()
        {
            return await Mediator.Send(new ConsultaUltimoCodigo.Listar());
        }


        [HttpGet("listar")]
        public async Task<ActionResult<PaginacionModel>> ObtenerUsuariosPorRolPaginado(string rol,
            [FromQuery(Name = "page")] int page, [FromQuery(Name = "quantity")] int quantity, [FromQuery(Name = "listaVerif")] string listaVerif)
        {
            return await Mediator.Send(new Paginacion.Ejecuta { 
                Rol = rol, 
                NumeroPagina = page, 
                CantidadElementos = quantity, 
                Entity = "ListaVerificacion",
                Parametros = new Dictionary<string, object> {
                  { "listaVerif" , listaVerif }
                }
            });
        }

        [HttpGet("lista")]
        public async Task<ActionResult<List<ObtenerListaVerificacionDto>>> Listar([FromQuery(Name = "filter")] string filter)
        {
            if (filter == null)
                filter = "";
            return await Mediator.Send(new Consulta.Listar { QueryLike = filter });
        }

        [HttpGet("statistics/lista")]
        public async Task<ActionResult<StatisticsListaVerificacion>> EstadisticaListaVerificacion()
        {
            return await Mediator.Send(new ConsultaListaVerificacionStats.Listar());
        }

        [HttpPut("{listaVerificacionId}")]
        public async Task<ActionResult<Unit>> ActualizarListaVerificacion(Guid listaVerificacionId, Edita.Ejecuta parametros)
        {
            return await Mediator.Send(parametros);
        }
        [HttpPost]
        public async Task<ActionResult<Unit>> RegistrarListaVerificacion(Nuevo.Ejecuta parametros)
        {
            return await Mediator.Send(parametros);
        }
        [HttpDelete("{listaVerificacionId}")]
        public async Task<ActionResult<Unit>> EliminarListaVerificacion(Guid listaVerificacionId, [FromQuery(Name = "Update")] bool Update)
        {
            return await Mediator.Send(new ListaVerificacionEliminar.Ejecuta { ListaVerificacionId = listaVerificacionId, Update = Update });
        }
    }
}
