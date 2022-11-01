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
        private Compra cmp = null;

        public Frm_Compra()
        {
            serviceProd = new ProdutoService();
            service = new CompraService();
            serviceItemC = new ItemCompraService();
            InitializeComponent();
            produtos = serviceProd.GetAllProduto();
            AddComboBoxCompra();
            UpdateCompraInDataGrid();

        }

        #region ComboBox

        private void AddComboBoxCompra()
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

        private void FormattingRows(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //centraliza os dados da coluna
            dataGridViewCompra.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Valor Unitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Id Produto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Id Compra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Data"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Hora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Situacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Id Fornecedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn coluna in dataGridViewCompra.Columns)
            {
                switch (coluna.Name)
                {
                    case "Excluir":
                        //coluna.DisplayIndex = 1; se quiser mudar a posição 
                        coluna.Width = 30;
                        break;
                    case "Editar":
                        coluna.Width = 30;
                        break;
                    case "Id":
                        coluna.Width = 30;
                        break;
                    case "Quantidade":
                        coluna.Width = 45;
                        break;
                    case "Valor Unitario":
                        coluna.DefaultCellStyle.Format = "C2";
                        coluna.Width = 45;
                        break;
                    case "Total":
                        coluna.DefaultCellStyle.Format = "C2";
                        coluna.Width = 45;
                        break;
                    case "Id Produto":
                        coluna.Width = 45;
                        break;
                    case "Id Compra":
                        coluna.Width = 45;
                        break;
                    case "Data":
                        coluna.Width = 60;
                        break;
                    case "Hora":
                        coluna.Width = 60;
                        break;
                    case "Situacao":
                        coluna.Width = 60;
                        break;
                    case "Id Fornecedor":
                        coluna.Width = 45;
                        break;
                }
            }
        } //DataBindingComplete

        private void FormattingCollunms(object sender, DataGridViewCellEventArgs e)
        {

        } //CellContentClick

        private void FormatttingMensageRows(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        #endregion

        #region Click Botões Form

        private void ClickLançarCompra(object sender, EventArgs e)
        {
            //VALIDAR SE CAMPOS FORAM PREENCHIDAOS

            if (cmbQuant.SelectedIndex == -1 & cmbSelecioneProduto.SelectedIndex == -1)
            {
                MessageBox.Show("ERRO");
            }
            else
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
        }

        private void ClickCancelarCompra(object sender, EventArgs e)
        {
            lblRespostaSituacao.Text = "Cancelado";
        }

        private void ClickSair(object sender, EventArgs e)
        {
            var principal = new Frm_Principal();
            this.Hide();
        }

        private void ClickConsultar(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = String.Format("[{0}] LIKE '%{1}%'", "Nome", txtSelecioneCompra.Text);
            dataGridViewCompra.DataSource = dt;
        }

        private void ClickLimparCamposLancar(object sender, EventArgs e)
        {
            LimparCampos();
            MessageBox.Show("Campos resetados!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClickLimparCamposDel(object sender, EventArgs e)
        {
            LimparCampos();
            MessageBox.Show("Campos resetados!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Funções

        private void RemoveCompra(int id)
        {
            cmp = service.GetByIdCompra(id);
            try
            {
                service.DelCompra(cmp);
                UpdateCompraInDataGrid();
                MessageBox.Show("Produto excluido!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro ao excluir produto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void SetDadosOperacionais(Compra compra)
        {
            txtData.Text = compra.Data.ToString();
            txtHora.Text = compra.Hora.ToString();
            txtTotal.Text = "R$" + compra.Total_Compra.ToString();
            lblRespostaSituacao.Text = "Finalizado";
        }

        private void LimparCampos()
        {
            txtPreco.Clear();
            cmbQuant.SelectedIndex = -1;
            cmbSelecioneProduto.SelectedIndex = -1;
        }

        #endregion

    }
}
