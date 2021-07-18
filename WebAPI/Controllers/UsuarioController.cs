using System.Collections.Generic;
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

        [Authorize(Roles = "Administrador")] 
        [HttpGet("{id}")] 
        public async Task<ActionResult<UsuarioData>> ObtenerUsuarioPorNombre(string id)
        {
            return await Mediator.Send(new ObtenerUsuario.Ejecuta { userId = id });
        }

        [Authorize(Roles = "Administrador")] // Unauthorized
        [HttpPut]
        public async Task<ActionResult<UsuarioData>> Actualizar(UsuarioActualizar.Ejecuta parametros)
        {
            return await Mediator.Send(parametros);
        }

        [Authorize(Roles = "Administrador")] // Forbidden
        [HttpDelete("{id}")] // Este metodo solo es potestad del administrador
        public async Task<ActionResult<Unit>> EliminarUsuario(string id)
        {
            return await Mediator.Send(new UsuarioEliminar.Ejecuta { Id = id });
        }

        [Authorize(Roles = "Administrador")]
        [HttpGet("listar/{rol}")]
        public async Task<ActionResult<List<UsuarioData>>> ObtenerUsuariosPorRol(string rol)
        {
            return await Mediator.Send(new UsuarioListar.ListarUsuarios { Rol = rol });
        }
    }
}