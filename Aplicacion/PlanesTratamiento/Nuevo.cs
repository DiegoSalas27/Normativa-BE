﻿using Dominio;
using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.PlanesTratamiento
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<Ejecuta>
        {
            public Guid EvaluacionId { get; set; }
            public Guid UsuarioId { get; set; }
            public string Nombre  { get; set; }
            public string Codigo { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, Ejecuta>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                this._context = context;
            }
            public async Task<Ejecuta> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
      
                var tratamiento = new Tratamiento
                {
                    EvaluacionId = request.EvaluacionId,
                    Nombre = request.Nombre,
                    PorcentajeAvance = 0,
                    UsuarioId = request.UsuarioId,
                    Codigo = request.Codigo
                };

                _context.Tratamiento.Add(tratamiento);
 
                var valor = await _context.SaveChangesAsync();

                if (valor > 0)
                {
                    return request;
                }

                throw new Exception("No se pudo insertar la tratamiento");
            }
        }
    }
}