using Dominio;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Seguridad
{
    public class UsuarioListar
    {
        public class ListarUsuarios : IRequest<List<UsuarioData>> 
        {
            public string Rol { get; set; }
        }
        public class Manejador : IRequestHandler<ListarUsuarios, List<UsuarioData>>
        {
            private readonly UserManager<Usuario> _userManager;
            public Manejador(UserManager<Usuario> userManager)
            {
                _userManager = userManager;
            }

            public async Task<List<UsuarioData>> Handle(ListarUsuarios request, CancellationToken cancellationToken)
            {
                var usuarios = await _userManager.GetUsersInRoleAsync(request.Rol);
                var usuarioData = new List<UsuarioData>();
                foreach (var usuario in usuarios) 
                {
                    usuarioData.Add(new UsuarioData
                    {   
                        Id = usuario.Id,
                        Codigo = "",
                        Especialidad = "",
                        Nombre = usuario.Nombres + ' ' + usuario.Apellidos,
                        Nombres = usuario.Nombres,
                        Apellidos = usuario.Apellidos,
                        Email = usuario.Email,
                        PhoneNumber = usuario.PhoneNumber,
                        FechaNacimiento = usuario.FechaNacimiento,
                        Entity = "usuario"
                    });
                }
                return usuarioData;

            }
        }
    }
}
