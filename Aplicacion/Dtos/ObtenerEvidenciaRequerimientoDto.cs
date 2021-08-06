using Castle.MicroKernel.SubSystems.Conversion;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class ObtenerEvidenciaRequerimientoDto
    {
        public string Justificacion { get; set; }
        [Column(TypeName = "decimal(18, 4) null")]
        public decimal? RespuestaItem { get; set; }
        public string? Recomendacion { get; set; }

    }
}
