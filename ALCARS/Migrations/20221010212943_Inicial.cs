using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ALCARS.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "alugado",
                table: "carro",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "CarroAlugado",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteid = table.Column<int>(type: "int", nullable: false),
                    idCliente = table.Column<int>(type: "int", nullable: false),
                    carroid = table.Column<int>(type: "int", nullable: false),
                    idCarro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarroAlugado", x => x.id);
                    table.ForeignKey(
                        name: "FK_CarroAlugado_carro_carroid",
                        column: x => x.carroid,
                        principalTable: "carro",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarroAlugado_clientes_clienteid",
                        column: x => x.clienteid,
                        principalTable: "clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarroAlugado_carroid",
                table: "CarroAlugado",
                column: "carroid");

            migrationBuilder.CreateIndex(
                name: "IX_CarroAlugado_clienteid",
                table: "CarroAlugado",
                column: "clienteid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarroAlugado");

            migrationBuilder.DropColumn(
                name: "alugado",
                table: "carro");
        }
    }
}
