using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SISTEMA_DE_VOTACIONES.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePlanchaWithViceAndSecretario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Puesto",
                table: "Planchas",
                newName: "Vicepresidente");

            migrationBuilder.RenameColumn(
                name: "Candidato",
                table: "Planchas",
                newName: "Secretario");

            migrationBuilder.AddColumn<string>(
                name: "Presidente",
                table: "Planchas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Presidente",
                table: "Planchas");

            migrationBuilder.RenameColumn(
                name: "Vicepresidente",
                table: "Planchas",
                newName: "Puesto");

            migrationBuilder.RenameColumn(
                name: "Secretario",
                table: "Planchas",
                newName: "Candidato");
        }
    }
}
