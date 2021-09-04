using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos.statistics.Tratamiento
{
    public class TratamientoStatisticDto
    {
        public Guid TratamientoId { get; set; }

        public string UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public EstadosTratamiento EstadosTratamiento { get; set; }
        public Usuario Usuario { get; set; }
    }
}
