using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiAlmoxarifao.Api.Migrations
{
    public partial class RequisicaoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "requisicao",
                columns: table => new
                {
                    req_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    req_data = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    req_observacao = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__requisic__1513A6FB0831AEEC", x => x.req_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "requisicao");
        }
    }
}
