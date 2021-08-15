﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

namespace Persistencia.Migrations
{
    [DbContext(typeof(NormativaContext))]
    [Migration("20210814163358_AddedEstadoToMitigacion")]
    partial class AddedEstadoToMitigacion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dominio.AccionMitigacion", b =>
                {
                    b.Property<Guid>("AccionMitigacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TratamientoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AccionMitigacionId");

                    b.HasIndex("TratamientoId");

                    b.ToTable("AccionMitigacion");
                });

            modelBuilder.Entity("Dominio.Comentario", b =>
                {
                    b.Property<Guid>("ComentarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TratamientoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ComentarioId");

                    b.HasIndex("TratamientoId");

                    b.ToTable("Comentario");
                });

            modelBuilder.Entity("Dominio.Criterio", b =>
                {
                    b.Property<Guid>("CriterioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Peso")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("CriterioId");

                    b.ToTable("Criterio");
                });

            modelBuilder.Entity("Dominio.Especialidad", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RolId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Especialidad");
                });

            modelBuilder.Entity("Dominio.Evaluacion", b =>
                {
                    b.Property<Guid>("EvaluacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ListaVerificacionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ObraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("PorcentajeFinal")
                        .HasColumnType("decimal(18,4)");

                    b.Property<bool>("Visbilidad")
                        .HasColumnType("bit");

                    b.HasKey("EvaluacionId");

                    b.HasIndex("ListaVerificacionId");

                    b.HasIndex("ObraId");

                    b.ToTable("Evaluacion");
                });

            modelBuilder.Entity("Dominio.Evidencia", b =>
                {
                    b.Property<Guid>("EvidenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adjunto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EvidenciaId");

                    b.ToTable("Evidencia");
                });

            modelBuilder.Entity("Dominio.EvidenciaRequerimiento", b =>
                {
                    b.Property<Guid>("EvidenciaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RequerimientoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PruebaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccionMitigacionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Justificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Recomendacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("RespuestaItem")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("EvidenciaId", "RequerimientoId", "PruebaId");

                    b.HasIndex("AccionMitigacionId")
                        .IsUnique();

                    b.HasIndex("PruebaId");

                    b.HasIndex("RequerimientoId");

                    b.ToTable("EvidenciaRequerimiento");
                });

            modelBuilder.Entity("Dominio.ListaVerificacion", b =>
                {
                    b.Property<Guid>("ListaVerificacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ListaVerificacionId");

                    b.ToTable("ListaVerificacion");
                });

            modelBuilder.Entity("Dominio.ListaVerificacionNivelesRiesgo", b =>
                {
                    b.Property<Guid>("ListaVerificacionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("NivelesRiesgoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ListaVerificacionId", "NivelesRiesgoId");

                    b.HasIndex("NivelesRiesgoId");

                    b.ToTable("ListaVerificacionNivelesRiesgo");
                });

            modelBuilder.Entity("Dominio.NivelesRiesgo", b =>
                {
                    b.Property<Guid>("NivelesRiesgoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ExtMaximo")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("ExtMinimo")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NivelesRiesgoId");

                    b.ToTable("NivelesRiesgo");
                });

            modelBuilder.Entity("Dominio.Obra", b =>
                {
                    b.Property<Guid>("ObraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ObraId");

                    b.ToTable("Obra");
                });

            modelBuilder.Entity("Dominio.Prueba", b =>
                {
                    b.Property<Guid>("PruebaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EvaluacionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PorcentajeCumplimiento")
                        .HasColumnType("decimal(18,4)");

                    b.Property<bool>("Visbilidad")
                        .HasColumnType("bit");

                    b.HasKey("PruebaId");

                    b.HasIndex("EvaluacionId");

                    b.ToTable("Prueba");
                });

            modelBuilder.Entity("Dominio.Requerimiento", b =>
                {
                    b.Property<Guid>("RequerimientoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CriterioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ListaVerificacionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RequerimientoId");

                    b.HasIndex("CriterioId");

                    b.HasIndex("ListaVerificacionId");

                    b.ToTable("Requerimiento");
                });

            modelBuilder.Entity("Dominio.Tratamiento", b =>
                {
                    b.Property<Guid>("TratamientoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EvaluacionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PorcentajeAvance")
                        .HasColumnType("decimal(18,4)");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UsuarioId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TratamientoId");

                    b.HasIndex("EvaluacionId")
                        .IsUnique();

                    b.HasIndex("UsuarioId1");

                    b.ToTable("Tratamiento");
                });

            modelBuilder.Entity("Dominio.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<Guid?>("EspecialidadId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Dominio.AccionMitigacion", b =>
                {
                    b.HasOne("Dominio.Tratamiento", "Tratamiento")
                        .WithMany("AccionMitigacionLista")
                        .HasForeignKey("TratamientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tratamiento");
                });

            modelBuilder.Entity("Dominio.Comentario", b =>
                {
                    b.HasOne("Dominio.Tratamiento", "Tratamiento")
                        .WithMany("ComentarioLista")
                        .HasForeignKey("TratamientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tratamiento");
                });

            modelBuilder.Entity("Dominio.Evaluacion", b =>
                {
                    b.HasOne("Dominio.ListaVerificacion", "ListaVerificacion")
                        .WithMany("EvaluacionList")
                        .HasForeignKey("ListaVerificacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Obra", "Obra")
                        .WithMany("EvaluacionList")
                        .HasForeignKey("ObraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ListaVerificacion");

                    b.Navigation("Obra");
                });

            modelBuilder.Entity("Dominio.EvidenciaRequerimiento", b =>
                {
                    b.HasOne("Dominio.AccionMitigacion", "AccionMitigacion")
                        .WithOne("EvidenciaRequerimiento")
                        .HasForeignKey("Dominio.EvidenciaRequerimiento", "AccionMitigacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Evidencia", "Evidencia")
                        .WithMany("RequerimientoEvaluacionLink")
                        .HasForeignKey("EvidenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Prueba", "Prueba")
                        .WithMany("EvidenciaRequerimientoLink")
                        .HasForeignKey("PruebaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Requerimiento", "Requerimiento")
                        .WithMany("EvidenciaPruebaLink")
                        .HasForeignKey("RequerimientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccionMitigacion");

                    b.Navigation("Evidencia");

                    b.Navigation("Prueba");

                    b.Navigation("Requerimiento");
                });

            modelBuilder.Entity("Dominio.ListaVerificacionNivelesRiesgo", b =>
                {
                    b.HasOne("Dominio.ListaVerificacion", "VerificacionLista")
                        .WithMany("NivelesRiesgosLink")
                        .HasForeignKey("ListaVerificacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.NivelesRiesgo", "NivelesRiesgo")
                        .WithMany("ListaVerificacionLink")
                        .HasForeignKey("NivelesRiesgoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NivelesRiesgo");

                    b.Navigation("VerificacionLista");
                });

            modelBuilder.Entity("Dominio.Prueba", b =>
                {
                    b.HasOne("Dominio.Evaluacion", "Evaluacion")
                        .WithMany("PruebaList")
                        .HasForeignKey("EvaluacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evaluacion");
                });

            modelBuilder.Entity("Dominio.Requerimiento", b =>
                {
                    b.HasOne("Dominio.Criterio", "Criterio")
                        .WithMany("RequerimientoList")
                        .HasForeignKey("CriterioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.ListaVerificacion", "VerificacionLista")
                        .WithMany("RequerimientoList")
                        .HasForeignKey("ListaVerificacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Criterio");

                    b.Navigation("VerificacionLista");
                });

            modelBuilder.Entity("Dominio.Tratamiento", b =>
                {
                    b.HasOne("Dominio.Evaluacion", "Evaluacion")
                        .WithOne("Tratamiento")
                        .HasForeignKey("Dominio.Tratamiento", "EvaluacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Usuario", "Usuario")
                        .WithMany("TratamientoList")
                        .HasForeignKey("UsuarioId1");

                    b.Navigation("Evaluacion");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Dominio.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Dominio.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Dominio.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.AccionMitigacion", b =>
                {
                    b.Navigation("EvidenciaRequerimiento");
                });

            modelBuilder.Entity("Dominio.Criterio", b =>
                {
                    b.Navigation("RequerimientoList");
                });

            modelBuilder.Entity("Dominio.Evaluacion", b =>
                {
                    b.Navigation("PruebaList");

                    b.Navigation("Tratamiento");
                });

            modelBuilder.Entity("Dominio.Evidencia", b =>
                {
                    b.Navigation("RequerimientoEvaluacionLink");
                });

            modelBuilder.Entity("Dominio.ListaVerificacion", b =>
                {
                    b.Navigation("EvaluacionList");

                    b.Navigation("NivelesRiesgosLink");

                    b.Navigation("RequerimientoList");
                });

            modelBuilder.Entity("Dominio.NivelesRiesgo", b =>
                {
                    b.Navigation("ListaVerificacionLink");
                });

            modelBuilder.Entity("Dominio.Obra", b =>
                {
                    b.Navigation("EvaluacionList");
                });

            modelBuilder.Entity("Dominio.Prueba", b =>
                {
                    b.Navigation("EvidenciaRequerimientoLink");
                });

            modelBuilder.Entity("Dominio.Requerimiento", b =>
                {
                    b.Navigation("EvidenciaPruebaLink");
                });

            modelBuilder.Entity("Dominio.Tratamiento", b =>
                {
                    b.Navigation("AccionMitigacionLista");

                    b.Navigation("ComentarioLista");
                });

            modelBuilder.Entity("Dominio.Usuario", b =>
                {
                    b.Navigation("TratamientoList");
                });
#pragma warning restore 612, 618
        }
    }
}
