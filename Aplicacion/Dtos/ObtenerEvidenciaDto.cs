using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class ObtenerEvidenciaDto
    {
        public Guid? EvidenciaId { get; set; } = null;
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Adjunto { get; set; }
        public string AdjuntoURL { get; set; }
    }
}
