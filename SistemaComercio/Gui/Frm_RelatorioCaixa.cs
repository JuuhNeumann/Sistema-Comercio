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
    public partial class Frm_RelatorioCaixa : Form
    {
        public Frm_RelatorioCaixa()
        {
            InitializeComponent();
        }

        private void Frm_RelatorioCaixa_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void ClickSair(object sender, EventArgs e)
        {
            var principal = new Frm_Principal();
            this.Hide();
        }
    }
}
