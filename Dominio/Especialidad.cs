using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Especialidad
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Empleado Empleado { get; set; }
    }
}
