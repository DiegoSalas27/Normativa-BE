using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Dominio;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Persistencia
{
    public class NormativaContext : IdentityDbContext<Usuario>
    {
        public NormativaContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EvidenciaRequerimiento>()
                .HasKey(er => new { er.EvidenciaId, er.RequerimientoId, er.PruebaId });
            modelBuilder.Entity<ListaVerificacionNivelesRiesgo>()
                .HasKey(ln => new { ln.ListaVerificacionId, ln.NivelesRiesgoId });
            modelBuilder.Entity<Tratamiento>()
                .HasOne(n => n.Usuario)
                .WithMany(b => b.TratamientoList);
        }

        public DbSet<Especialidad> Especialidad { get; set; }
        public DbSet<AccionMitigacion> AccionMitigacion { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Criterio> Criterio { get; set; }
        public DbSet<Evaluacion> Evaluacion { get; set; }
        public DbSet<Evidencia> Evidencia { get; set; }
        public DbSet<EvidenciaRequerimiento> EvidenciaRequerimiento { get; set; }
        public DbSet<ListaVerificacion> ListaVerificacion { get; set; }
        public DbSet<ListaVerificacionNivelesRiesgo> ListaVerificacionNivelesRiesgo { get; set; }
        public DbSet<NivelesRiesgo> NivelesRiesgo { get; set; }
        public DbSet<Obra> Obra { get; set; }
        public DbSet<Prueba> Prueba { get; set; }
        public DbSet<Requerimiento> Requerimiento { get; set; }
        public DbSet<Tratamiento> Tratamiento { get; set; }
    }
}
