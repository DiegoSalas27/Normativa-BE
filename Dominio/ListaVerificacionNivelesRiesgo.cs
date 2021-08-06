using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ListaVerificacionNivelesRiesgo
    {
        public Guid ListaVerificacionId { get; set; }
        public Guid NivelesRiesgoId { get; set; }
        public ListaVerificacion VerificacionLista { get; set; }
        public NivelesRiesgo NivelesRiesgo { get; set; }
    }
}
