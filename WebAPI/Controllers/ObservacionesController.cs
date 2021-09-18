using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.Observaciones;

namespace WebAPI.Controllers
{
    public class ObservacionesController : MiControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<Unit>> RegistrarObservacion(Nuevo.Ejecuta parametros)
        {
            return await Mediator.Send(parametros);
        }
    }
}
