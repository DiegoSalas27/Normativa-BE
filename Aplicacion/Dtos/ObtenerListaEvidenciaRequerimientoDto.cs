using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class ObtenerListaEvidenciaRequerimientoDto
    {
        public Guid EvidenciaId { get; set; }
        public ObtenerEvidenciaDto Evidencia { get; set; }
        public Guid RequerimientoId { get; set; }
        public string CriterioDescripcion { get; set; }
        public Guid PruebaId { get; set; }
        public decimal PruebaPorcentajeCumplimiento { get; set; }
        public string Justificacion { get; set; }
        [Column(TypeName = "decimal(18, 4) null")]
        public decimal? RespuestaItem { get; set; }
        public string? Recomendacion { get; set; }
        public Guid? TratamientoId { get; set; }
        public string? TratamientoCodigo { get; set; }
        public bool AccionMigitagcion { get; set; }
    }
}
