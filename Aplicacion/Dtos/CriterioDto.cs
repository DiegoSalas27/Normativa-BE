using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class CriterioDto
    {
        public Guid CriterioId { get; set; }
        public string Descripcion { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Peso { get; set; }
    }
}
