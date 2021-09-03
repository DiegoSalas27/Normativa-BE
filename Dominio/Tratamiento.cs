using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tratamiento
    {
        public Guid TratamientoId { get; set; }
        public Guid EvaluacionId { get; set; }
        public Guid? UsuarioId { get; set; }
        public Guid? EstadosTratamientoId { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal PorcentajeAvance { get; set; }
        public Evaluacion Evaluacion { get; set; }
        public Usuario Usuario { get; set; }
        public EstadosTratamiento EstadosTratamiento { get; set; }
        public ICollection<AccionMitigacion> AccionMitigacionLista { get; set; }
    }
}
