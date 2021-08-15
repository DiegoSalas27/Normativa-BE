using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class ObtenerEvidenciaRequerimientoAccionMitigacionDto
    {
        public string Justificacion { get; set; }
        public string? Recomendacion { get; set; }
        public string RequerimientoDescripcion { get; set; }
        public string CriterioDescripcion { get; set; }
        public decimal? RespuestaItem { get; set; }
        public bool EstadoAccionMitigacion { get; set; }
        public ObtenerEvidenciaDto Evidencia { get; set; }
        public IEnumerable<ComentarioListaDto> ComentarioLista { get; set; }
    }
}
