using Aplicacion.Evidencias;
using Aplicacion.helpers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
namespace WebAPI.Controllers
{
    public class EvidenciaController : MiControllerBase
    {
        [HttpPost("[action]/{evidenciaId}")]
        public async Task<ActionResult<Unit>> Upload(Guid evidenciaId)
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
                await blobStorage.Upload(stream, filePath);

                return await Mediator.Send(new Editar.Ejecuta { EvidenciaId = evidenciaId, NombreAdjunto = fileNameStore });
            }
            return null;
        }

        [HttpGet("[action]/{filePath}")]
        public async Task<FileResult> DownloadFile(string filePath)
        {
            var file = await new BlobStorage().GetFileByte("upload/" + filePath);
            Response.Headers.Add("Content-Disposition", "attachment; filename=" + filePath);

            return File(file, "application/octet-stream");
        }
    }
}
