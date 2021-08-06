using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Obra
    {
        public Guid ObraId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public ICollection<Evaluacion> EvaluacionList { get; set; }
    }
}
