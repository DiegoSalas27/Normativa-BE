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

namespace Aplicacion.ListaVerificaciones
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public IList<Criterio> Criterios { get; set; }
            public IList<Requerimiento> Requerimientos { get; set; }
            public IList<NivelesRiesgo> NivelesRiesgo { get; set; }
            public ObtenerListaVerificacionDto ListaVerificacion { get; set; }
            public bool Update { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly NormativaContext _context;
            public Manejador(NormativaContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                 _context.Criterio.AddRange(request.Criterios);

                var listaVerificacion = new ListaVerificacion
                {
                    ListaVerificacionId = request.ListaVerificacion.ListaVerificacionId,
                    Codigo = request.ListaVerificacion.Codigo,
                    FechaCreacion = DateTime.Now,
                    Nombre = request.ListaVerificacion.Nombre,
                };

                _context.ListaVerificacion.Add(listaVerificacion);

                _context.NivelesRiesgo.AddRange(request.NivelesRiesgo);

                _context.Requerimiento.AddRange(request.Requerimientos);

                var valor = await _context.SaveChangesAsync();
                if (valor > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo insertar la lista de verificacion");
            }
        }
    }
}