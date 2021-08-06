using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Criterio
    {
        public Guid CriterioId { get; set; }
        public string Descripcion { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Peso { get; set; }
        public ICollection<Requerimiento> RequerimientoList { get; set; }
    }
}
