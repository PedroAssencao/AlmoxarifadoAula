using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiAlmoxarifao.Api.Migrations
{
    public partial class MAisATUALIZADA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__requisic__1513A6FB0831AEEC",
                table: "requisicao");

            migrationBuilder.DropColumn(
                name: "req_data",
                table: "requisicao");

            migrationBuilder.DropColumn(
                name: "req_observacao",
                table: "requisicao");

            migrationBuilder.AddColumn<DateTime>(
                name: "req_date",
                table: "requisicao",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK__requisic__1513A6FBBC4D53F0",
                table: "requisicao",
                column: "req_id");

            migrationBuilder.CreateTable(
                name: "ItemRequisicao",
                columns: table => new
                {
                    item_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    item_preco = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    item_quantidade = table.Column<int>(type: "int", nullable: true),
                    req_id = table.Column<int>(type: "int", nullable: true),
                    pro_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ItemRequ__52020FDDE8FF6C15", x => x.item_id);
                    table.ForeignKey(
                        name: "FK__ItemRequi__pro_i__0C85DE4D",
                        column: x => x.pro_id,
                        principalTable: "produtos",
                        principalColumn: "pro_id");
                    table.ForeignKey(
                        name: "FK__ItemRequi__req_i__0B91BA14",
                        column: x => x.req_id,
                        principalTable: "requisicao",
                        principalColumn: "req_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemRequisicao_pro_id",
                table: "ItemRequisicao",
                column: "pro_id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemRequisicao_req_id",
                table: "ItemRequisicao",
                column: "req_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemRequisicao");

            migrationBuilder.DropPrimaryKey(
                name: "PK__requisic__1513A6FBBC4D53F0",
                table: "requisicao");

            migrationBuilder.DropColumn(
                name: "req_date",
                table: "requisicao");

            migrationBuilder.AddColumn<string>(
                name: "req_data",
                table: "requisicao",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "req_observacao",
                table: "requisicao",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK__requisic__1513A6FB0831AEEC",
                table: "requisicao",
                column: "req_id");
        }
    }
}
