using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class EvidenciaRequerimiento
    {
        public Guid? EvidenciaId { get; set; }
        public Evidencia Evidencia { get; set; }
        public Guid RequerimientoId { get; set; }
        public Requerimiento Requerimiento { get; set; }
        public Guid PruebaId { get; set; }
        public Prueba Prueba { get; set; }
        public Guid? AccionMitigacionId { get; set; }
        public AccionMitigacion AccionMitigacion { get; set; }
        public string Justificacion { get; set; }
        [Column(TypeName = "decimal(18, 4) null")]
        public decimal? RespuestaItem { get; set; }
        public string? Recomendacion { get; set; }
    }
}
