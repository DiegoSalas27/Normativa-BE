using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class EstadosEvaluacion
    {
        public Guid EstadosEvaluacionId { get; set; }
        public string Nombre { get; set; }
        public ICollection<Evaluacion> EvaluacionesList { get; set; }
    }
}
