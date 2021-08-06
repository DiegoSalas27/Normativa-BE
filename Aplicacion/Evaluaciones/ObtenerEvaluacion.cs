using Aplicacion.Dtos;
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Evaluaciones
{
    public class ObtenerEvaluacion
    {
        public class Ejecuta : IRequest<ObtenerEvaluacionDetalle>
        {
            public string Codigo { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, ObtenerEvaluacionDetalle>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<ObtenerEvaluacionDetalle> Handle(Ejecuta request, CancellationToken cancellationToken)
            {

                var evaluacion = await _context.Evaluacion.Where(x =>
                x.Codigo == request.Codigo)
                    .Select(ev => new ObtenerEvaluacionDetalle
                    {
                        EvaluacionId = ev.EvaluacionId,
                        Codigo = ev.Codigo,
                        Estado = ev.Estado,
                        Visibilidad = ev.Visbilidad,
                        Nombre = ev.Nombre,
                        FechaCreacion = ev.FechaCreacion,
                        ListaVerificacionId = ev.ListaVerificacion.ListaVerificacionId,
                        CodigoListaVerificacion = ev.ListaVerificacion.Codigo,
                        CodigoConcatenadoListaVerificacion = ev.ListaVerificacion.Codigo + '-' + ev.ListaVerificacion.Nombre,
                        ListaVerificacionFechaCreacion = ev.ListaVerificacion.FechaCreacion,
                        RequerimientosCount = ev.ListaVerificacion.RequerimientoList.Count,
                        CodigoConcatenadoObra = ev.Obra.Codigo + '-' + ev.Obra.Nombre,
                        CodigoObra = ev.Obra.Codigo,
                        ObraId = ev.ObraId,
                        PruebaList = ev.PruebaList.Select(pl => new PruebaDetalleListaDto
                        {
                            Codigo = pl.Codigo,
                            FechaCreacion = pl.FechaCreacion,
                            PruebaId = pl.PruebaId,
                            Visibilidad = pl.Visbilidad
                        })
                    })
                    .FirstOrDefaultAsync();

                return evaluacion;
            }
        }
    }
}
