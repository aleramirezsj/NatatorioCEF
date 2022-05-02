using Microsoft.EntityFrameworkCore.Migrations;

namespace Presentacion.Migrations
{
    public partial class AgregamosDatosSemilla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cobradores",
                columns: new[] { "Id", "Apellido", "Nombre" },
                values: new object[,]
                {
                    { 1, "Fernandez", "José" },
                    { 2, "Gonzalez", "Gustavo" }
                });

            migrationBuilder.InsertData(
                table: "Socios",
                columns: new[] { "Id", "Apellido", "DNI", "Nombre", "Teléfono" },
                values: new object[,]
                {
                    { 1, "Perez", 12121212, "Juan", "34343434" },
                    { 2, "Gomez", 12787878, "Adrian", "98989898" },
                    { 3, "Rodriguez", 56565656, "Pedro", "45454545" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cobradores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cobradores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Socios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Socios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Socios",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
