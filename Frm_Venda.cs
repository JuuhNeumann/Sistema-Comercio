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
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComercio.Gui
{

    public partial class Frm_Venda : Form
    {
        private List<ItemVenda> Lista = new List<ItemVenda>();
        private Venda venda = new Venda();
        private FormaPagamentoVenda formapagamento = new FormaPagamentoVenda();
        private Produto p = new Produto();
        private Cliente c = new Cliente();
        private double subtotal = 0;
        private int numeroItem = 0;
        private int numeroVenda;
        private int maiorId;

        private IClientePort cp = new ClienteService();
        private IProdutoPort pp = new ProdutoService();
        private IVendaPort vp = new VendaService();
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

        public Frm_Venda()
        {
            InitializeComponent();
            SetCliente("0");
           // SetTextoCliente();
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
            
            c =  cp.GetByIdCliente(int.Parse(id)) ;
           
        }

        private void GetMaxIdProduto()
        {
            maiorId = pp.Count();
        }

        private void SetTexto()
        {
            LbNome.Text = p.Nome.ToString();
            BxPreco.Text = p.Preco.ToString();
          
            //BxQuantidade.Value = 1;
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
            String[] row = { iv.numeroItem.ToString(), p.Id.ToString(), p.Nome, iv.Quantidade.ToString(),
                             iv.valorUnitario.ToString(), iv.valorTotal.ToString() };
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
            conta.Recebido = "NAO";
            return conta;
        }

        private void PreencherVenda()
        {
            DateTime thisDay = DateTime.Now;
            string data = thisDay.ToString("yyyy-MM-dd");
            string hora = thisDay.ToString("HH:mm:ss");
            ContaReceber conta = new ContaReceber();

            venda.Id = numeroVenda;
            venda.Data = Convert.ToDateTime(data);
            venda.Hora = Convert.ToDateTime(hora);
            venda.Id_Cliente = c.Id;
            venda.Total_Venda = subtotal;
            venda.Situacao_Venda = "ATIVA";
            venda.ItemVenda = Lista;
            formapagamento.Id_Venda = numeroVenda;
            formapagamento.valor = subtotal;
            conta = PreencherContaReceber(thisDay);
        }
        private void FinalizarButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cancelar a venda?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Dispose();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            selecionado = false;
            Frm_Procurar janela = new Frm_Procurar(this, BxCliente.Text, CLIENTE);
            janela.ShowDialog();
            if (selecionado)
                SetTextoCliente();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AdicionarButton_Click(object sender, EventArgs e)
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

        private void rbDebito_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            ItemVenda iv = new ItemVenda();
            iv.Id = numeroVenda;
            iv.Id_Produto = p.Id;
            iv.numeroItem = numeroItem;
            iv.Quantidade = int.Parse(BxQuantidade.Text);
            iv.valorUnitario = double.Parse(BxPreco.Text);
            iv.valorTotal = double.Parse(BxTotal.Text);

            AtualizaTabela(iv);
            Lista.Add(iv);

            subtotal += Double.Parse(BxTotal.Text);
            LbSubTotal.Text = "Sub - Total: R$ " + subtotal;

            LimparTexto();
            numeroItem++;
            p = new Produto();
        }

        private void BtRemoverCarrinho_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja remover o item?", "Confirmação", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int pos = DataGridItemVenda.CurrentCell.RowIndex;
                String id = DataGridItemVenda.Rows[pos].Cells[0].Value.ToString();
                ItemVenda aux = new ItemVenda();

                aux = Lista.Find(item => item.numeroItem == int.Parse(id));

                subtotal -= aux.valorTotal;
                LbSubTotal.Text = "Sub - Total: R$ " + subtotal;

                Lista.Remove(aux);
                DataGridItemVenda.Rows.RemoveAt(pos);
            }
        }

        private void BtFinalizar_Click(object sender, EventArgs e)
        {
            if (ChecarPagamento())
            {
                PreencherVenda();

                
                IVendaPort controlador = new VendaService();
                controlador.AddVenda(venda);
                this.Dispose();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Favor selecione uma forma de pagamento", "Erro", MessageBoxButtons.OK);
            }

        }

        private void btlistar_Click(object sender, EventArgs e)
        {
            Frm_ListarVendas listar = new Frm_ListarVendas("listar");
            listar.ShowDialog();

        }

        private void btcancelarvenda_Click(object sender, EventArgs e)
        {
            Frm_ListarVendas listar = new Frm_ListarVendas("cancelar");
            listar.ShowDialog();
        }

        private void DataGridItemVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
