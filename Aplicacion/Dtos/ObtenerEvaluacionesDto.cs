using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class ObtenerEvaluacionesDto
    {
        public Guid EvaluacionId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool TieneTratamiento { get; set; }
        public bool Visbilidad { get; set; }
        public IEnumerable<PruebaDetalleListaDto> PruebaList { get; set; }
    }
}
