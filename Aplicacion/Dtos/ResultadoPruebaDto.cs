using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class ResultadoPruebaDto
    {
        public Guid PruebaId { get; set; }
        public IEnumerable<ObtenerListaRequerimientoResultadoDto> RequerimientosResultado { get; set; }
        public IEnumerable<CriterioResultadoDto> CriteriosResultado { get; set; }
        public decimal? PorcentajeCumplimientoTotal { get; set; } = 0;
        public string? NivelDeRiesgo { get; set; }
        public IEnumerable<NivelesRiesgo> NivelesRiesgos { get; set; }
    }
}
