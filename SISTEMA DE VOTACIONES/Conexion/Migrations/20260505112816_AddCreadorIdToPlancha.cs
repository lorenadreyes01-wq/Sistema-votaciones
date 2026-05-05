using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SISTEMA_DE_VOTACIONES.Migrations
{
    /// <inheritdoc />
    public partial class AddCreadorIdToPlancha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreadorId",
                table: "Planchas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreadorId",
                table: "Planchas");
        }
    }
}
