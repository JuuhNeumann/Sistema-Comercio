using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaComercioLibrary.Migrations
{
    public partial class itemcompra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemCompra",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Produto = table.Column<int>(nullable: false),
                    Id_Compra = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCompra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemCompra_Compra_Id_Compra",
                        column: x => x.Id_Compra,
                        principalTable: "Compra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCompra_Produto_Id_Produto",
                        column: x => x.Id_Produto,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemVenda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Venda = table.Column<int>(nullable: false),
                    Id_Produto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemVenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemVenda_Produto_Id_Produto",
                        column: x => x.Id_Produto,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemVenda_Venda_Id_Venda",
                        column: x => x.Id_Venda,
                        principalTable: "Venda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemCompra_Id_Compra",
                table: "ItemCompra",
                column: "Id_Compra");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCompra_Id_Produto",
                table: "ItemCompra",
                column: "Id_Produto");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVenda_Id_Produto",
                table: "ItemVenda",
                column: "Id_Produto");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVenda_Id_Venda",
                table: "ItemVenda",
                column: "Id_Venda");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemCompra");

            migrationBuilder.DropTable(
                name: "ItemVenda");
        }
    }
}
