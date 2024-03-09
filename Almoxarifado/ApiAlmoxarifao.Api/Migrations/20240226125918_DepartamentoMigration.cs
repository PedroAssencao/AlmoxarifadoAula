using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiAlmoxarifao.Api.Migrations
{
    public partial class DepartamentoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cat_id",
                table: "produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "departamento",
                columns: table => new
                {
                    dep_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dep_descricao = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    dep_situacao = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__departam__BB4BD8F8CB71FE79", x => x.dep_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_produtos_cat_id",
                table: "produtos",
                column: "cat_id");

            migrationBuilder.AddForeignKey(
                name: "FK__produtos__cat_id__3A81B327",
                table: "produtos",
                column: "cat_id",
                principalTable: "categorias",
                principalColumn: "cat_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__produtos__cat_id__3A81B327",
                table: "produtos");

            migrationBuilder.DropTable(
                name: "departamento");

            migrationBuilder.DropIndex(
                name: "IX_produtos_cat_id",
                table: "produtos");

            migrationBuilder.DropColumn(
                name: "cat_id",
                table: "produtos");
        }
    }
}
