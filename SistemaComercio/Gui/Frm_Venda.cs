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
    public partial class Frm_Venda : Form
    {
        private List<ItemCompra> itemCompras;
        private List<ItemVenda> itemVendas;
        private IVendaPort service;
        private IItemCompraPort serviceItemC;
        private IItemVendaPort serviceItemV;
        private DataTable dt = new DataTable();
        private string columnFilter;
        private Venda vnd = null;

        public Frm_Venda()
        {
            InitializeComponent();
            UpdateVendaInDataGrid();
        }


        #region ComboBox

        private void AddComboBoxVenda()
        {
            this.cmbSelecioneProduto.Items.Clear();

            List<string> produtos = new List<string>();

            itemCompras.ToList().ForEach(x => produtos.Add(x.Produto.Nome));

            foreach (var produto in produtos.Distinct())
            {
                this.cmbSelecioneProduto.Items.AddRange(new object[] {
                produto
                });
            }
        }

        private void AddComboBoxCancelarVenda()
        {
            this.cmbSelecioneCancelamento.Items.Clear();

            foreach (var itemVenda in itemVendas)
            {
                if (itemVenda.Venda.Situacao_Venda != "Cancelado")
                {
                    this.cmbSelecioneCancelamento.Items.AddRange(new object[] {
                    itemVenda.Id.ToString()
                });

                }
            }
        }

        #endregion


        #region DataGridView

        public void UpdateComboBox()
        {
            AddComboBoxVenda();
            AddComboBoxCancelarVenda();
        }

        private void UpdateVendaInDataGrid()
        {
            service = new VendaService();
            serviceItemC = new ItemCompraService();
            serviceItemV = new ItemVendaService();


            dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Quantidade", typeof(string));
            dt.Columns.Add("Valor Unitario", typeof(string));
            dt.Columns.Add("Total", typeof(string));
            //dt.Columns.Add("Id Produto", typeof(string)); //referente ao itemCompra
            //dt.Columns.Add("Produto", typeof(string));  //referente ao itemCompra
            dt.Columns.Add("Id Venda", typeof(string));
            dt.Columns.Add("Data", typeof(string));
            dt.Columns.Add("Hora", typeof(string));
            dt.Columns.Add("Situacao", typeof(string));
            dt.Columns.Add("Id Cliente", typeof(string));
            dt.Columns.Add("Cliente", typeof(string));

            itemVendas = serviceItemV.GetAllItemVenda();

            foreach (var itemVenda in itemVendas)
            {
                dt.Rows.Add(new object[]
                {
                    itemVenda.Id,
                    itemVenda.Quantidade,
                    itemVenda.Valor_Unitario,
                    itemVenda.Total_Item,
                    //itemVenda.Id_Produto, //id de produto ou id de itemcompra?
                    //itemVenda.Produto.Nome, //nome de produto ou nome de itemcompra?
                    itemVenda.Id_Venda,
                    itemVenda.Venda.Data,
                    itemVenda.Venda.Hora,
                    itemVenda.Venda.Situacao_Venda,
                    itemVenda.Venda.Id_Cliente,
                    itemVenda.Venda.Cliente.Nome

                });
            }

            dataGridViewVenda.DataSource = dt;
            itemCompras = serviceItemC.GetAllItemCompra();

            UpdateComboBox();
        }

        private void FormattingRows(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //centraliza os dados da coluna
            dataGridViewVenda.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Valor Unitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewVenda.Columns["Id Produto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewVenda.Columns["Produto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Id Venda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Data"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Hora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Situacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Id Cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn coluna in dataGridViewVenda.Columns)
            {
                switch (coluna.Name)
                {
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
                    /*case "Id Produto":
                        coluna.Width = 45;
                        break;
                    case "Produto":
                        coluna.Width = 115;
                        break;*/
                    case "Id Venda":
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
                    case "Id Cliente":
                        coluna.Width = 45;
                        break;
                    case "Cliente":
                        coluna.DisplayIndex = 1;
                        coluna.Width = 60;
                        break;
                }
            }
        }  //DataBindingComplete


        #endregion


        #region Click Botões Form

        private void ClickEmitirRelatorio(object sender, EventArgs e)
        {
            Frm_RelatorioVenda relatorioV = new Frm_RelatorioVenda();
            relatorioV.Show();
        }

        private void ClickSair(object sender, EventArgs e)
        {
            var principal = new Frm_Principal();
            this.Hide();
        }

        private void ClickConsultar(object sender, EventArgs e)
        {
            PesquisaVendaFiltro();
        }

        private void ClickLimparCamposLancar(object sender, EventArgs e)
        {
            LimparCampos();
            MessageBox.Show("Campos resetados!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClickLimparCamposCancel(object sender, EventArgs e)
        {
            LimparCampos();
            MessageBox.Show("Campos resetados!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        #endregion


        #region Funções

        private void PesquisaVendaFiltro()
        {
            dt.DefaultView.RowFilter = String.Format("[{0}] LIKE '%{1}%'", columnFilter, txtPreco.Text);
            dataGridViewVenda.DataSource = dt;
        }

        private void LimparCampos()
        {
            txtPreco.Clear();
            txtTotalCima.Clear();
            cmbQuantidade.SelectedIndex = -1;
            cmbSelecioneProduto.SelectedIndex = -1;
            cmbQuantiCancelar.SelectedIndex = -1;
            cmbSelecioneCancelamento.SelectedIndex = -1;
            txtPrecoCancel.Clear();
            txtTotalCimaCancel.Clear();
        }

        private void RemoveVenda(int id)
        {
            vnd = service.GetByIdVenda(id);
            try
            {
                service.DelVenda(vnd);
                UpdateVendaInDataGrid();
                MessageBox.Show("Produto excluido!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro ao excluir produto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

    }
}
