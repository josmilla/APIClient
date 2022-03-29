using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
 using APIClient.Infrastructure.Data.Entities;
using System;

namespace APIClient.Infrastructure.Data.Contexts.Configurations
{
    public partial class AsignacionConfiguration : IEntityTypeConfiguration<Asignacion>
    {
        public void Configure(EntityTypeBuilder<Asignacion> entity)
        {
            entity.ToTable("Asignacion");

            // entity.Property(e => e.Id).IsRequired();
            //entity.Property(e => e.ProductId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Matricula).IsRequired();

            entity.Property(e => e.Nombres).IsRequired();

            //entity.Property(e => e.ApellidoPaterno).IsRequired();

            //entity.Property(e => e.ApellidoMaterno).IsRequired();

            //entity.Property(e => e.Rol).IsRequired();
            //entity.Property(e => e.RolInsourcing).IsRequired();

            //entity.Property(e => e.CodApp).IsRequired();

            entity.Property(e => e.Asignar).IsRequired();

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Asignacion> entity);
    }
}
