using Aplicacion.Evidencias;
using Aplicacion.helpers;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
namespace WebAPI.Controllers
{
    public class EvidenciaController : MiControllerBase
    {
        [HttpPost("[action]/{evidenciaId}")]
        public async Task<ActionResult<Evidencia>> Upload(Guid evidenciaId)
        {
            var form = Request.Form;
            if (form.Files.Count > 0) 
            {
                var stream = form.Files[0].OpenReadStream();
                var extension = Path.GetExtension(form.Files[0].FileName);
                var fileName = Path.GetFileNameWithoutExtension(form.Files[0].FileName);
                string fileNameStore = fileName + "_" + Guid.NewGuid().ToString() + extension;
                string filePath = "upload/" + fileNameStore;
                var blobStorage = new BlobStorage();
                var evidencia = await Mediator.Send(new Editar.Ejecuta { EvidenciaId = evidenciaId, NombreAdjunto = fileName + extension, AdjuntoURL = fileNameStore });
                await blobStorage.Upload(stream, filePath);

                return evidencia;
            }
            return null;
        }

        [HttpGet("count")]
        public async Task<ActionResult<int>> ObtenerNumeroEvidenciasCount()
        {
            return await Mediator.Send(new ConsultaCantidad.Listar());
        }

        [HttpGet("[action]/{filePath}")]
        public async Task<FileResult> DownloadFile(string filePath)
        {
            var file = await new BlobStorage().GetFileByte("upload/" + filePath);
            Response.Headers.Add("Content-Disposition", "attachment; filename=" + filePath);

            return File(file, "application/octet-stream");
        }

        [HttpGet("lista")]
        public async Task<ActionResult<List<Evidencia>>> Listar([FromQuery(Name = "filter")] string filter)
        {
            return await Mediator.Send(new EvidenciaLista.Ejecuta { QueryLike = filter });
        }
    }
}
