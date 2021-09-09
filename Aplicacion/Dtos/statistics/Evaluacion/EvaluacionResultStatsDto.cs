using Aplicacion.Dtos.statistics;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos.statistics
{
    public class EvaluacionResultStatsDto
    {
        public Guid EvaluacionId { get; set; }
        public Guid ListaVerificacionId { get; set; }
        public string UsuarioId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public bool Visbilidad { get; set; } = false;
        public DateTime FechaCreacion { get; set; }
        public Prueba Prueba { get; set; }


    }
}
