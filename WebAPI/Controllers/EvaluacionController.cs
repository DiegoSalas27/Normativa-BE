using Aplicacion.Dtos;
using Aplicacion.Evaluaciones;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class EvaluacionController : MiControllerBase
    {
        [HttpGet("count")]
        public async Task<ActionResult<int>> ObtenerNumeroEvaluacionesCount() 
        {
            return await Mediator.Send(new ConsultaCantidad.Listar());
        }

        [HttpGet("{evaluacionCodigo}")]
        public async Task<ActionResult<ObtenerEvaluacionDetalle>> ObtenerEvaluacion(string evaluacionCodigo)
        {
            return await Mediator.Send(new ObtenerEvaluacion.Ejecuta { Codigo = evaluacionCodigo });
        }

        [HttpPut("{evaluacionId}")]
        public async Task<ActionResult<Unit>> ActualizarEvaluacion(Guid evaluacionId, EvaluacionActualizar.Ejecuta parametros)
        {
            parametros.EvaluacionId = evaluacionId;
            return await Mediator.Send(parametros);
        }

        [HttpPut("activar/{evaluacionId}")]
        public async Task<ActionResult<Unit>> ActivarEvaluacion(Guid evaluacionId)
        {
            return await Mediator.Send(new EvaluacionActivar.Ejecuta { EvaluacionId = evaluacionId });
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> RegistrarEvaluacion(Nuevo.Ejecuta parametros)
        {
            return await Mediator.Send(parametros);
        }
    }
}
