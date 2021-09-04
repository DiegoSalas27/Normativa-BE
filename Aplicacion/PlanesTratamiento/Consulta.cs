using Aplicacion.Dtos;
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
    public class Consulta
    {
        public class Listar : IRequest<List<ListarTratamientoDto>>
        {
            public string QueryLike { get; set; }
            public int NumeroPagina { get; set; }
        }

        public class Manejador : IRequestHandler<Listar, List<ListarTratamientoDto>>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<List<ListarTratamientoDto>> Handle(Listar request, CancellationToken cancellationToken)
            {
                var tratamientos = await _context.Tratamiento
                    .Select(t => new ListarTratamientoDto
                    {
                        TratamientoId = t.TratamientoId,
                        EvaluacionId = t.EvaluacionId,
                        Codigo = t.Codigo,
                        Nombre = t.Nombre,
                        FechaInicio = t.FechaInicio,
                        FechaFin = t.FechaFin,
                        UsuarioId = t.UsuarioId,
                        Evaluacion = t.Evaluacion.Codigo + " - " + t.Evaluacion.Nombre,
                        Responsable = t.Usuario.Nombres
                    })
                    .Where(o => (o.Nombre.Contains(request.QueryLike) || o.Codigo.Contains(request.QueryLike)) )
                    .ToListAsync();

                return tratamientos;
            }
        }
    }
}
