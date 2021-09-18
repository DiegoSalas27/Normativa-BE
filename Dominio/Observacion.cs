using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Observacion
    {
        public Guid ObservacionId { get; set; }
        public Guid EvaluacionId { get; set; }
        public string UsuarioId { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Evaluacion Evaluacion { get; set; }
        public Usuario Usuario { get; set; }
    }
}
