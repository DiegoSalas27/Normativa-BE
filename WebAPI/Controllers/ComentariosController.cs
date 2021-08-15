using Aplicacion.Comentarios;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class ComentariosController : MiControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<Unit>> RegistrarComentario(Nuevo.Ejecuta parametros)
        {
            return await Mediator.Send(parametros);
        }
    }
}
