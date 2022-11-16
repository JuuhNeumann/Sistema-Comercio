using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Port;
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
    public partial class Frm_RelatorioContaReceber : Form
    {
        private Frm_Principal frmprincipal;

        public Frm_RelatorioContaReceber()
        {
            InitializeComponent();
        }

        private void Frm_RelatorioContaReceber_Load(object sender, EventArgs e)
        {

            this.rvRelatorioContaReceber.RefreshReport();
        }

        private void ClickSair(object sender, EventArgs e)
        {
            var contaR = new Frm_ContaReceber(frmprincipal);
            this.Hide();
        }
    }
}
