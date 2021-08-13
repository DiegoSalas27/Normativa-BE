using Aplicacion.Dtos;
using Aplicacion.EvidenciaRequerimientos;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class EvidenciaRequerimientoController : MiControllerBase
    {
        [HttpGet("{pruebaCodigo}")]
        public async Task<ActionResult<List<ObtenerListaEvidenciaRequerimientoDto>>> ObtenerEvidenciasRequerimientos(string pruebaCodigo)
        { 
            return await Mediator.Send(new ConsultaLista.Listar { PruebaCodigo = pruebaCodigo });
        }
        [HttpPost]
        public async Task<ActionResult<ObtenerEvidenciaDto>> Crear(Nuevo.Ejecuta parametros)
        {
            return await Mediator.Send(parametros);
        }
        [HttpPut("{evidenciaId}/{pruebaId}/{requerimientoId}")]
        public async Task<ActionResult<Unit>> ActualizarEvidenciaRequerimiento(
            Guid evidenciaId, 
            Guid pruebaId, 
            Guid requerimientoId,
            EvidenciaReqActualizar.Ejecuta parametros)
        {
            parametros.EvidenciaId = evidenciaId;
            parametros.PruebaId = pruebaId;
            parametros.RequerimientoId = requerimientoId;
            return await Mediator.Send(parametros);
        }
    }
}
