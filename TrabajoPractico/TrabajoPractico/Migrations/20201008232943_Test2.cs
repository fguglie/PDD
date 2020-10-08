using Microsoft.EntityFrameworkCore.Migrations;

namespace TrabajoPractico.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalles_Recursos_recursonombre",
                table: "Detalles");

            migrationBuilder.DropForeignKey(
                name: "FK_Recursos_Usuarios_Usuario",
                table: "Recursos");

            migrationBuilder.DropIndex(
                name: "IX_Recursos_Usuario",
                table: "Recursos");

            migrationBuilder.DropColumn(
                name: "String",
                table: "Tareas");

            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "Recursos");

            migrationBuilder.RenameColumn(
                name: "vencimiento",
                table: "Tareas",
                newName: "Vencimiento");

            migrationBuilder.RenameColumn(
                name: "responsable",
                table: "Tareas",
                newName: "Responsable");

            migrationBuilder.RenameColumn(
                name: "estimacion",
                table: "Tareas",
                newName: "Estimacion");

            migrationBuilder.RenameColumn(
                name: "titulo",
                table: "Tareas",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Recursos",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "recursonombre",
                table: "Detalles",
                newName: "recursoNombre");

            migrationBuilder.RenameIndex(
                name: "IX_Detalles_recursonombre",
                table: "Detalles",
                newName: "IX_Detalles_recursoNombre");

            migrationBuilder.AlterColumn<string>(
                name: "Clave",
                table: "Usuarios",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Tareas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Usuario1",
                table: "Recursos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "recursoNombre",
                table: "Detalles",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recursos_Usuario1",
                table: "Recursos",
                column: "Usuario1");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalles_Recursos_recursoNombre",
                table: "Detalles",
                column: "recursoNombre",
                principalTable: "Recursos",
                principalColumn: "Nombre",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recursos_Usuarios_Usuario1",
                table: "Recursos",
                column: "Usuario1",
                principalTable: "Usuarios",
                principalColumn: "Usuario",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalles_Recursos_recursoNombre",
                table: "Detalles");

            migrationBuilder.DropForeignKey(
                name: "FK_Recursos_Usuarios_Usuario1",
                table: "Recursos");

            migrationBuilder.DropIndex(
                name: "IX_Recursos_Usuario1",
                table: "Recursos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Tareas");

            migrationBuilder.DropColumn(
                name: "Usuario1",
                table: "Recursos");

            migrationBuilder.RenameColumn(
                name: "Vencimiento",
                table: "Tareas",
                newName: "vencimiento");

            migrationBuilder.RenameColumn(
                name: "Responsable",
                table: "Tareas",
                newName: "responsable");

            migrationBuilder.RenameColumn(
                name: "Estimacion",
                table: "Tareas",
                newName: "estimacion");

            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Tareas",
                newName: "titulo");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Recursos",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "recursoNombre",
                table: "Detalles",
                newName: "recursonombre");

            migrationBuilder.RenameIndex(
                name: "IX_Detalles_recursoNombre",
                table: "Detalles",
                newName: "IX_Detalles_recursonombre");

            migrationBuilder.AlterColumn<string>(
                name: "Clave",
                table: "Usuarios",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AddColumn<bool>(
                name: "String",
                table: "Tareas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "Recursos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "recursonombre",
                table: "Detalles",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Recursos_Usuario",
                table: "Recursos",
                column: "Usuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalles_Recursos_recursonombre",
                table: "Detalles",
                column: "recursonombre",
                principalTable: "Recursos",
                principalColumn: "nombre",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recursos_Usuarios_Usuario",
                table: "Recursos",
                column: "Usuario",
                principalTable: "Usuarios",
                principalColumn: "Usuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
