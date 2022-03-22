﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using APIClient.Infrastructure.Data.Contexts.Configurations;
using APIClient.Infrastructure.Data.Entities;
using System;
#nullable disable

#nullable disable

namespace APIClient.Infrastructure.Data.Contexts
{
    public partial class AsignacionContext : DbContext
    {
        public AsignacionContext()
        {
        }

        public AsignacionContext(DbContextOptions<AsignacionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Asignacion> Asignacion { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.ApplyConfiguration(new Configurations.AsignacionConfiguration());
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}