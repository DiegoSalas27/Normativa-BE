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

namespace Aplicacion.EvidenciaRequerimientos
{
    public class ConsultaLista
    {
        public class Listar : IRequest<List<ObtenerListaEvidenciaRequerimientoDto>> 
        { 
            public string PruebaCodigo { get; set; }
            public List<Guid>? Ids { get; set; }
        }

        public class Manejador : IRequestHandler<Listar, List<ObtenerListaEvidenciaRequerimientoDto>>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<List<ObtenerListaEvidenciaRequerimientoDto>> Handle(Listar request, CancellationToken cancellationToken)
            {
                var evidenciasRequerimiento = await _context.EvidenciaRequerimiento
                    .Where(evR => evR.Prueba.Codigo == request.PruebaCodigo)
                    .Select(evR => new ObtenerListaEvidenciaRequerimientoDto
                    {
                        EvidenciaId = evR.EvidenciaId,
                        Justificacion = evR.Justificacion,
                        PruebaId = evR.PruebaId,
                        PruebaPorcentajeCumplimiento = evR.Prueba.PorcentajeCumplimiento,
                        Recomendacion = evR.Recomendacion,
                        RequerimientoId = evR.RequerimientoId,
                        CriterioDescripcion = evR.Requerimiento.Criterio.Descripcion,
                        RespuestaItem = evR.RespuestaItem,
                        Evidencia = new ObtenerEvidenciaDto 
                        { 
                            Adjunto = evR.Evidencia.Adjunto,
                            EvidenciaId = evR.Evidencia.EvidenciaId,
                            Nombre = evR.Evidencia.Nombre
                        },
                        TratamientoId = evR.Prueba.Evaluacion.Tratamiento.TratamientoId,
                        TratamientoCodigo = evR.Prueba.Evaluacion.Tratamiento.Codigo,
                        AccionMigitagcion = evR.AccionMitigacionId != null ? true : false,
                    })
                    .ToListAsync();

                if (request.Ids != null)
                {
                    evidenciasRequerimiento = evidenciasRequerimiento.Where(evR => request.Ids.Contains(evR.RequerimientoId)).ToList();
                }

                return evidenciasRequerimiento;
            }
        }
    }
}
