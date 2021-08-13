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

namespace Aplicacion.PlanesTratamiento
{
    public class ObtenerTratamiento
    {
        public class Ejecuta : IRequest<ObtenerTratamientoDto>
        {
            public string Codigo { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, ObtenerTratamientoDto>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<ObtenerTratamientoDto> Handle(Ejecuta request, CancellationToken cancellationToken)
            {

                var tratamiento = await _context.Tratamiento.Where(x =>
                x.Codigo == request.Codigo)
                    .Select(tr => new ObtenerTratamientoDto
                    {
                        TratamientoId = tr.TratamientoId,
                        EvaluacionId = tr.EvaluacionId,
                        Codigo = tr.Codigo,
                        FechaInicio = tr.FechaInicio,
                        FechaFin = tr.FechaFin,
                        Nombre = tr.Nombre,
                        UsuarioId = tr.UsuarioId,
                        PorcentajeAvance = tr.PorcentajeAvance,
                        CodigoEvaluacion = tr.Evaluacion.Codigo + "-" + tr.Evaluacion.Nombre,
                        ListaVerificacionCodigo = tr.Evaluacion.ListaVerificacion.Codigo,
                        Pruebas = tr.Evaluacion.PruebaList.Select(pr => new PruebaListDto
                        { 
                            Codigo = pr.Codigo,
                            PruebaId = pr.PruebaId,
                            Visibilidad = pr.Visbilidad
                        })
                    })
                    .FirstOrDefaultAsync();

                return tratamiento;
            }
        }
    }
}
