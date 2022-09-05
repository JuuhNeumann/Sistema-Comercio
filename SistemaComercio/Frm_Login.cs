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
                MessageBox.Show("Bem vindo " + TxtUsuario.Text);
                Frm_Cadastro cadastro = new Frm_Cadastro();
                cadastro.Show();
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


        private void SetPlaceholder(TextBox txtUsuario)
        {
            throw new NotImplementedException();
        }

        private void RbCliente_CheckedChanged(object sender, EventArgs e)
        {
            LblMudar.Text = "Olá Cliente!";
        }

        private void RbFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            LblMudar.Text = "Olá Fornecedor!";
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
