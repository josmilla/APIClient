// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace APIClient.Infrastructure.Data.Entities
{
    public partial class Rol
    {
        [Key]
        public int IdRol { get; set; }
        public string SqRol { get; set; }
        public string RolInsourcing { get; set; }
        public string Especialidad { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public bool? Estado { get; set; }
    }
}