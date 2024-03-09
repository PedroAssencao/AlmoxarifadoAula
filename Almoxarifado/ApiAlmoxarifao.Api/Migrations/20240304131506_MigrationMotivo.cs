using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiAlmoxarifao.Api.Migrations
{
    public partial class MigrationMotivo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__departam__BB4BD8F8CB71FE79",
                table: "departamento");

            migrationBuilder.AlterColumn<bool>(
                name: "dep_situacao",
                table: "departamento",
                type: "bit",
                nullable: true,
                defaultValueSql: "((0))",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK__departam__BB4BD8F84F7A2B81",
                table: "departamento",
                column: "dep_id");

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    fun_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fun_nome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    fun_cargo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    fun_dataNacimento = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    fun_salario = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    fun_endereco = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    fun_cidade = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    fun_uf = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Funciona__35A47928D59F69CE", x => x.fun_id);
                });

            migrationBuilder.CreateTable(
                name: "MotivoSaida",
                columns: table => new
                {
                    mot_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mot_descricao = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    cat_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MotivoSa__E0752241C9225504", x => x.mot_id);
                    table.ForeignKey(
                        name: "FK__MotivoSai__cat_i__5CD6CB2B",
                        column: x => x.cat_id,
                        principalTable: "categorias",
                        principalColumn: "cat_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MotivoSaida_cat_id",
                table: "MotivoSaida",
                column: "cat_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "MotivoSaida");

            migrationBuilder.DropPrimaryKey(
                name: "PK__departam__BB4BD8F84F7A2B81",
                table: "departamento");

            migrationBuilder.AlterColumn<bool>(
                name: "dep_situacao",
                table: "departamento",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValueSql: "((0))");

            migrationBuilder.AddPrimaryKey(
                name: "PK__departam__BB4BD8F8CB71FE79",
                table: "departamento",
                column: "dep_id");
        }
    }
}
