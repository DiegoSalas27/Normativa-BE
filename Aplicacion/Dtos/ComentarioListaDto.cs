using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class ComentarioListaDto
    {
        public string UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string UsuarioRol { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Descripcion { get; set; }
    }
}
