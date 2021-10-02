using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class DeleteBody
    {
        public IList<Criterio> Criterios { get; set; }
        public IList<Requerimiento> Requerimientos { get; set; }
        public IList<NivelesRiesgo> NivelesRiesgo { get; set; }
        public ObtenerListaVerificacionDto ListaVerificacion { get; set; }
    }
}
