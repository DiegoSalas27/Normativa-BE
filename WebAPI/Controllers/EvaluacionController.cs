using Aplicacion.Dtos;
using Aplicacion.Dtos.statistics;
using Aplicacion.Dtos.statistics.Evaluacion;
using Aplicacion.Evaluaciones;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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

        [AllowAnonymous]
        [HttpGet("informe/{evaluacionCodigo}")]
        public async Task<ActionResult<MemoryStream>> GenerarInforme(string evaluacionCodigo)
        {
            var ms = await Mediator.Send(new GenerarInforme.Ejecuta { Codigo = evaluacionCodigo });

            return new FileStreamResult(ms, "application/pdf");
        }

        [HttpGet("lista")]
        public async Task<ActionResult<List<ObtenerEvaluacionesDto>>> Listar([FromQuery(Name = "filter")] string filter)
        {
            if (filter == null)
                filter = "";
            return await Mediator.Send(new Consulta.Listar { QueryLike = filter });
        }

        [HttpGet("statistics/resultados")]
        public async Task<ActionResult<StatisticsEvaluacionResult>> EstadisticaResultados([FromQuery(Name = "userId")] string userId)
        {
            return await Mediator.Send(new ConsultaResultadoStats.Listar { UsuarioId = userId });
        }

        [HttpGet("statistics/cumplimiento")]
        public async Task<ActionResult<StatisticsEvaluacionCumplimiento>> EstadisticaCumplimiento()
        {
            return await Mediator.Send(new ConsultaCumplimientoStats.Listar());
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
