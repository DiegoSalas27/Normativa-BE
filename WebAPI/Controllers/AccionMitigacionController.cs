using Aplicacion.AccionesMitigacion;
using Aplicacion.Dtos;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class AccionMitigacionController : MiControllerBase
    {
        [HttpGet("{tratamientoId}/{codigoPrueba}")]
        public async Task<ActionResult<List<AccionMitigacionDto>>> ObtenerAccionesMitigacion(Guid tratamientoId, string codigoPrueba)
        {
            return await Mediator.Send(new ConsultaLista.Listar { TratamientoId = tratamientoId, CodigoPrueba = codigoPrueba });
        }

        [HttpPut("{accionMitigacionId}")]
        public async Task<ActionResult<Unit>> ActualizarAccionMitigacion(Guid accionMitigacionId, AccionMitigacionActualizar.Ejecuta parametros)
        {
            parametros.AccionMitigacionId = accionMitigacionId;
            return await Mediator.Send(parametros);
        }

        [HttpPut("estado/{accionMitigacionId}")]
        public async Task<ActionResult<Unit>> ActualizarEstado(Guid accionMitigacionId, AccionMitigacionActualizarEstado.Ejecuta parametros)
        {
            parametros.AccionMitigacionId = accionMitigacionId;
            return await Mediator.Send(parametros);
        }

        [HttpDelete("{accionMitigacionId}")]
        public async Task<ActionResult<Unit>> Eliminar(Guid accionMitigacionId)
        { 
            return await Mediator.Send(new EliminarAccion.Ejecuta { Id = accionMitigacionId });
        }
    }
}
