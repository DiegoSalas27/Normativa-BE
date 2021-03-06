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
        public Guid CriterioId { get; set; }
        public Guid ListaVerificacionId { get; set; }
        public CriterioDto Criterio { get; set; }
        public IEnumerable<NivelesRiesgo> NivelesRiesgos { get; set; }
        public string Recomendacion { get; set; }
        //public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
