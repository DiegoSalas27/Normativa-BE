using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class ObtenerListaRequerimientoDto
    {
        public Guid RequerimientoId { get; set; }
        public string Descripcion { get; set; }
        public CriterioDto Criterio { get; set; }
        public IEnumerable<NivelesRiesgo> NivelesRiesgos { get; set; }
        
    }
}
