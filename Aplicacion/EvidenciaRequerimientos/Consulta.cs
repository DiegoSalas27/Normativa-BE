using Aplicacion.Dtos;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.EvidenciaRequerimientos
{
    public class Consulta
    {
        public class Listar : IRequest<ObtenerEvidenciaRequerimientoAccionMitigacionDto>
        {
            public Guid AccionMitigacionId { get; set; }
        }

        public class Manejador : IRequestHandler<Listar, ObtenerEvidenciaRequerimientoAccionMitigacionDto>
        {
            private readonly NormativaContext _context;
            private readonly UserManager<Usuario> _userManager;
            public Manejador(UserManager<Usuario> userManager, NormativaContext context)
            {
                _userManager = userManager;
                _context = context;
            }
            public async Task<ObtenerEvidenciaRequerimientoAccionMitigacionDto> Handle(Listar request, CancellationToken cancellationToken)
            {
                var evidenciaAccionMitigacion = _context.EvidenciaRequerimiento
                    .Where(evR => evR.AccionMitigacionId == request.AccionMitigacionId)
                    .Select(evR => new ObtenerEvidenciaRequerimientoAccionMitigacionDto
                    {
                        Justificacion = evR.Justificacion,
                        Recomendacion = evR.Requerimiento.Recomendacion,
                        RequerimientoDescripcion = evR.Requerimiento.Descripcion,
                        CriterioDescripcion = evR.Requerimiento.Criterio.Descripcion,
                        RespuestaItem = evR.RespuestaItem,
                        EstadoAccionMitigacion = evR.AccionMitigacion.Estado,
                        Evidencia = new ObtenerEvidenciaDto
                        {
                            Adjunto = evR.Evidencia.Adjunto,
                            EvidenciaId = evR.Evidencia.EvidenciaId,
                            Nombre = evR.Evidencia.Nombre
                        },
                        ComentarioLista = evR.AccionMitigacion.ComentarioLista.Select(cml => new ComentarioListaDto
                        { 
                            UsuarioId = cml.UsuarioId,
                            Descripcion = cml.Descripcion,
                            FechaCreacion = cml.FechaCreacion
                        }).OrderByDescending(cld => cld.FechaCreacion).ToList()
                    })
                    .FirstOrDefault();

                foreach (var comentario in evidenciaAccionMitigacion.ComentarioLista)
                {
                    var usuario = await _userManager.FindByIdAsync(comentario.UsuarioId);
                    var rol = new List<string>(await _userManager.GetRolesAsync(usuario));
                    comentario.NombreUsuario = usuario.Nombres + ' ' + usuario.Apellidos;
                    comentario.UsuarioRol = rol.ElementAt(0);
                }

                return evidenciaAccionMitigacion;
            }
        }
    }
}
