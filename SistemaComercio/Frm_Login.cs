using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComercio
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Luquinhas" & TxtSenha.Text == "Lindo")
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }


        private object SetPlaceholder(TextBox txtUsuario, string v)
        {
            throw new NotImplementedException();
        }

        private void SetPlaceholder(TextBox txtUsuario)
        {
            throw new NotImplementedException();
        }

        private void TxtUsuario_TextChanged_1(object sender, EventArgs e)
        {
            SetPlaceholder(TxtUsuario, "Insira o e-mail"); //nao funciona
        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {
            SetPlaceholder(TxtSenha, "Insira a senha"); //nao funciona
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
