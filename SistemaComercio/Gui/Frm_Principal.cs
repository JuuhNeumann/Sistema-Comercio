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
            LblQuantForne.Text = serviceForne.Count().ToString();
            LblQuantCli.Text = serviceCli.Count().ToString();
            LblVend.Text = serviceVenda.Count().ToString();
            LblCmpr.Text = serviceCompra.Count().ToString();
            LblQuantProd.Text = serviceProduto.Count().ToString();

        }
    }
}
