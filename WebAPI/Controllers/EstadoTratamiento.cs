using Aplicacion.Dtos;
using Aplicacion.EstadoTratamiento;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class EstadoTratamiento : MiControllerBase
    {
        [HttpGet("lista")]
        public async Task<ActionResult<List<ListarEstadoTratamientoDto>>> Listar([FromQuery(Name = "rolUsuario")] string rolUsuario)
        {
            if (rolUsuario == null)
                rolUsuario = "";
            return await Mediator.Send(new Consulta.Listar { UserRol = rolUsuario });
        }
    }
}
