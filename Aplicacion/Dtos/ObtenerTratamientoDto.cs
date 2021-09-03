using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class ObtenerTratamientoDto
    {
        public Guid TratamientoId { get; set; }
        public Guid EstadosTratamientoId { get; set; }
        public Guid EvaluacionId { get; set;}
        public string Codigo { get; set;}
        public DateTime? FechaInicio { get; set;}
        public DateTime? FechaFin { get; set;}
        public string Nombre { get; set;}
        public Guid? UsuarioId { get; set;}
        public decimal PorcentajeAvance { get; set;}
        public string CodigoEvaluacion { get; set;}
        public string ListaVerificacionCodigo { get; set; }
        public IEnumerable<PruebaListDto> Pruebas { get; set; }

    }
}
