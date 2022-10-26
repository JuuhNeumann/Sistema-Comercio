using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Classes;
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
    public partial class Frm_Procurar : Form
    {
        private List<Produto> ListaProduto = new List<Produto>();
        private List<Cliente> ListaCliente = new List<Cliente>();
       // private List<Fornecedor> ListaFornecedor = new();
        private Produto p;
        private Cliente c;
      //  private Fornecedor f;
        private  Frm_Venda janela;
        private String funcao;
        private IProdutoPort pp = new ProdutoService();
        private IVendaPort iv = new VendaService();
        private IClientePort ic = new ClienteService();
        public Frm_Procurar()
        {
            InitializeComponent();
        }
        public Frm_Procurar(Frm_Venda NV, String nome, String funcao)
        {
            InitializeComponent();
            this.funcao = funcao;
            if (funcao == Frm_Venda.PRODUTO)
            {
                ListaProduto.Add(pp.GetByNameProduto(nome));
                janela = (Frm_Venda)NV;
            }
            else if (funcao == Frm_Venda.CLIENTE)
            {
                ListaCliente.Add(ic.GetByNomeCliente(nome));
                janela = (Frm_Venda)NV;
            }
           /* else if (funcao == GerarCompra.FORNECEDOR)
            {
                ListaFornecedor = FornecedorSQL.BuscarMultiplosPorNome(nome);
                janela = (GerarCompra)NV;
            }
            else if (funcao == GerarCompra.PRODUTO)
            {
                ListaProduto = ProdutoSQL.BuscarMultiplosPorNome(nome);
                janela = (GerarCompra)NV;
            }*/
            PreencherTabela();
        }
        public void PreencherTabela()
        {
            if (funcao == Frm_Venda.PRODUTO)
                foreach (Produto produto in ListaProduto)
                {
                    String[] row = { produto.Id.ToString(), produto.Nome };
                    DataGrid.Rows.Add(row);
                }
            else if (funcao == Frm_Venda.CLIENTE)
                foreach (Cliente cliente in ListaCliente)
                {
                    String[] row = { cliente.Id.ToString(), cliente.Nome };
                    DataGrid.Rows.Add(row);
                }
            DataGrid.Rows[0].Selected = true;
        }

        private void BtSelecionar_Click(object sender, EventArgs e)
        {
            if (funcao == Frm_Venda.PRODUTO)
            {
                p = ListaProduto[DataGrid.CurrentCell.RowIndex];
                janela.SetProduto(p);
            }
            else if (funcao == Frm_Venda.CLIENTE)
            {
                c = ListaCliente[DataGrid.CurrentCell.RowIndex];
                janela.SetCliente(c);
            }
            janela.Selecionado(true);
            Dispose();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja cancelar?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Dispose();
        }
    }
}
