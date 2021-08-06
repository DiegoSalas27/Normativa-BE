using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Prueba
    {
        public Guid PruebaId { get; set; }
        public Guid EvaluacionId { get; set; }
        public string Codigo { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal PorcentajeCumplimiento { get; set; }
        public bool Visbilidad { get; set; } = false;
        public DateTime FechaCreacion { get; set; }
        public Evaluacion Evaluacion { get; set; }
        public ICollection<EvidenciaRequerimiento> EvidenciaRequerimientoLink { get; set; }
    }
}
