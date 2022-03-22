using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIClient.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asignacion",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Matricula = table.Column<string>(type: "varchar(75)", nullable: false),
                    Nombres = table.Column<string>(type: "varchar(75)", nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "varchar(75)", nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "varchar(75)", nullable: false),
                    Rol = table.Column<string>(type: "varchar(75)", nullable: false),
                    RolInsourcing = table.Column<string>(type: "varchar(75)", nullable: false),
                    CodApp = table.Column<string>(type: "varchar(75)", nullable: false),
                    Asignar = table.Column<int>(type: "int", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignacion", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asignacion");
        }
    }
}
