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
        public Guid? EstadosEvaluacionId { get; set; }
        public string UsuarioId { get; set; }
        public string Codigo { get; set; }
        public string CodigoEspecialista { get; set; }
        public string Nombre { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal PorcentajeFinal { get; set; }
        public bool Visbilidad { get; set; } = false;
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public Obra Obra { get; set; }
        public Tratamiento Tratamiento { get; set; }
        public ListaVerificacion ListaVerificacion { get; set; }
        public Usuario Usuario { get; set; }
        public EstadosEvaluacion EstadosEvaluacion { get; set; }
        public ICollection<Prueba> PruebaList { get; set; }
        public ICollection<Observacion> ObservacionLista { get; set; }

    }
}
