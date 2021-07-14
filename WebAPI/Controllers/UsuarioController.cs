using System.Threading.Tasks;
using Aplicacion.Seguridad;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Seguridad;

namespace WebAPI.Controllers
{
    public class UsuarioController : MiControllerBase
    {
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<UsuarioData>> Login(Login.Ejecuta parametros)
        {
            return await Mediator.Send(parametros);
        }

        [AllowAnonymous]
        [HttpPost("registrar")]
        public async Task<ActionResult<UsuarioData>> Registrar(Registrar.Ejecuta parametros)
        {
            return await Mediator.Send(parametros);
        }

        [HttpGet]
        public async Task<ActionResult<UsuarioData>> DevolverUsuario()
        {
            return await Mediator.Send(new UsuarioActual.Ejecuta());
        }

        [HttpPut] // Unauthorized
        public async Task<ActionResult<UsuarioData>> Actualizar(UsuarioActualizar.Ejecuta parametros)
        {
            return await Mediator.Send(parametros);
        }

        [Authorize(Roles = "Administrador")] // Forbidden
        [HttpDelete("{username}")] // Este metodo solo es potestad del administrador
        public async Task<ActionResult<Unit>> EliminarUsuario(string username)
        {
            return await Mediator.Send(new UsuarioEliminar.Ejecuta { Nombreusuario = username });
        }
    }
}