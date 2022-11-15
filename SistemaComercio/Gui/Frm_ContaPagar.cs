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
    public partial class Frm_ContaPagar : Form
    {
        private IContaPagarPort service;
        private IItemCompraPort serviceItemC;
        private ICompraPort serviceC;
        private DataTable dt = new DataTable();
        private Compra cmp = null;
        private string columnFilter;
        private List<ItemCompra> itemCompras;
        private ItemCompra itemCompra;
        private List<Compra> compras;
        private Compra compra;

        private string metodoPagamento;

        public Frm_ContaPagar()
        {
            InitializeComponent();
            UpdateCompra();
        }

        private void UpdateCompra()
        {
            serviceC = new CompraService();
            service = new ContaPagarService();

            compras = serviceC.GetAllCompra();

            AddComboBoxContaPagar();
        }

        #region ComboBox

        private void AddComboBoxContaPagar()
        {
            this.cmbSelecioneCompra.Items.Clear();

            foreach (var compra in compras)
            {
                if (compra.Situacao_Compra != "Pago")
                {
                    this.cmbSelecioneCompra.Items.AddRange(new object[] {
                compra.Id.ToString()
                });
                }
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
            txtDataPaga.Text = DateTime.Now.ToString();

        }

        private void LimparCampos()
        {
            cmbSelecioneCompra.SelectedIndex = -1;
            txtFornecedor.Clear();
            txtDescricao.Clear();
            txtDataLanca.Clear();
            txtDataVenci.Clear();
            txtDataPaga.Clear();
            txtValorPaga.Clear();
            txtValor.Clear();
            txtPago.Clear();
            cmbParcelamento.SelectedIndex = -1;
            cmbParcelamento.Enabled = false;
            gpbFormaPagamento.Enabled = false;

        }

        #endregion

        private void cmbSelecioneCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelecioneCompra.SelectedIndex != -1)
            {
                var idCompra = Convert.ToInt32(cmbSelecioneCompra.Text);
                compra = serviceC.GetByIdCompra(idCompra);
                SetGeracaoContaPagar();
                gpbFormaPagamento.Enabled = true;
            }

        }


        private void SetGeracaoContaPagar()
        {
            txtDescricao.Text = compra.Fornecedor.Produto.First().Nome;
            txtFornecedor.Text = compra.Fornecedor.Nome;
            txtDataLanca.Text = compra.Data;
            txtDataVenci.Text = Convert.ToDateTime(compra.Data).AddMonths(1).ToString("dd-MM-yyyy");
            txtValor.Text = compra.Total_Compra.ToString();
        }

        private void rdbPix_CheckedChanged(object sender, EventArgs e)
        {
            metodoPagamento = "Pix";
            cmbParcelamento.Enabled = false;
        }

        private void rdbCartaoDebito_CheckedChanged(object sender, EventArgs e)
        {
            metodoPagamento = "debito";
            cmbParcelamento.Enabled = false;
        }

        private void rdbCartaoCredito_CheckedChanged(object sender, EventArgs e)
        {
            metodoPagamento = "credito";

            if (cmbSelecioneCompra.SelectedIndex != -1)
            {
                cmbParcelamento.Enabled = true;

                for (int i = 1; i < 10; i++)
                {
                    this.cmbParcelamento.Items.AddRange(new object[] {
                     $"{i}x de {compra.Total_Compra / i} sem juros."
                });
                }

            }
        }

        private void rdbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            metodoPagamento = "dinheiro";
            cmbParcelamento.Enabled = false;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (compra.Total_Compra == Convert.ToDouble(txtValorPaga.Text) && cmbSelecioneCompra.SelectedIndex != -1)
                {
                    CreateContaPagar();
                    LimparCampos();
                    UpdateCompra();
                    MessageBox.Show("Venda Lançada!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Informe o valor total!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao lançar venda!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateContaPagar()
        {
            var dataLanca = Convert.ToDateTime(txtDataLanca.Text).ToString("dd-MM-yyyy");
            var dataVenci = Convert.ToDateTime(txtDataVenci.Text).ToString("dd-MM-yyyy");
            var parcela = 0;

            if (metodoPagamento.Equals("credito"))
                parcela = Convert.ToInt32(cmbParcelamento.Text.Substring(0, 1));

            var contaPagar = new ContaPagar()
            {
                Descricao = txtDescricao.Text,
                Data_Lancamento = Convert.ToDateTime(dataLanca),
                Data_Vencimento = Convert.ToDateTime(dataVenci),
                Valor = Convert.ToDouble(txtValor.Text),
                Pago = Convert.ToDouble(txtValorPaga.Text),
                Data_Pagamento = DateTime.Now,
                Valor_Pagamento = Convert.ToDouble(txtValorPaga.Text),
                Id_Fornecedor = compra.Id_Fornecedor,
            };

            compra.Situacao_Compra = "Pago";

            serviceC.UpdateCompra(compra);
            service.AddContaPagar(contaPagar);

        }

        private void cmbParcelamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbParcelamento.SelectedIndex != -1)
            {


            }
        }
    }
}

