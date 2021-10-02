using Aplicacion.Dtos;
using Dominio;
using MediatR;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.ListaVerificaciones
{
    public class Edita
    {
        public class Ejecuta : IRequest
        {
            public IList<Criterio> Criterios { get; set; }
            public IList<Requerimiento> Requerimientos { get; set; }
            public IList<NivelesRiesgo> NivelesRiesgo { get; set; }
            public ObtenerListaVerificacionDto ListaVerificacion { get; set; }
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
                var listaVerificacion = _context.ListaVerificacion.Find(request.ListaVerificacion.ListaVerificacionId);
                listaVerificacion.Nombre = request.ListaVerificacion.Nombre;

                _context.Criterio.AddRange(request.Criterios);

                _context.NivelesRiesgo.UpdateRange(request.NivelesRiesgo);

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
