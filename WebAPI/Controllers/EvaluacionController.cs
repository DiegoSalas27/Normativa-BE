using Aplicacion.Dtos;
using Aplicacion.Dtos.statistics;
using Aplicacion.Dtos.statistics.Evaluacion;
using Aplicacion.Evaluaciones;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Persistencia.DapperConexion.Paginacion;
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
        public async Task<ActionResult<int>> ObtenerNumeroEvaluacionesCount([FromQuery(Name = "visible")] bool? visible) 
        {
            return await Mediator.Send(new ConsultaCantidad.Listar { Visible = visible });
        }

        [HttpGet("ultimoCodigo")]
        public async Task<ActionResult<object>> ObtenerEvaluacionesLastCode()
        {
            return await Mediator.Send(new ConsultaUltimoCodigo.Listar());
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

            byte[] bytesStream = ms.ToArray();

            //return new FileStreamResult(ms, "application/pdf");

            Response.Headers.Add("Content-Disposition", "attachment; filename=" + "Informe Evaluacion");

            return File(bytesStream, "application/octet-stream");
        }

        [HttpGet("lista")]
        public async Task<ActionResult<PaginacionModel>> Listar
              ([FromQuery(Name = "page")] int page, [FromQuery(Name = "quantity")] int quantity)
        {

            //return await Mediator.Send(new Consulta.Listar { QueryLike = filter });  
            return await Mediator.Send(new Consulta.Listar { NumeroPagina = page, CantidadElementos = quantity });
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

         [HttpGet("statistics/cumplimientoprueba")]
        public async Task<ActionResult<StatisticsEvaluacionCumplimientoPrueba>> EstadisticaCumplimientoPrueba()
        {
            return await Mediator.Send(new ConsultaCumplimientoPruebaStats.Listar());
        }

        [HttpGet("statistics/cumplimientopruebalista")]
        public async Task<ActionResult<StatisticsEvaluacionCumplimientoPruebaLista>> EstadisticaCumplimientoPruebaLista()
        {
            return await Mediator.Send(new ConsultaCumplimientoPruebaStatsLista.Listar());
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

        [HttpDelete("{id}")] 
        public async Task<ActionResult<Unit>> EliminarEvaluacion(Guid id)
        {
            return await Mediator.Send(new EvaluacionEliminar.Ejecuta { Id = id });
        }
                
    }
}
