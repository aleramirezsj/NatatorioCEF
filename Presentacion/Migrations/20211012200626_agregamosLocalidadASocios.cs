using Microsoft.EntityFrameworkCore.Migrations;

namespace Presentacion.Migrations
{
    public partial class agregamosLocalidadASocios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocalidadId",
                table: "Socios",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Localidades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidades", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Localidades",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "San Justo" },
                    { 2, "Gobernador Crespo" },
                    { 3, "Llambi Campbell" },
                    { 4, "Ramayón" }
                });

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocalidadId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "Id",
                keyValue: 2,
                column: "LocalidadId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "Id",
                keyValue: 3,
                column: "LocalidadId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Socios_LocalidadId",
                table: "Socios",
                column: "LocalidadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Socios_Localidades_LocalidadId",
                table: "Socios",
                column: "LocalidadId",
                principalTable: "Localidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socios_Localidades_LocalidadId",
                table: "Socios");

            migrationBuilder.DropTable(
                name: "Localidades");

            migrationBuilder.DropIndex(
                name: "IX_Socios_LocalidadId",
                table: "Socios");

            migrationBuilder.DropColumn(
                name: "LocalidadId",
                table: "Socios");
        }
    }
}
