using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class PruebaDetalleListaDto
    {
        public Guid PruebaId { get; set; }
        public string Codigo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Visibilidad { get; set; }

        public decimal? PorcentajeCumplimiento { get; set; }
        public string? NivelDeRiesgo { get; set; }
    }
}
