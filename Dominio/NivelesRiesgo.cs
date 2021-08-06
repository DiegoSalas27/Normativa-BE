using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class NivelesRiesgo
    {
        public Guid NivelesRiesgoId { get; set; }
        public string Nombre { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal ExtMinimo { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal ExtMaximo { get; set; }
        public ICollection<ListaVerificacionNivelesRiesgo> ListaVerificacionLink { get; set; }
    }
}
