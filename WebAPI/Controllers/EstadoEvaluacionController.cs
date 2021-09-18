using Aplicacion.Dtos;
using Aplicacion.EstadoEvaluacion;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class EstadoEvaluacionController : MiControllerBase
    {
        [HttpGet("lista")]
        public async Task<ActionResult<List<ListarEstadoEvaluacionDto>>> Listar()
        {
            return await Mediator.Send(new Consulta.Listar());
        }
    }
}
