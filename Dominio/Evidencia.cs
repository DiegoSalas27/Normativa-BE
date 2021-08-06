using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Evidencia
    {
        public Guid EvidenciaId { get; set; }
        public string Nombre { get; set; }
        public string Adjunto { get; set; }
        public ICollection<EvidenciaRequerimiento> RequerimientoEvaluacionLink { get; set; }

    }
}
