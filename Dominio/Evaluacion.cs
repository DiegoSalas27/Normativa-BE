using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Evaluacion
    {
        public Guid EvaluacionId { get; set; }
        public Guid ObraId { get; set; }
        public Guid ListaVerificacionId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal PorcentajeFinal { get; set; }
        public string Estado { get; set; }
        public bool Visbilidad { get; set; } = false;
        public DateTime FechaCreacion { get; set; }
        public Obra Obra { get; set; }
        public Tratamiento Tratamiento { get; set; }
        public ListaVerificacion ListaVerificacion { get; set; }
        public ICollection<Prueba> PruebaList { get; set; }

    }
}
