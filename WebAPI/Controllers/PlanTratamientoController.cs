using Aplicacion.Dtos;
using Aplicacion.PlanesTratamiento;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult<List<ListarTratamientoDto>>> Listar([FromQuery(Name = "filter")] string filter, [FromQuery(Name = "page")] int page)
        {
            if (filter == null)
                filter = "";
            return await Mediator.Send(new Consulta.Listar { QueryLike = filter, NumeroPagina = page });
        }

        [HttpGet("{tratamientoCodigo}")]
        public async Task<ActionResult<ObtenerTratamientoDto>> ObtenerTratamiento(string tratamientoCodigo)
        {
            return await Mediator.Send(new ObtenerTratamiento.Ejecuta { Codigo = tratamientoCodigo });
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
