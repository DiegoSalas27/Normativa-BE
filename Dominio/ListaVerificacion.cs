using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ListaVerificacion
    {
        public Guid ListaVerificacionId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public ICollection<Requerimiento> RequerimientoList { get; set; }
        public ICollection<Evaluacion> EvaluacionList { get; set; }
        public ICollection<NivelesRiesgo> NivelesRiesgosList { get; set; }
    }
}
