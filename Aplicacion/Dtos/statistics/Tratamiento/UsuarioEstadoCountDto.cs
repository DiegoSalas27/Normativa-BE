using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos.statistics.Tratamiento
{
    public class UsuarioEstadoCountDto
    {
        public string UsuarioNombre { get; set; }
        public List<StackedBarSeriesUsuario> StackedBarSeriesUsuario { get; set; }
    }

    public class StackedBarSeriesUsuario
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
