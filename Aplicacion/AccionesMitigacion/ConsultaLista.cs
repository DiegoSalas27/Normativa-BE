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
    public class ConsultaLista
    {
        public class Listar : IRequest<List<AccionMitigacionDto>>
        {
            public Guid TratamientoId { get; set; }
            public string CodigoPrueba { get; set; }
        }

        public class Manejador : IRequestHandler<Listar, List<AccionMitigacionDto>>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<List<AccionMitigacionDto>> Handle(Listar request, CancellationToken cancellationToken)
            {
                var accionesMitigacion = await _context.AccionMitigacion
                    .Where(acm => acm.TratamientoId == request.TratamientoId && acm.EvidenciaRequerimiento.Prueba.Codigo == request.CodigoPrueba)
                    .ToListAsync();

                var accionesMitigacionDto = new List<AccionMitigacionDto>();

                foreach (var accionMitigacion in accionesMitigacion)
                {
                    var accioneMitigacionDto = new AccionMitigacionDto
                    { 
                        AccionMitigacionId = accionMitigacion.AccionMitigacionId,
                        Descripcion = accionMitigacion.Descripcion,
                        ComentarioLista = accionMitigacion.ComentarioLista,
                        Estado = accionMitigacion.Estado,
                        EvidenciaRequerimiento = accionMitigacion.EvidenciaRequerimiento,
                        FechaFin = accionMitigacion.FechaFin,
                        FechaInicio = accionMitigacion.FechaInicio,
                        Tratamiento = accionMitigacion.Tratamiento,
                        TratamientoId = accionMitigacion.TratamientoId,
                    };
                    
                    var hasCmentario = await _context.Comentario.Where(com => com.AccionMitigacionId == accionMitigacion.AccionMitigacionId).AnyAsync();

                    if (hasCmentario)
                    {
                        accioneMitigacionDto.TieneMensaje = true;
                    }

                    accionesMitigacionDto.Add(accioneMitigacionDto);
                }

                return accionesMitigacionDto;
            }
        }
    }
}
