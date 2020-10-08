using Microsoft.EntityFrameworkCore.Migrations;

namespace TrabajoPractico.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "usuario",
                table: "Recursos",
                newName: "Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Recursos_Usuario",
                table: "Recursos",
                column: "Usuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Recursos_Usuarios_Usuario",
                table: "Recursos",
                column: "Usuario",
                principalTable: "Usuarios",
                principalColumn: "Usuario",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recursos_Usuarios_Usuario",
                table: "Recursos");

            migrationBuilder.DropIndex(
                name: "IX_Recursos_Usuario",
                table: "Recursos");

            migrationBuilder.RenameColumn(
                name: "Usuario",
                table: "Recursos",
                newName: "usuario");
        }
    }
}
