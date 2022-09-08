using SistemaComercioLibrary.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaComercio
{
    public partial class Frm_Login : Form
    {

        private LocalDBClass bd;

        public Frm_Login()
        {
            InitializeComponent();
            bd = new LocalDBClass();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            var email = TxtUsuario.Text;
            var senha = TxtSenha.Text;


            var auth = bd.Login(email, senha);

            if(auth)
            {
                MessageBox.Show("Bem vindo " + TxtUsuario.Text + "!");
                Frm_Cadastro cadastro = new Frm_Cadastro();
                cadastro.Show();
            }
            else
            {
                MessageBox.Show("Usuário " + TxtUsuario.Text + " inválido!");
            }
        }
        private void SetPlaceholder(TextBox txtUsuario)
        {
            throw new NotImplementedException();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
