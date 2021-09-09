using Aplicacion.Dtos;
using Aplicacion.Dtos.statistics.Tratamiento;
using Aplicacion.PlanesTratamiento;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persistencia.DapperConexion.Paginacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class PlanTratamientoController : MiControllerBase
    {
        [HttpGet("count")]
        public async Task<ActionResult<int>> ObtenerNumeroPlanesTratamientoCount()
        {
            return await Mediator.Send(new ConsultaCantidad.Listar());
        }

        [HttpGet("lista")]
        public async Task<ActionResult<PaginacionModel>> Listar
                    ([FromQuery(Name = "page")] int page, [FromQuery(Name = "quantity")] int quantity, Consulta.Listar parametros)
        {
            parametros.CantidadElementos = quantity;
            parametros.NumeroPagina = page;

            return await Mediator.Send(parametros);
        }

        [HttpGet("{tratamientoCodigo}")]
        public async Task<ActionResult<ObtenerTratamientoDto>> ObtenerTratamiento(string tratamientoCodigo)
        {
            return await Mediator.Send(new ObtenerTratamiento.Ejecuta { Codigo = tratamientoCodigo });
        }

        [HttpGet("statistics/resultados")]
        public async Task<ActionResult<StatisticsTratamientoResultDto>> EstadisticaResultados([FromQuery(Name = "userId")] string userId)
        {
            return await Mediator.Send(new ConsultaResultadoStats.Listar { UsuarioId = userId });
        }

        [HttpGet("statistics/resultadosLista")]
        public async Task<ActionResult<StatisticsTratamientoResultListaDto>> EstadisticaResultadosLista()
        {
            return await Mediator.Send(new ConsultaResultadoStatsLista.Listar());
        }

        [HttpGet("statistics/resultados/analistas")]
        public async Task<ActionResult<StatisticsTratamientoResultAnalistasDto>> EstadisticaResultadosPorAnalista()
        {
            return await Mediator.Send(new ConsultaResultadoAnalistasStats.Listar());
        }

        [HttpPost]
        public async Task<ActionResult<Nuevo.Ejecuta>> RegistrarTratamiento(Nuevo.Ejecuta parametros)
        {
            return await Mediator.Send(parametros);
        }

        [HttpPut("{tratamientoCodigo}")]
        public async Task<ActionResult<Unit>> RegistrarTratamiento(Editar.Ejecuta parametros)
        {
            return await Mediator.Send(parametros);
        }
    }
}
