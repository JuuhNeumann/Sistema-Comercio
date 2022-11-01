using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Entity;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComercio.Gui
{
    public partial class Frm_Venda2 : Form
    {
        private List<ItemVenda> Lista = new List<ItemVenda>();
        private Venda venda = new Venda();
        private FormaPagamentoVenda formapagamento = new FormaPagamentoVenda();
        private Produto p = new Produto();
        private Cliente c = new Cliente();
        private double subtotal = 0;
        private int numeroItem;
        private int numeroVenda;
        private int maiorId;

        private IClientePort cp = new ClienteService();
        private IProdutoPort pp = new ProdutoService();
        private IVendaPort vp = new VendaService();
        private IItemVendaPort iiv = new ItemVendaService();
        private enum Pagamento
        {
            Dinheiro,
            Credito,
            Debito,
            Boleto
        }
        private bool selecionado;
        public const String CLIENTE = "Cliente";
        public const String PRODUTO = "Produtos";
        public Frm_Venda2()
        {
            InitializeComponent();
            SetCliente("0");

            SetNumeroVenda();
            LimparTexto();
            GetMaxIdProduto();
        }
        public void Selecionado(bool v)
        {
            selecionado = v;
        }

        public void SetProduto(Produto produto)
        {
            p = produto;
        }

        public void SetCliente(Cliente cliente)
        {
            c = cliente;
        }

        public void SetCliente(String id)
        {

            c = cp.GetByIdCliente(int.Parse(id));

        }

        private void GetMaxIdProduto()
        {
            maiorId = pp.Count();
        }

        private void SetTexto()
        {
            LbNome.Text = p.Nome.ToString();
            BxPreco.Text = p.Preco.ToString();


            AtualizarTotal();
        }

        private void SetNumeroVenda()
        {
            numeroVenda = vp.Count() + 1;
            LbVenda.Text = "Venda Número: " + numeroVenda.ToString();
        }

        private void SetTextoCliente()
        {
            LbCliente.Text = c.Nome;
            BxCliente.Text = " ";
            // LbCliente.Text = "novo cliente";
        }

        private void LimparTexto()
        {
            LbNome.Text = "";
            BxPreco.Text = "1";
            BxQuantidade.Text = "1";
            BxTotal.Text = "";
            BxProcurar.Text = " ";

        }

        private void AtualizarTotal()
        {
            int qtd = int.Parse(BxQuantidade.Value.ToString());
            double preco = Double.Parse(BxPreco.Text);
            double total = qtd * preco;
            BxTotal.Text = total.ToString();
        }

        private void AtualizaTabela(ItemVenda iv)
        {
            
            String[] row = {/* iv.numeroitem.ToString()*/ p.Id.ToString(), p.Nome, iv.Quantidade.ToString(),
                             iv.Valor_Unitario.ToString(), iv.Total_Item.ToString() };
            DataGridItemVenda.Rows.Add(row);
        }

        private bool ChecarPagamento()
        {
            if (RbDinheiro.Checked)
            {
                formapagamento.Id_FormaPagamento = ((int)Pagamento.Dinheiro);
                return true;
            }
            if (RbCredito.Checked)
            {
                formapagamento.Id_FormaPagamento = ((int)Pagamento.Credito);
                return true;
            }
            if (RbDebito.Checked)
            {
                formapagamento.Id_FormaPagamento = ((int)Pagamento.Debito);
                return true;
            }
            if (RbBoleto.Checked)
            {

                formapagamento.Id_FormaPagamento = ((int)Pagamento.Boleto);
                return true;
            }
            return false;
        }


        private ContaReceber PreencherContaReceber(DateTime thisDay)
        {
            ContaReceber conta = new ContaReceber();
            conta.Id = venda.Id;
            conta.Id_Cliente = venda.Id_Cliente;
            conta.Data_Lancamento = thisDay;
            conta.Data_Vencimento = thisDay.AddDays(7);
            conta.Valor = venda.Total_Venda;
            // conta.Recebido = "NAO";
            return conta;
        }

        private void PreencherVenda()
        {
            DateTime thisDay = DateTime.Now;
            ContaReceber conta = new ContaReceber();

            venda.Id = numeroVenda;
            venda.Data = DateTime.UtcNow.Date;
            venda.Hora = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"));
            venda.Id_Cliente = c.Id;
            venda.Total_Venda = subtotal;
            venda.Situacao_Venda = "ATIVA";
            venda.ItemVenda = Lista;
            formapagamento.Id_Venda = numeroVenda;
            formapagamento.Valor = subtotal;
            conta = PreencherContaReceber(thisDay);
        }

        private void BtSelecionarCliente_Click(object sender, EventArgs e)
        {
            selecionado = false;
            Frm_Procurar janela = new Frm_Procurar(this, BxCliente.Text, CLIENTE);
            janela.ShowDialog();
            if (selecionado)
                SetTextoCliente();
        }

        private void BtProcurar_Click(object sender, EventArgs e)
        {
            selecionado = false;
            Frm_Procurar janela = new Frm_Procurar(this, BxProcurar.Text, PRODUTO);
            janela.ShowDialog();
            if (selecionado)
            {
                SetTexto();
                selecionado = false;
            }
        }

        private void btAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            ItemVenda iv = new ItemVenda();
            
            iv.Id_Venda= numeroVenda;
            iv.Id_Produto = p.Id;
            // iv.numeroitem = ;
            iv.Quantidade = int.Parse(BxQuantidade.Text);
            iv.Valor_Unitario = double.Parse(BxPreco.Text);
            iv.Total_Item = double.Parse(BxTotal.Text);

            AtualizaTabela(iv);
            Lista.Add(iv);

            subtotal += Double.Parse(BxTotal.Text);
            LbSubTotal.Text = "Sub - Total: R$ " + subtotal;

            LimparTexto();
            //numeroItem++;
            p = new Produto();
        }

        private void BtFinalizar_Click(object sender, EventArgs e)
        {
            if (ChecarPagamento())
            {
                PreencherVenda();


                IVendaPort controlador = new VendaService();
                controlador.AddVenda(venda);
                Dispose();
                MessageBox.Show("Venda adicionada");


            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Favor selecione uma forma de pagamento", "Erro", MessageBoxButtons.OK);
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cancelar a venda?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Dispose();
        }

        private void BtRemoverCarrinho_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja remover o item?", "Confirmação", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int pos = DataGridItemVenda.CurrentCell.RowIndex;
                String id = DataGridItemVenda.Rows[pos].Cells[0].Value.ToString();
                ItemVenda aux = new ItemVenda();

                aux = Lista.Find(item => item.Id_Produto == int.Parse(id));

                subtotal -= aux.Total_Item;
                LbSubTotal.Text = "Sub - Total: R$ " + subtotal;

                Lista.Remove(aux);
                DataGridItemVenda.Rows.RemoveAt(pos);
            }
        }

        private void btlistar_Click(object sender, EventArgs e)
        {
            Frm_ListarVenda listar = new Frm_ListarVenda("listar");
            listar.ShowDialog();
        }

        private void btcancelarvenda_Click(object sender, EventArgs e)
        {
            Frm_ListarVenda listar = new Frm_ListarVenda("cancelar");
            listar.ShowDialog();
        }
    }
}
