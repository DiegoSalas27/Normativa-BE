using Microsoft.AspNetCore.Identity;
using System;

namespace Dominio
{
    public class Usuario : IdentityUser
    {
        public int EspecialidadId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Foto { get; set; }
    }
}