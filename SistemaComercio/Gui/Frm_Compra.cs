using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Entity;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaComercio.Gui
{
    public partial class Frm_Compra : Form
    {
        private IProdutoPort serviceProd;
        private ICompraPort service;
        private List<Produto> produtos;
        private Produto produto;

        public Frm_Compra()
        {
            serviceProd = new ProdutoService();
            service = new CompraService();
            InitializeComponent();
            produtos = serviceProd.GetAllProduto();
            dataGridViewCompra.DataSource = service.GetAllCompra();
            AddComboBoxProduto();

        }

        private void AddComboBoxProduto()
        {
            foreach (var produto in produtos)
            {
                this.cmbSelecioneProduto.Items.AddRange(new object[] {
                produto.Nome.ToString()
                });
            }
        }

        private void cmbSelecioneProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            produto = produtos.FirstOrDefault(produtos => produtos.Nome.Equals(cmbSelecioneProduto.Text));
            txtPreco.Text = "R$ " + produto.Preco.ToString();

            for (int i = 1; i <= produto.Quantidade_Estoque; i++)
            {
                this.cmbQuant.Items.AddRange(new object[] {
                i.ToString()
                });
            }
        }

        private void ClickLançarCompra(object sender, EventArgs e)
        {
            var compra = new Compra()
            {
                Situacao_Compra = lblRespostaSituacao.Text,
                Total_Compra = produto.Preco*Convert.ToInt32(cmbQuant.Text),
                Data = DateTime.UtcNow.Date,
                Hora = DateTime.Now.ToString("HH:mm:ss"),
                Id_Fornecedor = produto.Id_Fornecedor,
            };

            var itemCompra = new ItemCompra()
            {
                Compra = compra,
                Id_Compra = 1,
                Id_Produto = produto.Id,
            };


            txtData.Text = compra.Data.ToString();
            txtHora.Text = compra.Hora.ToString();
            txtTotal.Text = "R$" + compra.Total_Compra.ToString();

            service.AddCompra(compra);
            lblRespostaSituacao.Text = "Finalizado";
            
        }

        private void ClickCancelarCompra(object sender, EventArgs e)
        {
            lblRespostaSituacao.Text = "Cancelado";
        }


    }
}
