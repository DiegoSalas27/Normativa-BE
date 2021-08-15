using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Comentario
    {
        public Guid ComentarioId { get; set; }
        public Guid AccionMitigacionId { get; set; }
        public string UsuarioId { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public AccionMitigacion AccionMitigacion { get; set; }
        public Usuario Usuario { get; set; }
    }
}
