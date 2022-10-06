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
    public partial class Frm_Fornecedor : Form
    {
        private IFornecedorPort service = new FornecedorService();

        public Frm_Fornecedor()
        {
            InitializeComponent();
        }

    }
}
