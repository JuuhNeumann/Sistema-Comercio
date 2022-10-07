using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaComercioLibrary.Migrations
{
    public partial class bancoreset2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Fornecedor",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Numero",
                table: "Fornecedor",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
