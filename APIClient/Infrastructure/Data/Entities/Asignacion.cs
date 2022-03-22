using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace APIClient.Infrastructure.Data.Entities
{
    public partial class Asignacion
    {
      
        public string id { get; set; }

        
        public string Matricula { get; set; }


  
        public string Nombres { get; set; }

   
        public string ApellidoPaterno { get; set; }


        
        public string ApellidoMaterno { get; set; }

        
       
        public string Rol { get; set; }


        
        public string RolInsourcing { get; set; }

         
        public string CodApp { get; set; }

      
        public int Asignar { get; set; }


      
        public DateTime FechaRegistro { get; set; }
    }
}
