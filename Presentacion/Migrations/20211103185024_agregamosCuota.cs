using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Presentacion.Migrations
{
    public partial class agregamosCuota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuotas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mes = table.Column<int>(nullable: false),
                    Año = table.Column<int>(nullable: false),
                    Importe = table.Column<float>(nullable: false),
                    Vencimiento = table.Column<DateTime>(nullable: false),
                    FechaPago = table.Column<DateTime>(nullable: false),
                    Recargo = table.Column<float>(nullable: false),
                    Cobrado = table.Column<float>(nullable: false),
                    CobradorId = table.Column<int>(nullable: true),
                    SocioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuotas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cuotas_Cobradores_CobradorId",
                        column: x => x.CobradorId,
                        principalTable: "Cobradores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cuotas_Socios_SocioId",
                        column: x => x.SocioId,
                        principalTable: "Socios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuotas_CobradorId",
                table: "Cuotas",
                column: "CobradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuotas_SocioId",
                table: "Cuotas",
                column: "SocioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuotas");
        }
    }
}
