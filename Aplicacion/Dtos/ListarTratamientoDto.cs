using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class ListarTratamientoDto
    {        
        public Guid TratamientoId { get; set; }
        public Guid EvaluacionId { get; set; }
        public string Codigo { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Nombre { get; set; }
        public string UsuarioId { get; set;  }  
        public string Responsable { get; set; }
        public string Evaluacion { get; set; }
    }
}
