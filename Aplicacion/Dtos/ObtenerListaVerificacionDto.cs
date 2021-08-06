using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class ObtenerListaVerificacionDto
    {
        public Guid ListaVerificacionId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public IEnumerable<ObtenerListaRequerimientoDto> Requerimientos { get; set; }
        public int RequerimientosCount { get; set; }
    }
}
