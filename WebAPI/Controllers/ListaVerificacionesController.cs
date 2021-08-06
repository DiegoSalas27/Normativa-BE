﻿using Aplicacion.Dtos;
using Aplicacion.ListaVerificaciones;
using Dominio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class ListaVerificacionesController : MiControllerBase
    {
        [HttpGet("count")]
        public async Task<ActionResult<int>> ObtenerNumeroListasVerificacionCount()
        {
            return await Mediator.Send(new ConsultaCantidad.Listar());
        }

        [HttpGet("lista")]
        public async Task<ActionResult<List<ObtenerListaVerificacionDto>>> Listar([FromQuery(Name = "filter")] string filter)
        {
            if (filter == null)
                filter = "";
            return await Mediator.Send(new Consulta.Listar { QueryLike = filter });
        }
    }
}
