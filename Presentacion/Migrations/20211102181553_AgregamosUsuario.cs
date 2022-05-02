using Microsoft.EntityFrameworkCore.Migrations;

namespace Presentacion.Migrations
{
    public partial class AgregamosUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    TipoUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Nombre", "Password", "TipoUsuario", "User" },
                values: new object[] { 1, "Administrador", "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", 1, "admin" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Nombre", "Password", "TipoUsuario", "User" },
                values: new object[] { 2, "empleado", "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", 3, "empleado" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
