using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace APIClient.Infrastructure.Data.Entities
{
    public partial class Asignacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string id { get; set; }

        [Column(TypeName = "varchar(75)")]
        [Display(Name = "Matricula")]
        [Required(ErrorMessage = "El campo Matricula es obligatorio")]
        public string Matricula { get; set; }


        [Column(TypeName = "varchar(75)")]
        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "El campo Nombres es obligatorio")]
        public string Nombres { get; set; }

        [Column(TypeName = "varchar(75)")]
        [Display(Name = "ApellidoPaterno")]
        [Required(ErrorMessage = "El campo Apellido Paterno es obligatorio")]
        public string ApellidoPaterno { get; set; }


        [Column(TypeName = "varchar(75)")]
        [Display(Name = "ApellidoMaterno")]
        [Required(ErrorMessage = "El campo Apellido MPaterno es obligatorio")]
        public string ApellidoMaterno { get; set; }

        
        [Column(TypeName = "varchar(75)")]
        [Display(Name = "Rol")]
        [Required(ErrorMessage = "El campo Rol es obligatorio")]
        public string Rol { get; set; }


        [Column(TypeName = "varchar(75)")]
        [Display(Name = "RolInsourcing")]
        [Required(ErrorMessage = "El campo RolInsourcing es obligatorio")]
        public string RolInsourcing { get; set; }

        [Column(TypeName = "varchar(75)")]
        [Display(Name = "CodApp")]
        [Required(ErrorMessage = "El campo CodApp es obligatorio")]
        public string CodApp { get; set; }

        
        [Display(Name = "% Asignación")]
        [Required(ErrorMessage = "El campo Asignar es obligatorio")]
        public int Asignar { get; set; }


        [Column(TypeName = "datetime")]
        [Display(Name = "Fecha de Registro")]
        [Required(ErrorMessage = "El campo fecha de ingreso es obligatorio")]
        public DateTime FechaRegistro { get; set; }
    }
}
