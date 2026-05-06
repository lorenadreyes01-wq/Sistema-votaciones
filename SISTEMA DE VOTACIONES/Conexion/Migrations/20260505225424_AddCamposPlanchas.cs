using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SISTEMA_DE_VOTACIONES.Migrations
{
    /// <inheritdoc />
    public partial class AddCamposPlanchas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lema",
                table: "Planchas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PresidenteFoto",
                table: "Planchas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecretarioFoto",
                table: "Planchas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VicepresidenteFoto",
                table: "Planchas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lema",
                table: "Planchas");

            migrationBuilder.DropColumn(
                name: "PresidenteFoto",
                table: "Planchas");

            migrationBuilder.DropColumn(
                name: "SecretarioFoto",
                table: "Planchas");

            migrationBuilder.DropColumn(
                name: "VicepresidenteFoto",
                table: "Planchas");
        }
    }
}
