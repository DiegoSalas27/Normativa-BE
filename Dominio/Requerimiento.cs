using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Requerimiento
    {
        public Guid RequerimientoId { get; set; }
        public Guid ListaVerificacionId { get; set; }
        public Guid CriterioId { get; set; }
        public string Descripcion { get; set; }
        public ListaVerificacion VerificacionLista { get; set; }
        public Criterio Criterio { get; set; }
        public ICollection<EvidenciaRequerimiento> EvidenciaPruebaLink { get; set; }
    }
}
