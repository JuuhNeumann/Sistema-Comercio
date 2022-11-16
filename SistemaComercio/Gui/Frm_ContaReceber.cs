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
    public partial class Frm_ContaReceber : Form
    {
        private Frm_Principal formprincipal;

        public Frm_ContaReceber(Frm_Principal frm_Principal)
        {
            InitializeComponent();
            formprincipal = frm_Principal;

        }
    }
}
