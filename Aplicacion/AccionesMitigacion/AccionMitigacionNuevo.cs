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

namespace Aplicacion.AccionesMitigacion
{
    public class AccionMitigacionNuevo
    {

        public class Listar : IRequest<ObtenerObjetoAccionesMitigacionVersion2Dto>
        {
            public string PruebaCodigo { get; set; }
            public ObtenerObjetoAccionesMitigacionDto Ids { get; set; }
        }

        public class Manejador : IRequestHandler<Listar, ObtenerObjetoAccionesMitigacionVersion2Dto>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<ObtenerObjetoAccionesMitigacionVersion2Dto> Handle(Listar request, CancellationToken cancellationToken)
            {
                var evidenciasRequerimiento = await _context.EvidenciaRequerimiento
                    .Where(evR => evR.Prueba.Codigo == request.PruebaCodigo)
                    .Select(evR => new ObtenerListaEvidenciaRequerimientoDto
                    {
                        EvidenciaId = evR.EvidenciaId ?? null,
                        Justificacion = evR.Justificacion,
                        PruebaId = evR.PruebaId,
                        PruebaPorcentajeCumplimiento = evR.Prueba.PorcentajeCumplimiento,
                        Recomendacion = evR.Requerimiento.Recomendacion,
                        RequerimientoId = evR.RequerimientoId,
                        CriterioDescripcion = evR.Requerimiento.Criterio.Descripcion,
                        RespuestaItem = evR.RespuestaItem,
                        Evidencia = new ObtenerEvidenciaDto
                        {
                            Adjunto = evR.Evidencia.Adjunto,
                            AdjuntoURL = evR.Evidencia.AdjuntoURL,
                            EvidenciaId = evR.Evidencia.EvidenciaId,
                            Nombre = evR.Evidencia.Nombre,
                            Codigo = evR.Evidencia.Codigo
                        },
                        TratamientoId = evR.Prueba.Evaluacion.Tratamiento != null ? evR.Prueba.Evaluacion.Tratamiento.TratamientoId : null,
                        TratamientoCodigo = evR.Prueba.Evaluacion.Tratamiento != null ? evR.Prueba.Evaluacion.Tratamiento.Codigo : null,
                        AccionMigitagcion = evR.AccionMitigacionId != null ? true : false,
                    })
                    .ToListAsync();

                if (request.Ids.requeid != null)
                {
                    evidenciasRequerimiento = evidenciasRequerimiento.Where(evR => request.Ids.requeid.Contains(evR.RequerimientoId)).ToList();
                }


                var cosito = new ObtenerObjetoAccionesMitigacionVersion2Dto { reque2 = evidenciasRequerimiento, limit = request.Ids.limit };
                return cosito;
            }
        }
    }
}
