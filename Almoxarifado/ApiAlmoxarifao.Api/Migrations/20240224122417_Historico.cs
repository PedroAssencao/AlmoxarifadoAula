using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiAlmoxarifao.Api.Migrations
{
    public partial class Historico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Historico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    ProdutoNavigationProId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historico_produtos_ProdutoNavigationProId",
                        column: x => x.ProdutoNavigationProId,
                        principalTable: "produtos",
                        principalColumn: "pro_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Historico_ProdutoNavigationProId",
                table: "Historico",
                column: "ProdutoNavigationProId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Historico");
        }
    }
}
