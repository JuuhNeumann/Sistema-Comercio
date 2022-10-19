using SistemaComercio.Gui;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaComercio
{
    public partial class Frm_Login : Form
    {
        private IAdmPort service = new AdmService();


        public Frm_Login()
        {
            InitializeComponent();
        }

        private void ClickEntrar(object sender, EventArgs e)
        {

            var usuario = TxtUsuario.Text;
            var senha = TxtSenha.Text;

            var auth = service.Login(usuario, senha);


            if(auth)
            {
                MessageBox.Show("Bem vindo " + TxtUsuario.Text + "!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var principal = new Frm_Principal(TxtUsuario.Text);
                this.Hide();
                principal.ShowDialog();

            }
            else
            {
                MessageBox.Show("Usuário " + TxtUsuario.Text + " inválido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClickCancelar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClickCadastre(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Cadastro cadastro = new Frm_Cadastro();
            cadastro.Show();
        }
    }
}
