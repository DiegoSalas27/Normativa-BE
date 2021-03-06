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
    public class ListaVerificacionActualizar
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

            public Manejador(
                NormativaContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var listaVerificacion = await _context.ListaVerificacion.FindAsync(request.ListaVerificacion.ListaVerificacionId);

                listaVerificacion.Nombre = request.ListaVerificacion.Nombre;

                var resultado = await _context.SaveChangesAsync();

                if (resultado > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo actualizar lista de verificacion");
            }
        }
    }
}