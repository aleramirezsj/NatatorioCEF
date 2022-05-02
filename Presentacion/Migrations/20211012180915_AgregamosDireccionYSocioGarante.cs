using Microsoft.EntityFrameworkCore.Migrations;

namespace Presentacion.Migrations
{
    public partial class AgregamosDireccionYSocioGarante : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Dirección",
                table: "Socios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SocioGaranteId",
                table: "Socios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SocioId",
                table: "Socios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Socios_SocioGaranteId",
                table: "Socios",
                column: "SocioGaranteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Socios_Socios_SocioGaranteId",
                table: "Socios",
                column: "SocioGaranteId",
                principalTable: "Socios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socios_Socios_SocioGaranteId",
                table: "Socios");

            migrationBuilder.DropIndex(
                name: "IX_Socios_SocioGaranteId",
                table: "Socios");

            migrationBuilder.DropColumn(
                name: "Dirección",
                table: "Socios");

            migrationBuilder.DropColumn(
                name: "SocioGaranteId",
                table: "Socios");

            migrationBuilder.DropColumn(
                name: "SocioId",
                table: "Socios");
        }
    }
}
