using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SISTEMA_DE_VOTACIONES.Migrations
{
    /// <inheritdoc />
    public partial class AddNavigationProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Votaciones_PlanchaId",
                table: "Votaciones",
                column: "PlanchaId");

            migrationBuilder.CreateIndex(
                name: "IX_Votaciones_UsuarioId",
                table: "Votaciones",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Planchas_PartidoId",
                table: "Planchas",
                column: "PartidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Planchas_Partidos_PartidoId",
                table: "Planchas",
                column: "PartidoId",
                principalTable: "Partidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Votaciones_Planchas_PlanchaId",
                table: "Votaciones",
                column: "PlanchaId",
                principalTable: "Planchas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Votaciones_Usuarios_UsuarioId",
                table: "Votaciones",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planchas_Partidos_PartidoId",
                table: "Planchas");

            migrationBuilder.DropForeignKey(
                name: "FK_Votaciones_Planchas_PlanchaId",
                table: "Votaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Votaciones_Usuarios_UsuarioId",
                table: "Votaciones");

            migrationBuilder.DropIndex(
                name: "IX_Votaciones_PlanchaId",
                table: "Votaciones");

            migrationBuilder.DropIndex(
                name: "IX_Votaciones_UsuarioId",
                table: "Votaciones");

            migrationBuilder.DropIndex(
                name: "IX_Planchas_PartidoId",
                table: "Planchas");
        }
    }
}
