using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public int RolId { get; set; }
        public int EspecialidadId { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string Telefono { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Foto { get; set; }

        public Roles Rol { get; set; }
        public Especialidad Especialidad { get; set; }

    }
}
