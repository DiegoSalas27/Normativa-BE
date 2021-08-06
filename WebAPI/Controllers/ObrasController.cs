using Aplicacion.Obras;
using Dominio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class ObrasController : MiControllerBase
    {
        [HttpGet("lista")]
        public async Task<ActionResult<List<Obra>>> Listar([FromQuery(Name="filter")] string filter)
        {
            if (filter == null) 
                filter = "";
            return await Mediator.Send(new Consulta.Listar { QueryLike = filter });
        }
    }
}
