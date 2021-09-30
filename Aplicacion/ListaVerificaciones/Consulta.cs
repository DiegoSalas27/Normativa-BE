﻿using Aplicacion.Dtos;
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
            public Manejador(NormativaContext context)
            {
                _context = context;
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
                            CriterioId = req.CriterioId,
                            Criterio = new CriterioDto
                            {
                                CriterioId = req.Criterio.CriterioId,
                                Descripcion = req.Criterio.Descripcion,
                                Peso = req.Criterio.Peso,
                            },
                            Recomendacion = req.Recomendacion
                        }),
                        NivelesRiesgos = x.NivelesRiesgosList.Select(nr => new NivelesRiesgo
                        {
                            NivelesRiesgoId = nr.NivelesRiesgoId,
                            Nombre = nr.Nombre,
                            ExtMinimo = nr.ExtMinimo,
                            ExtMaximo = nr.ExtMaximo
                        })
                    })
                    .Where(o => o.Nombre.Contains(request.QueryLike) || o.Codigo.Contains(request.QueryLike))
                    .ToListAsync();

                return listasVerificacion;
            }
        }
    }
}
