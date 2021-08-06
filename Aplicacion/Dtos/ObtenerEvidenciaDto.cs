using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class ObtenerEvidenciaDto
    {
        public Guid EvidenciaId { get; set; }
        public string Nombre { get; set; }
        public string Adjunto { get; set; }
    }
}
