using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Comentario
    {
        public Guid ComentarioId { get; set; }
        public Guid TratamientoId { get; set; }
        public string Descripcion { get; set; }
        public Tratamiento Tratamiento { get; set; }
    }
}
