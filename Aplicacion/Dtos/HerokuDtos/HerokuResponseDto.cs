using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class HerokuResponseDto
    {
        public IEnumerable<ObjResultDto> objResult { get; set; }
        public string porcentajeCumplimientoTotal { get; set; }
    }

    public class ObjResultDto
    { 
        public ObtenerEvidenciaRequerimientoDto evidenciaPruebaLink { get; set; }
        public CriterioResultadoDto criterioResultado { get; set; }
        public Guid requerimientoId { get; set; }
        public string descripcion { get; set; }
        public CriterioDto? criterio { get; set; }
        public IEnumerable<NivelesRiesgo> nivelesRiesgos { get; set; }
    }
}
