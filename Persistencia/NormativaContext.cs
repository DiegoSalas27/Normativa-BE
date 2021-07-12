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
        }

        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Especialidad> Especialidad { get; set; }
    }
}
