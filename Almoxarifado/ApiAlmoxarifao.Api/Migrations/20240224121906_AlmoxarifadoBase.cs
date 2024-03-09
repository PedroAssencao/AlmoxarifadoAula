using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiAlmoxarifao.Api.Migrations
{
    public partial class AlmoxarifadoBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    pro_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pro_nome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    pro_img = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    pro_estoque = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__produtos__335E4CA6D5258034", x => x.pro_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produtos");
        }
    }
}
