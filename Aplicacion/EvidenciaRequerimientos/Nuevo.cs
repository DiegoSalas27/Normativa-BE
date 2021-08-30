using Aplicacion.Dtos;
using Aplicacion.ManejadorError;
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.EvidenciaRequerimientos
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ObtenerEvidenciaDto>
        { 
            public Guid? EvidenciaId { get; set; }
            public Guid RequerimientoId { get; set; }
            public string PruebaCodigo { get; set; }
            public string? EvidenciaNombre { get; set; }
            public string EvidenciaCodigo { get; set; }
            public string Justificacion { get; set; }
            public decimal? RespuestaItem { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, ObtenerEvidenciaDto>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                this._context = context;
            }
            public async Task<ObtenerEvidenciaDto> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                Guid _evidenciaId = Guid.NewGuid();

                var evidenciaDto = new ObtenerEvidenciaDto();

                if (request.EvidenciaId != null)
                {
                    _evidenciaId = (Guid)request.EvidenciaId;
                }

                if (request.EvidenciaId == null && request.EvidenciaNombre != "")
                {
                    evidenciaDto.EvidenciaId = _evidenciaId;

                    var evidencia = new Evidencia
                    {
                        Adjunto = "",
                        EvidenciaId = _evidenciaId,
                        Nombre = request.EvidenciaNombre,
                        Codigo = request.EvidenciaCodigo,
                    };

                    _context.Evidencia.Add(evidencia);
                }
                //else
                //{
                //    var evidenciaExits = await _context.Evidencia.FindAsync(request.EvidenciaId);

                //    if (evidenciaExits != null)
                //    {
                //        evidenciaDto.EvidenciaId = evidenciaExits.EvidenciaId;
                //        evidenciaExits.Nombre = request.EvidenciaNombre;
                //        //evidencia.Adjunto = request.EvidenciaAdjunto;
                //    }
                //}


                var Prueba = await _context.Prueba.Where(pr => pr.Codigo == request.PruebaCodigo).FirstOrDefaultAsync();

                var evidenciaRequerimientoExists = await _context.EvidenciaRequerimiento
                    .Where(evR => evR.EvidenciaId == _evidenciaId && evR.RequerimientoId == request.RequerimientoId
                    && evR.PruebaId == Prueba.PruebaId)
                    .FirstOrDefaultAsync();

                var evidenciaRequerimientoChangedEvidenciaExists = await _context.EvidenciaRequerimiento
                    .Where(evR => evR.EvidenciaId != _evidenciaId && evR.RequerimientoId == request.RequerimientoId
                    && evR.PruebaId == Prueba.PruebaId)
                    .FirstOrDefaultAsync();

                if (evidenciaRequerimientoExists == null)
                {
                    var evidenciaRequerimiento = new EvidenciaRequerimiento
                    {
                        EvidenciaId = request.EvidenciaId ?? _evidenciaId,
                        RequerimientoId = request.RequerimientoId,
                        PruebaId = Prueba.PruebaId,
                        Justificacion = request.Justificacion,
                        RespuestaItem = request.RespuestaItem,
                    };

                    _context.EvidenciaRequerimiento.Add(evidenciaRequerimiento);
                }
                else
                {
                    evidenciaRequerimientoExists.Justificacion = request.Justificacion;
                    evidenciaRequerimientoExists.RespuestaItem = request.RespuestaItem;
                }

                if (evidenciaRequerimientoChangedEvidenciaExists != null)
                {
                    _context.Remove(evidenciaRequerimientoChangedEvidenciaExists);
                }

                var valor = await _context.SaveChangesAsync();
                if (valor >= 0)
                {
                    return evidenciaDto;
                }

                throw new Exception("No se pudo insertar la evidencia requerimiento");
            }
        }
    }
}
