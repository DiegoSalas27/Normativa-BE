using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos.statistics
{
    public class StatisticsEvaluacionResult
    {
       public List<NivelRiesgoEvaDto> Series { get; set; }
       public IEnumerable<string> XAxisCategories { get; set; }
    }
}
