using Aplicacion.Dtos;
using AutoMapper;
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

namespace Aplicacion.ListaVerificaciones
{
    public class Consulta
    {
        public class Listar : IRequest<List<ObtenerListaVerificacionDto>>
        {
            public string QueryLike { get; set; }
        }

        public class Manejador : IRequestHandler<Listar, List<ObtenerListaVerificacionDto>>
        {
            private readonly NormativaContext _context;
            private readonly IMapper _mapper;
            public Manejador(NormativaContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<List<ObtenerListaVerificacionDto>> Handle(Listar request, CancellationToken cancellationToken)
            {
                var listasVerificacion = await _context.ListaVerificacion
                    .Select(x => new ObtenerListaVerificacionDto
                    {
                        ListaVerificacionId = x.ListaVerificacionId,
                        Codigo = x.Codigo,
                        Nombre = x.Nombre,
                        FechaCreacion = x.FechaCreacion,
                        RequerimientosCount = x.RequerimientoList.Count,
                        Requerimientos = x.RequerimientoList.Select(req => new ObtenerListaRequerimientoDto
                        {
                            RequerimientoId = req.RequerimientoId,
                            Descripcion = req.Descripcion,
                            Criterio = new CriterioDto
                            {
                                Descripcion = req.Criterio.Descripcion,
                                Peso = req.Criterio.Peso,
                            }
                        })
                    })
                    .Where(o => o.Nombre.Contains(request.QueryLike) || o.Codigo.Contains(request.QueryLike))
                    .ToListAsync();

                return listasVerificacion;
            }
        }
    }
}
