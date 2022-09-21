using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaComercioLibrary.Migrations
{
    public partial class todasmenoscompra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caixa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    Saldo = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caixa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    Cpf_Cnpj = table.Column<string>(nullable: false),
                    Logradouro = table.Column<string>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(nullable: false),
                    Bairro = table.Column<string>(nullable: false),
                    Cidade = table.Column<string>(nullable: false),
                    Estado = table.Column<string>(nullable: false),
                    Cep = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(nullable: false),
                    Hora = table.Column<DateTime>(nullable: false),
                    Total_Compra = table.Column<double>(nullable: false),
                    Situacao_Compra = table.Column<string>(nullable: false),
                    Id_Fornecedor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compra_Fornecedor_Id_Fornecedor",
                        column: x => x.Id_Fornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContaPagar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(nullable: false),
                    Data_Lancamento = table.Column<DateTime>(nullable: false),
                    Data_Vencimento = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    Pago = table.Column<double>(nullable: false),
                    Data_Pagamento = table.Column<DateTime>(nullable: false),
                    Valor_Pagamento = table.Column<double>(nullable: false),
                    Id_Fornecedor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaPagar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContaPagar_Fornecedor_Id_Fornecedor",
                        column: x => x.Id_Fornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormaPagamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovimentoCaixa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_Movimento = table.Column<DateTime>(nullable: false),
                    Hora_Movimento = table.Column<DateTime>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Tipo_Movimento = table.Column<string>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    Id_Caixa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimentoCaixa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovimentoCaixa_Caixa_Id_Caixa",
                        column: x => x.Id_Caixa,
                        principalTable: "Caixa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContaReceber",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(nullable: false),
                    Data_Lancamento = table.Column<DateTime>(nullable: false),
                    Data_Vencimento = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    Recebido = table.Column<double>(nullable: false),
                    Data_Recebimento = table.Column<DateTime>(nullable: false),
                    Valor_Recebimento = table.Column<double>(nullable: false),
                    Id_Cliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaReceber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContaReceber_Cliente_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(nullable: false),
                    Hora = table.Column<DateTime>(nullable: false),
                    Total_Venda = table.Column<double>(nullable: false),
                    Situacao_Venda = table.Column<string>(nullable: false),
                    Id_Cliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Venda_Cliente_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormaPagamentoVenda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Venda = table.Column<int>(nullable: false),
                    Id_FormaPagamento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagamentoVenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormaPagamentoVenda_FormaPagamento_Id_FormaPagamento",
                        column: x => x.Id_FormaPagamento,
                        principalTable: "FormaPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormaPagamentoVenda_Venda_Id_Venda",
                        column: x => x.Id_Venda,
                        principalTable: "Venda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compra_Id_Fornecedor",
                table: "Compra",
                column: "Id_Fornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_ContaPagar_Id_Fornecedor",
                table: "ContaPagar",
                column: "Id_Fornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_ContaReceber_Id_Cliente",
                table: "ContaReceber",
                column: "Id_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_FormaPagamentoVenda_Id_FormaPagamento",
                table: "FormaPagamentoVenda",
                column: "Id_FormaPagamento");

            migrationBuilder.CreateIndex(
                name: "IX_FormaPagamentoVenda_Id_Venda",
                table: "FormaPagamentoVenda",
                column: "Id_Venda");

            migrationBuilder.CreateIndex(
                name: "IX_MovimentoCaixa_Id_Caixa",
                table: "MovimentoCaixa",
                column: "Id_Caixa");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_Id_Cliente",
                table: "Venda",
                column: "Id_Cliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "ContaPagar");

            migrationBuilder.DropTable(
                name: "ContaReceber");

            migrationBuilder.DropTable(
                name: "FormaPagamentoVenda");

            migrationBuilder.DropTable(
                name: "MovimentoCaixa");

            migrationBuilder.DropTable(
                name: "FormaPagamento");

            migrationBuilder.DropTable(
                name: "Venda");

            migrationBuilder.DropTable(
                name: "Caixa");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
