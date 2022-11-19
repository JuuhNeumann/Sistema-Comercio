﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SistemaComercioLibrary.Persistence.Context;

namespace SistemaComercioLibrary.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20221119180905_add")]
    partial class add
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SistemaComercioBiblioteca.Classes.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Id_Fornecedor")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Preco")
                        .HasColumnType("double precision");

                    b.Property<int>("Quantidade_Estoque")
                        .HasColumnType("integer");

                    b.Property<string>("Unidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id_Fornecedor");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Caixa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Saldo")
                        .HasColumnType("double precision");

                    b.Property<double>("SaldoAnterior")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Caixa");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cpf_Cnpj")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Numero")
                        .HasColumnType("integer");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Hora")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Id_Fornecedor")
                        .HasColumnType("integer");

                    b.Property<string>("Situacao_Compra")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Total_Compra")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("Id_Fornecedor");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.ContaPagar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Data_Lancamento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Data_Pagamento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Data_Vencimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FormaPagamento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Id_Fornecedor")
                        .HasColumnType("integer");

                    b.Property<double>("Pago")
                        .HasColumnType("double precision");

                    b.Property<int>("Parcela")
                        .HasColumnType("integer");

                    b.Property<double>("Valor")
                        .HasColumnType("double precision");

                    b.Property<double>("Valor_Pagamento")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("Id_Fornecedor");

                    b.ToTable("ContaPagar");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.ContaReceber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Data_Lancamento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Data_Recebimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Data_Vencimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FormaPagamento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Id_Cliente")
                        .HasColumnType("integer");

                    b.Property<int>("Parcela")
                        .HasColumnType("integer");

                    b.Property<double>("Recebido")
                        .HasColumnType("double precision");

                    b.Property<double>("Valor")
                        .HasColumnType("double precision");

                    b.Property<double>("Valor_Recebimento")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("Id_Cliente");

                    b.ToTable("ContaReceber");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.FormaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Parcela")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("FormaPagamento");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cpf_Cnpj")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.MovimentoCaixa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Data_Movimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Hora_Movimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Id_Caixa")
                        .HasColumnType("integer");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer");

                    b.Property<string>("Tipo_Movimento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Valor")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("Id_Caixa");

                    b.ToTable("MovimentoCaixa");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Hora")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Id_Cliente")
                        .HasColumnType("integer");

                    b.Property<string>("Situacao_Venda")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Total_Venda")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("Id_Cliente");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.Adm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Salario")
                        .HasColumnType("double precision");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Adm");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.FormaPagamentoVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Id_FormaPagamento")
                        .HasColumnType("integer");

                    b.Property<int>("Id_Venda")
                        .HasColumnType("integer");

                    b.Property<double>("Valor")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("Id_FormaPagamento");

                    b.HasIndex("Id_Venda");

                    b.ToTable("FormaPagamentoVenda");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.ItemCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Id_Compra")
                        .HasColumnType("integer");

                    b.Property<int>("Id_Produto")
                        .HasColumnType("integer");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer");

                    b.Property<double>("Total_Item")
                        .HasColumnType("double precision");

                    b.Property<double>("Valor_Unitario")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("Id_Compra");

                    b.HasIndex("Id_Produto");

                    b.ToTable("ItemCompra");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.ItemVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Id_Produto")
                        .HasColumnType("integer");

                    b.Property<int>("Id_Venda")
                        .HasColumnType("integer");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer");

                    b.Property<double>("Total_Item")
                        .HasColumnType("double precision");

                    b.Property<double>("Valor_Unitario")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("Id_Produto");

                    b.HasIndex("Id_Venda");

                    b.ToTable("ItemVenda");
                });

            modelBuilder.Entity("SistemaComercioBiblioteca.Classes.Produto", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Fornecedor", "Fornecedor")
                        .WithMany("Produto")
                        .HasForeignKey("Id_Fornecedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Compra", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Fornecedor", "Fornecedor")
                        .WithMany("Compra")
                        .HasForeignKey("Id_Fornecedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.ContaPagar", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Fornecedor", "Fornecedor")
                        .WithMany("ContaPagar")
                        .HasForeignKey("Id_Fornecedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.ContaReceber", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Cliente", "Cliente")
                        .WithMany("ContaReceber")
                        .HasForeignKey("Id_Cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.MovimentoCaixa", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Caixa", "Caixa")
                        .WithMany("MovimentoCaixa")
                        .HasForeignKey("Id_Caixa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Venda", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Cliente", "Cliente")
                        .WithMany("Venda")
                        .HasForeignKey("Id_Cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.FormaPagamentoVenda", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.FormaPagamento", "FormaPagamento")
                        .WithMany("FormaPagamentoVenda")
                        .HasForeignKey("Id_FormaPagamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaComercioLibrary.Classes.Venda", "Venda")
                        .WithMany("FormaPagamentoVenda")
                        .HasForeignKey("Id_Venda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.ItemCompra", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Compra", "Compra")
                        .WithMany("ItemCompra")
                        .HasForeignKey("Id_Compra")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaComercioBiblioteca.Classes.Produto", "Produto")
                        .WithMany("ItemCompra")
                        .HasForeignKey("Id_Produto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.ItemVenda", b =>
                {
                    b.HasOne("SistemaComercioBiblioteca.Classes.Produto", "Produto")
                        .WithMany("ItemVenda")
                        .HasForeignKey("Id_Produto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaComercioLibrary.Classes.Venda", "Venda")
                        .WithMany("ItemVenda")
                        .HasForeignKey("Id_Venda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
