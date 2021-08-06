using Aplicacion.Dtos;
using Aplicacion.Pruebas;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class PruebaController : MiControllerBase
    {
        [HttpGet("count")]
        public async Task<ActionResult<int>> ObtenerNumeroPruebasCount()
        {
            return await Mediator.Send(new ConsultaCantidad.Listar());
        }

        [HttpGet("{pruebaId}")]
        public async Task<ActionResult<ResultadoPruebaDto>> ObtenerResultadosDePrueba(Guid pruebaId) 
        {
            return await Mediator.Send(new ObtenerResultadosPrueba.Listar { PruebaId = pruebaId });
        }

        [HttpPut("activar/{pruebaId}")]
        public async Task<ActionResult<Unit>> ActualizarPrueba(Guid pruebaId)
        {
            return await Mediator.Send(new PruebaActualizar.Ejecuta { PruebaId = pruebaId });
        }

        [HttpPost]
        public async Task<ActionResult<Nuevo.Ejecuta>> RegistrarPrueba(Nuevo.Ejecuta parametros)
        {
            return await Mediator.Send(parametros);
        }
    }
}
