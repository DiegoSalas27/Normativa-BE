using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos.statistics
{
    public class NivelesRiesgosDto
    {
        [Column(TypeName = "decimal(18, 4)")]
        public decimal ExtMinimo { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal ExtMaximo { get; set; }
        public string Nombre { get; set; }
    }
}
