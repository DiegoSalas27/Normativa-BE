using System;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.AspNetCore.Identity;

namespace Persistencia
{
    public class DataPrueba
    {
        public static async Task InsertarData(NormativaContext context, UserManager<Usuario> usuarioManager)
        {
            if (!usuarioManager.Users.Any())
            {
                var usuario = new Usuario
                {
                    Nombres = "Diego",
                    Apellidos = "Salas Noain",
                    FechaNacimiento = new DateTime(1991, 08, 08),
                    UserName = "diegosalas",
                    Email = "diegosalas27@gmail.com"
                };
                await usuarioManager.CreateAsync(usuario, "Password123$");
            }
        }
    }
}