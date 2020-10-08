using Microsoft.EntityFrameworkCore.Migrations;

namespace TrabajoPractico.Migrations
{
    public partial class Test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalles_Recursos_recursoNombre",
                table: "Detalles");

            migrationBuilder.RenameColumn(
                name: "tiempo",
                table: "Detalles",
                newName: "Tiempo");

            migrationBuilder.RenameColumn(
                name: "recursoNombre",
                table: "Detalles",
                newName: "RecursoNombre");

            migrationBuilder.RenameColumn(
                name: "fecha",
                table: "Detalles",
                newName: "Fecha");

            migrationBuilder.RenameIndex(
                name: "IX_Detalles_recursoNombre",
                table: "Detalles",
                newName: "IX_Detalles_RecursoNombre");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalles_Recursos_RecursoNombre",
                table: "Detalles",
                column: "RecursoNombre",
                principalTable: "Recursos",
                principalColumn: "Nombre",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalles_Recursos_RecursoNombre",
                table: "Detalles");

            migrationBuilder.RenameColumn(
                name: "Tiempo",
                table: "Detalles",
                newName: "tiempo");

            migrationBuilder.RenameColumn(
                name: "RecursoNombre",
                table: "Detalles",
                newName: "recursoNombre");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Detalles",
                newName: "fecha");

            migrationBuilder.RenameIndex(
                name: "IX_Detalles_RecursoNombre",
                table: "Detalles",
                newName: "IX_Detalles_recursoNombre");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalles_Recursos_recursoNombre",
                table: "Detalles",
                column: "recursoNombre",
                principalTable: "Recursos",
                principalColumn: "Nombre",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
