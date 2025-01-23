using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiGestionDashboard.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    dni = table.Column<int>(type: "int", nullable: false),
                    rol_empleado = table.Column<int>(type: "int", nullable: false),
                    clave = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    usuario_email = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "id", "clave", "dni", "usuario_email", "nombre", "rol_empleado" },
                values: new object[] { 1, "588acee9920f023bfe4b60ff2def822ee7612d12f620db6677d637e799315884", 12345678, "matias@hotmail.com.ar", "Matias", 0 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "id", "clave", "dni", "usuario_email", "nombre", "rol_empleado" },
                values: new object[] { 2, "5798325bcbffca1fcd3fa2f03e1c0aeb0fce43443425a2696fd637c7135b10f4", 21456789, "jose@gmail.com.ar", "Jose", 0 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "id", "clave", "dni", "usuario_email", "nombre", "rol_empleado" },
                values: new object[] { 3, "e5dfcfbaaa1b861a1b813d4921a5417f5af017bec697ddf14d13a698b8f04cde", 30145741, "martin@gmail.com.ar", "Martin", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
