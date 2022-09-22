using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaComercioLibrary.Migrations
{
    public partial class stringunidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Unidade",
                table: "Produto",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Unidade",
                table: "Produto",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
