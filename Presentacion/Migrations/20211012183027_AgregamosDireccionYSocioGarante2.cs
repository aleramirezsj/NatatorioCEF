using Microsoft.EntityFrameworkCore.Migrations;

namespace Presentacion.Migrations
{
    public partial class AgregamosDireccionYSocioGarante2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SocioId",
                table: "Socios");

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Dirección", "SocioGaranteId" },
                values: new object[] { "9 de julio 1232", 1 });

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Dirección", "SocioGaranteId" },
                values: new object[] { "Pedro Millán 1212", 1 });

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Dirección", "SocioGaranteId" },
                values: new object[] { "San Martin 2435", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SocioId",
                table: "Socios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Dirección", "SocioGaranteId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Dirección", "SocioGaranteId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Dirección", "SocioGaranteId" },
                values: new object[] { null, null });
        }
    }
}
