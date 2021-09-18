using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class ObtenerEvaluacionDetalle
    {
        public Guid EvaluacionId { get; set; }
        public string Codigo { get; set; }
        public string CodigoEspecialista { get; set; }
        public Guid EstadoEvaluacionId { get; set; }
        public string Estado { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }

        public Guid ListaVerificacionId { get; set; }
        public bool Visibilidad { get; set; } = false;
        public string CodigoConcatenadoObra { get; set; }
        public string CodigoObra { get; set; }
        public Guid ObraId { get; set; }
        public IEnumerable<NivelesRiesgo>? NivelesRiesgos { get; set; }
        public string CodigoListaVerificacion { get; set; }
        public string CodigoConcatenadoListaVerificacion { get; set; }
        public DateTime ListaVerificacionFechaCreacion { get; set; }
        public int RequerimientosCount { get; set; }
        public IEnumerable<ObservacionListaDto> ObservacionLista { get; set; }
        public IEnumerable<PruebaDetalleListaDto> PruebaList { get; set; }
        public Prueba? Prueba { get; set; } 
        public string? NombreAnalista { get; set; }
        public string? ObraNombre { get; set; }
        public string? NombreListaVerificacion { get; set; }

        public IEnumerable<Requerimiento>? RequerimientoList { get; set; }
        public IEnumerable<ObtenerListaRequerimientoResultadoDto>? RequerimientosResultado { get; set; }
        public IEnumerable<CriterioResultadoDto>? CriteriosResultado { get; set; }

        public decimal? PorcentajeCumplimientoTotal { get; set; } = 0;
        public string? NivelDeRiesgo { get; set; }
    }
}
