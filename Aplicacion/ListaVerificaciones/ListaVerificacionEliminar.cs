//using Aplicacion.ManejadorError;
//using MediatR;
//using Microsoft.EntityFrameworkCore;
//using Persistencia;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Aplicacion.ListaVerificaciones
//{
//    public class ListaVerificacionEliminar
//    {
//        public class Ejecuta : IRequest
//        {
//            public Guid ListaVerificacionId { get; set; }
//        }

//        public class Manejador : IRequestHandler<Ejecuta>
//        {
//            private readonly NormativaContext _context;

//            public Manejador(NormativaContext normativaContext)
//            {
//                _context = normativaContext;

//            }
//            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
//            {
//                var listaVerificacion = await _context.ListaVerificacion.FindAsync(request.ListaVerificacionId);
//                if (listaVerificacion == null)
//                {
//                    throw new ManejadorExcepcion(HttpStatusCode.NotFound, new { mensaje = "La lista de verificacion no existe" });
//                }
//                //eliminar resto de entidades dependientes
//                //lista de requerimientos
//                var requerimientos = await _context.Requerimiento
//                    .Where(r => r.ListaVerificacionId == listaVerificacion.ListaVerificacionId)
//                    .ToListAsync();
//                //lista de niveles de riesgo
//                var nivelesRiesgo = await _context.NivelesRiesgo
//                    .Where(nr => nr.ListaVerificacionId == listaVerificacion.ListaVerificacionId)
//                    .ToListAsync();
//                //lista de evaluaciones
//                var evaluaciones = await _context.Evaluacion
//                    .Where(e => e.ListaVerificacionId == listaVerificacion.ListaVerificacionId)
//                    .ToListAsync();
//                //tratamiento que depende de evaluaciones
//                var tratamientos;
//                foreach(var evaluacion in evaluaciones)
//                {
//                    await tratamientos.AddRange(_context.Tratamiento
//                    .Where(t => t.EvaluacionId == evaluacion.EvaluacionId)
//                    .ToListAsync());
//                }
//                //accion de mitigacion que depende de tratamiento
//                var accionesMitigacion;
//                 foreach(var tratamiento in tratamientos)
//                {
//                    await accionesMitigacion.AddRange(_context.AccionMitigacion
//                    .Where(am => am.TratamientoId == tratamiento.TratamientoId)
//                    .ToListAsync());
//                }
//                //comentario que depende de accion de mitigacion
//                var comentarios;
//                 foreach(var accionMitigacion in accionesMitigacion)
//                {
//                    await comentarios.AddRange(_context.Comentario
//                    .Where(c => c.AccionMitigacionId == accionMitigacion.AccionMitigacionId)
//                    .ToListAsync());
//                }
//                //prueba que depende de evaluaciones
//                var pruebas;
//                foreach(var evaluacion in evaluaciones)
//                {
//                    await pruebas.AddRange(_context.Prueba
//                    .Where(p => p.EvaluacionId == evaluacion.EvaluacionId)
//                    .ToListAsync());
//                }
//                //evidencia de requerimientos que depende de requerimientos, accion de mitigacion y prueba
//                var evidenciasRequerimiento;
//                foreach(var requerimiento in requerimientos)
//                {
//                    await evidencias.AddRange(_context.EvidenciaRequerimiento
//                    .Where(e => e.RequerimientoId == requerimiento.RequerimientoId)
//                    .ToListAsync());
//                }
//                //removiendo
//                _context.EvidenciaRequerimiento.RemoveRange(evidenciasRequerimiento);
//                _context.Prueba.RemoveRange(pruebas);
//                _context.Comentario.RemoveRange(comentarios);
//                _context.AccionMitigacion.RemoveRange(accionesMitigacion);
//                _context.Tratamiento.RemoveRange(tratamientos);
//                _context.Requerimiento.RemoveRange(requerimientos);
//                _context.Evaluacion.RemoveRange(evaluaciones);
//                _context.NivelesRiesgo.RemoveRange(nivelesRiesgo);
//                _context.ListaVerificacion.Remove(listaVerificacion);

//                var valor = await _context.SaveChangesAsync();

//                if (valor > 0)
//                {
//                    return Unit.Value;
//                }

//                throw new Exception("No se pudo eliminar la lista de verificacion");
//            }
//        }
//    }
//}