using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos.statistics.ListaVerificacion
{
   public class StatisticsListaVerificacion
    {
        public List<decimal> StackedBarSeriesListaVerificacion { get; set; }
        public List<DateTime> XAxisListaVerificacionStacked { get; set; }
    }
}
