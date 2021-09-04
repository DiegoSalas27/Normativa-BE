using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos.statistics.Tratamiento
{
    public class StatisticsTratamientoResultAnalistasDto
    {
        public List<EstadoUsuariosDto> StackedBarSeries { get; set; }
        public List<string> XAxisCategoriesStacked { get; set; }
    }

    public class StackedBarSeries
    { 
        public string Name { get; set; }
        public List<int> Data { get; set; }
    }
}
