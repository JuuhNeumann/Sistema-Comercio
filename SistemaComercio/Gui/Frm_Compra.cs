using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Entity;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaComercio.Gui
{
    public partial class Frm_Compra : Form
    {
        private IProdutoPort serviceProd;
        private ICompraPort service;
        private IItemCompraPort serviceItemC;
        private List<Produto> produtos;
        private Produto produto;
        private DataTable dt = new DataTable();

        public Frm_Compra()
        {
            serviceProd = new ProdutoService();
            service = new CompraService();
            serviceItemC = new ItemCompraService();
            InitializeComponent();
            produtos = serviceProd.GetAllProduto();
            AddComboBoxProduto();
            UpdateCompraInDataGrid();

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
            cmbQuant.Items.Clear();

            produto = produtos.FirstOrDefault(produtos => produtos.Nome.Equals(cmbSelecioneProduto.Text));
            txtPreco.Text = "R$ " + produto.Preco.ToString();

            for (int i = 1; i <= produto.Quantidade_Estoque; i++)
            {
                this.cmbQuant.Items.AddRange(new object[] {
                i.ToString()
                });
            }
        }


        void SetDadosOperacionais(Compra compra)
        {
            txtData.Text = compra.Data.ToString();
            txtHora.Text = compra.Hora.ToString();
            txtTotal.Text = "R$" + compra.Total_Compra.ToString();
            lblRespostaSituacao.Text = "Finalizado";
        }


        #region Click Botões

        private void ClickLançarCompra(object sender, EventArgs e)
        {
            var compra = new Compra()
            {
                Situacao_Compra = lblRespostaSituacao.Text,
                Total_Compra = produto.Preco * Convert.ToInt32(cmbQuant.Text),
                Data = DateTime.UtcNow.Date,
                Hora = DateTime.Now.ToString("HH:mm:ss"),
                Id_Fornecedor = produto.Id_Fornecedor,
            };


            var itemCompra = new ItemCompra()
            {
                Compra = compra,
                Id_Produto = produto.Id,
                Quantidade = Convert.ToInt32(cmbQuant.Text),
                Total_Item = compra.Total_Compra,
                Valor_Unitario = produto.Preco,
            };

            serviceItemC.AddItemCompra(itemCompra);
            SetDadosOperacionais(compra);
        }

        private void ClickCancelarCompra(object sender, EventArgs e)
        {
            lblRespostaSituacao.Text = "Cancelado";
        }

        #endregion

        #region DataGridView

        private void UpdateCompraInDataGrid()
        {
            dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Quantidade", typeof(string));
            dt.Columns.Add("Valor Unitario", typeof(string));
            dt.Columns.Add("Total", typeof(string));
            dt.Columns.Add("Id Produto", typeof(string));
            dt.Columns.Add("Id Compra", typeof(string));
            dt.Columns.Add("Data", typeof(string));
            dt.Columns.Add("Hora", typeof(string));
            dt.Columns.Add("Situacao", typeof(string));
            dt.Columns.Add("Id Fornecedor", typeof(string));

            var itemCompras = serviceItemC.GetAllItemCompra();

            foreach (var itemCompra in itemCompras)
            {
                dt.Rows.Add(new object[]
                {
                    itemCompra.Id,
                    itemCompra.Quantidade,
                    itemCompra.Valor_Unitario,
                    itemCompra.Total_Item,
                    itemCompra.Id_Produto,
                    itemCompra.Id_Compra,
                    itemCompra.Compra.Data,
                    itemCompra.Compra.Hora,
                    itemCompra.Compra.Situacao_Compra,
                    itemCompra.Compra.Id_Fornecedor
                });
            }
            dataGridViewCompra.DataSource = dt;
        }

        #endregion

    }
}
