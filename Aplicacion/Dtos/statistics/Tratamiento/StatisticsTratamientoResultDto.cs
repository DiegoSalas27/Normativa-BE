using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos.statistics.Tratamiento
{
    public class StatisticsTratamientoResultDto
    {
        public List<int> PieChartSeries { get; set; }
        public List<string> PieChartLabels { get; set; }
    }
}
