using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class ObtenerListaRequerimientoResultadoDto : ObtenerListaRequerimientoDto
    {
        public ObtenerEvidenciaRequerimientoDto EvidenciaPruebaLink { get; set; }
        public CriterioResultadoDto CriterioResultado { get; set; }
    }
}
