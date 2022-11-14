using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Entity;
using SistemaComercioLibrary.Port;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SistemaComercio.Gui
{
    public partial class Frm_ContaPagar : Form
    {
        private IContaPagarPort service;
        private IItemCompraPort serviceItemC;
        private DataTable dt = new DataTable();
        private Compra cmp = null;
        private string columnFilter;
        private List<ItemCompra> itemCompras;
        private ItemCompra itemCompra;
        private List<Produto> compras;


        public Frm_ContaPagar()
        {
            InitializeComponent();
        }


        #region ComboBox

        private void AddComboBoxContaPagar()
        {
            this.cmbSelecioneCompra.Items.Clear();

            foreach (var compra in compras)
            {
                this.cmbSelecioneCompra.Items.AddRange(new object[] {
                compra.Nome.ToString()
                });
            }
        }

        #endregion

        #region Click Botões Form


        private void ClickSair(object sender, EventArgs e)
        {
            var principal = new Frm_Principal();
            this.Hide();
        }

        private void ClickEmitirRelatorio(object sender, EventArgs e)
        {
            Frm_RelatorioContaPagar relatorioCP = new Frm_RelatorioContaPagar();
            relatorioCP.Show();
        }

        private void ClickLimparCampos(object sender, EventArgs e)
        {
            LimparCampos();
            MessageBox.Show("Campos resetados!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        #endregion

        #region Funções

        void SetDadosOperacionais(Compra compra)
        {
            /*txtData.Text = compra.Data.ToString();
            txtHora.Text = compra.Hora.ToString();
            txtTotal.Text = "R$" + compra.Total_Compra.ToString();
            lblRespostaSituacao.Text = "Finalizado";*/
        }

        private void LimparCampos()
        {
            cmbSelecioneCompra.SelectedIndex = -1;
            cmbSelecioneForne.SelectedIndex = -1;
            txtDescricao.Clear();
            txtDataLanca.Clear();
            txtDataFecha.Clear();
            txtDataPaga.Clear();
            txtValorPaga.Clear();
            txtValor.Clear();
            txtPago.Clear();
            txtTotal.Clear();
            cmbParcelamento.SelectedIndex = -1;

        }

        #endregion

    }
}

