using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class AccionMitigacion
    {
        public Guid AccionMitigacionId { get; set; }
        public Guid TratamientoId { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public Tratamiento Tratamiento { get; set; }
        public EvidenciaRequerimiento EvidenciaRequerimiento { get; set; }
        public ICollection<Comentario> ComentarioLista { get; set; }
    }
}
