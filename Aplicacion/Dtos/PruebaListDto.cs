using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class PruebaListDto
    {
        public string Codigo { get; set; }
        public Guid PruebaId { get; set; }
        public bool Visibilidad { get; set; }
    }
}
