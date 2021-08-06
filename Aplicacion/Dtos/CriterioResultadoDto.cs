using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class CriterioResultadoDto : CriterioDto
    {
        public decimal Puntaje { get; set; } = 0;
        public string NormalizedPuntaje { get; set; }
        public decimal? PorcentajeCumplimiento { get; set; }
        public int CantidadPreguntas { get; set; } = 0;
    }
}
