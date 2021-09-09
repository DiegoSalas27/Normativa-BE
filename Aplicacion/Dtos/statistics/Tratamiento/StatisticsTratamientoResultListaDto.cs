using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos.statistics.Tratamiento
{
    public class StatisticsTratamientoResultListaDto
    {
        public List<int> PieChartSeriesLista { get; set; }
        public List<string> PieChartLabelsLista { get; set; }
    }
}
