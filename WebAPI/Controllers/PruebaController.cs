using Aplicacion.Dtos;
using Aplicacion.EvidenciaRequerimientos;
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

        [HttpGet("ultimoCodigo")]
        public async Task<ActionResult<object>> ObtenerPruebasLastCode()
        {
            return await Mediator.Send(new ConsultaUltimoCodigo.Listar());
        }

        [HttpGet("{pruebaCodigo}")]
        public async Task<ActionResult<ResultadoPruebaDto>> ObtenerResultadosDePrueba(string pruebaCodigo) 
        {
            return await Mediator.Send(new ObtenerResultadosPrueba.Listar { PruebaCodigo = pruebaCodigo });
        }

        [HttpGet("{pruebaCodigo}/{porcentajeDeseado}")]
        public async Task<ActionResult<List<ObtenerListaEvidenciaRequerimientoDto>>> ObtenerResultadosDeOptimizacion(string pruebaCodigo, decimal porcentajeDeseado)
        {
            var response = await Mediator.Send(new ObtenerResultadosPrueba.Listar { PruebaCodigo = pruebaCodigo });
            var ids = await Mediator.Send(new OptimizationRequest.Listar { PorcentajeDeseado = porcentajeDeseado, Response = response });
            return await Mediator.Send(new ConsultaLista.Listar { PruebaCodigo = pruebaCodigo, Ids = ids });
        }

        [HttpPut("activar/{pruebaCodigo}")]
        public async Task<ActionResult<Unit>> ActualizarPrueba(string pruebaCodigo)
        {
            return await Mediator.Send(new PruebaActualizar.Ejecuta { PruebaCodigo = pruebaCodigo });
        }

        [HttpPost]
        public async Task<ActionResult<Aplicacion.Pruebas.Nuevo.Ejecuta>> RegistrarPrueba(Aplicacion.Pruebas.Nuevo.Ejecuta parametros)
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
