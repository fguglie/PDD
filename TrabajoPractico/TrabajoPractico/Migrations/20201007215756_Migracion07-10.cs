using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrabajoPractico.Migrations
{
    public partial class Migracion0710 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recursos",
                columns: table => new
                {
                    nombre = table.Column<string>(nullable: false),
                    usuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recursos", x => x.nombre);
                });

            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    titulo = table.Column<string>(nullable: false),
                    vencimiento = table.Column<DateTime>(nullable: false),
                    estimacion = table.Column<int>(nullable: false),
                    responsable = table.Column<string>(nullable: true),
                    String = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.titulo);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Usuario = table.Column<string>(nullable: false),
                    Clave = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Usuario);
                });

            migrationBuilder.CreateTable(
                name: "Detalles",
                columns: table => new
                {
                    fecha = table.Column<DateTime>(nullable: false),
                    tiempo = table.Column<string>(nullable: true),
                    recursonombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalles", x => x.fecha);
                    table.ForeignKey(
                        name: "FK_Detalles_Recursos_recursonombre",
                        column: x => x.recursonombre,
                        principalTable: "Recursos",
                        principalColumn: "nombre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_recursonombre",
                table: "Detalles",
                column: "recursonombre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalles");

            migrationBuilder.DropTable(
                name: "Tareas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Recursos");
        }
    }
}
