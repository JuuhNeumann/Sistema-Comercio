using SistemaComercioLibrary.Classes;
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
using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Service;
using System.Collections;
using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Entity;
using SistemaComercioLibrary.Entity;

namespace SistemaComercio.Gui
{
    public partial class Frm_RegistroVenda : Form
    {   
        private List<ItemVenda> lista = new List<ItemVenda>();
        private Venda venda = new Venda();
        private Produto p = new Produto();
        private Cliente c = new Cliente();
        private double subtotal = 0;
        private int numeroItem = 0;
        private int numeroVenda;
        private int maiorId;
        private IVendaPort vp = new VendaService();
        private IProdutoPort pp = new ProdutoService();
        private FormaPagamentoVenda fpv = new FormaPagamentoVenda();
        private enum Pagamento
        {
            Dinheiro,
            Credito,
            Debito,
            Pix,
            Boleto
        }
        private bool selecionado;
        public const String CLIENTE = "Cliente";
        public const String PRODUTO = "`Produtos";
  



        public Frm_RegistroVenda()
        {
            InitializeComponent();
            SetNumeroVenda();
            GetMaxIdProduto();

        }
        /*   public override void Selecionado(bool v)
           {
               selecionado = v;
           }
           public override void SetProduto(Produto produto)
           {
               p = produto;
           }

           public override void SetCliente(Cliente cliente)
           {
               c = cliente;
           }*/
        private void GetMaxIdProduto()
        {
            maiorId = pp.Count();
            
        }
     
        private void SetTexto()
        {
           // LbNome.Text = p.nome.ToString();
            tbpreco.Text = p.Preco.ToString();
            tbquantidade.Text = "1";
            AtualizarTotal();
            
        }
     

        private void SetNumeroVenda()
        {
            numeroVenda = vp.Count()+1;
            tbidvenda.Text = numeroVenda.ToString();
        }
        private void AtualizarTotal()
        {
            int qtd = int.Parse(tbquantidade.Text);
            double preco = Double.Parse(tbpreco.Text);
            double total = qtd* preco;
            tbtotal.Text = total.ToString();
        }
        private void AtualizaTabela(ItemVenda iv)
        {
            String[] row = { iv.Id.ToString(), p.Id.ToString(), p.Nome, iv.quantidade.ToString(),
                             iv.valorUnitario.ToString(), iv.valorTotal .ToString() };
            DataGridItemVenda.Rows.Add(row);
            //editargrid;
        }
        private bool ChecarPagamento()
        {
            if (RbDinheiro.Checked)
            {
                fpv.Id_FormaPagamento = ((int)Pagamento.Dinheiro);
                return true;
            }
            if (RbCredito.Checked)
            {
                fpv.Id_FormaPagamento = ((int)Pagamento.Credito);
                return true;
            }
            if (RbDebito.Checked)
            {
                fpv.Id_FormaPagamento = ((int)Pagamento.Debito);
                return true;
            }
            if (RbBoleto.Checked)
            {
                fpv.Id_FormaPagamento = ((int)Pagamento.Boleto);
                return true;
            }
            if (RbPix.Checked)
            {
                fpv.Id_FormaPagamento = ((int)Pagamento.Pix);
                return true;
            }
            return false;
        }
        private ContaReceber PreencherContaReceber(DateTime thisDay)
        {
            ContaReceber conta = new ContaReceber();
            conta.Id = venda.Id;
            conta.Id_Cliente = venda.Id_Cliente;
            conta.Data_Lancamento = Convert.ToDateTime(thisDay.ToString("yyyy-MM-dd"));
            conta.Data_Vencimento = Convert.ToDateTime(thisDay.AddDays(7).ToString("yyyy-MM-dd"));
            conta.Valor = venda.Total_Venda;
            conta.Recebido = "NAO";
            return conta;
        }
        private void PreencherVenda()
        {
            DateTime thisDay = DateTime.Now;
            string data = thisDay.ToString("yyyy-MM-dd");
            string hora = thisDay.ToString("HH:mm:ss");

            venda.Id = numeroVenda;
            venda.Data = Convert.ToDateTime(data);
            venda.Hora = Convert.ToDateTime(hora);
            venda.Id_Cliente = c.Id;
            venda.Total_Venda = subtotal;
            venda.Situacao_Venda = "ATIVA";
            fpv.Id_Venda = numeroVenda;
            venda.Total_Venda = subtotal;
            venda.ContaReceber = PreencherContaReceber(thisDay);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ItemVenda iv = new ItemVenda();
            iv.Id = numeroVenda;
            iv.Id_Produto = p.Id;
            iv.numero_item = numeroItem;
            iv.quantidade = int.Parse(tbquantidade.Text);
            iv.valorUnitario = double.Parse(tbpreco.Text);
            iv.valorTotal = double.Parse(tbtotal.Text);

            AtualizaTabela(iv);
            lista.Add(iv);

            subtotal += Double.Parse(tbtotal.Text);
            tbvalortotal.Text = Convert.ToString(subtotal);

            limpar();
            numeroItem++;
            p = new Produto();




            limparcompra();
        }

        private void button3_Click(object sender, EventArgs e)
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cancelar a venda?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Dispose();
        }
        private void limpar(){
            tbidcliente.Clear();
            tbidproduto.Clear();
            tbidvenda.Clear();
            tbpreco.Clear();
            tbquantidade.Clear();
            tbtroco.Clear();
            tbvalorpago.Clear();
            tbvalortotal.Clear();


        }
        private void limparcompra()
        {
           
            tbidproduto.Clear();
            
            tbpreco.Clear();
            tbquantidade.Clear();
           
  


        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (tbidproduto.Text != "" && int.Parse(tbidproduto.Text) < maiorId && int.Parse(tbidproduto.Text) > 0)
            {
                pp.GetProdutoCodigo(int.Parse(tbidproduto.Text));
                SetTexto();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Item inexistente", "Erro", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja remover o item?", "Confirmação", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int pos = DataGridItemVenda.CurrentCell.RowIndex;
                String id = DataGridItemVenda.Rows[pos].Cells[0].Value.ToString();
                ItemVenda aux = new ItemVenda();

                aux = lista.Find(item => item.numero_item == int.Parse(id));

                subtotal -= aux.valorTotal;
                tbvalortotal.Text = Convert.ToString( subtotal);

                lista.Remove(aux);
                DataGridItemVenda.Rows.RemoveAt(pos);
            }

        }

        private void DataGridItemVenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridItemVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 
}
