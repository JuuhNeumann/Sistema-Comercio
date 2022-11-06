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
    public partial class Frm_Principal : Form
    {
        IFornecedorPort serviceForne = new FornecedorService();
        IClientePort serviceCli = new ClienteService();
        IVendaPort serviceVenda = new VendaService();
        ICompraPort serviceCompra = new CompraService();
        IProdutoPort serviceProduto = new ProdutoService();

        public Frm_Principal(string usuario)
        {
            InitializeComponent();
            LblNomeAdm.Text = usuario;
            GetCount();

        }

        public Frm_Principal()
        {
        }

        public void GetCount()
        {
            LblQuantForne.Text = serviceForne.Count().ToString();
            LblQuantCli.Text = serviceCli.Count().ToString();
            LblVend.Text = serviceVenda.Count().ToString();
            LblCmpr.Text = serviceCompra.Count().ToString();
            LblQuantProd.Text = serviceProduto.Count().ToString();
        }

        private void ClickCliente(object sender, EventArgs e)
        {
            Frm_Cliente cliente = new Frm_Cliente(this);
            cliente.Show();
        }


        private void ClickFornecedor(object sender, EventArgs e)
        {
            Frm_Fornecedor fornecedor = new Frm_Fornecedor();
            fornecedor.Show();
        }
  

        private void ClickProduto(object sender, EventArgs e)
        {
            
        }

        private void ClickCompra(object sender, EventArgs e)
        {
            Frm_Compra compra = new Frm_Compra();
            compra.Show();
        }

        private void ClickVenda(object sender, EventArgs e)
        {
            Frm_Venda venda = new Frm_Venda();
            venda.Show();
        }
    }
}
