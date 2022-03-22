using Microsoft.EntityFrameworkCore;
using APIClient.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;

namespace APIClient.Infrastructure.Data.Contexts
{
    public static class AsignacionContextExtensions
    {
        public static void EnsureSeeDataForContext(this AsignacionContext context)
        {
            context.Asignacion.RemoveRange(context.Asignacion);
            context.SaveChanges();

            List<Asignacion> asignaciones = new List<Asignacion>();

            asignaciones.Add(new Asignacion
            {
                id = "1",
                Matricula = "U20100",
                Nombres = "Juan P",
                ApellidoPaterno = "Rojas",
                ApellidoMaterno = "Rivas",
                Rol = "Developer",
                RolInsourcing = "DEV",
                CodApp = "E210",
                Asignar = 10,
                FechaRegistro = DateTime.Now
            });
            asignaciones.Add(new Asignacion
            {
                id = "2",
                Matricula = "U20100",
                Nombres = "Juan P",
                ApellidoPaterno = "Rojas",
                ApellidoMaterno = "Rivas",
                Rol = "Develepor",
                RolInsourcing = "DEV",
                CodApp = "E212",
                Asignar = 20,
                FechaRegistro = DateTime.Now
            });
            asignaciones.Add(new Asignacion
            {
                id = "3",
                Matricula = "U20100",
                Nombres = "Juan P",
                ApellidoPaterno = "Rojas",
                ApellidoMaterno = "Rivas",
                Rol = "Developer",
                RolInsourcing = "DEV",
                CodApp = "E213",
                Asignar = 20,
                FechaRegistro = DateTime.Now
            });
            asignaciones.Add(new Asignacion
            {
                id = "4",
                Matricula = "U20100",
                Nombres = "Juan P",
                ApellidoPaterno = "Rojas",
                ApellidoMaterno = "Rivas",
                Rol = "Developer",
                RolInsourcing = "DEV",
                CodApp = "E214",
                Asignar = 25,
                FechaRegistro = DateTime.Now
            });
            asignaciones.Add(new Asignacion
            {
                id = "5",
                Matricula = "U20100",
                Nombres = "Juan P",
                ApellidoPaterno = "Rojas",
                ApellidoMaterno = "Rivas",
                Rol = "Developer",
                RolInsourcing = "DEV",
                CodApp = "E215",
                Asignar = 25,
                FechaRegistro = DateTime.Now
            });

            context.Asignacion.AddRange(asignaciones);
           
            context.SaveChanges();
            
        }
    }
}
