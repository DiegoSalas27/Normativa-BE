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

        [HttpGet("{pruebaCodigo}")]
        public async Task<ActionResult<ResultadoPruebaDto>> ObtenerResultadosDePrueba(string pruebaCodigo) 
        {
            return await Mediator.Send(new ObtenerResultadosPrueba.Listar { PruebaCodigo = pruebaCodigo });
        }

        [HttpPut("activar/{pruebaCodigo}")]
        public async Task<ActionResult<Unit>> ActualizarPrueba(string pruebaCodigo)
        {
            return await Mediator.Send(new PruebaActualizar.Ejecuta { PruebaCodigo = pruebaCodigo });
        }

        [HttpPost]
        public async Task<ActionResult<Nuevo.Ejecuta>> RegistrarPrueba(Nuevo.Ejecuta parametros)
        {
            return await Mediator.Send(parametros);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> EliminarPrueba(Guid id)
        {
            return await Mediator.Send(new PruebaEliminar.Ejecuta { Id = id });
        }
    }
}
