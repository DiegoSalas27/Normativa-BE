using Aplicacion.AccionesMitigacion;
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
        public async Task<ActionResult<List<AccionMitigacion>>> ObtenerAccionesMitigacion(Guid tratamientoId, string codigoPrueba)
        {
            return await Mediator.Send(new ConsultaLista.Listar { TratamientoId = tratamientoId, CodigoPrueba = codigoPrueba });
        }

        [HttpPut("{accionMitigacionId}")]
        public async Task<ActionResult<Unit>> ActualizarAccionMitigacion(Guid accionMitigacionId, AccionMitigacionActualizar.Ejecuta parametros)
        {
            parametros.AccionMitigacionId = accionMitigacionId;
            return await Mediator.Send(parametros);
        }
    }
}
