using SistemaComercioLibrary.Classes;
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
    public partial class Frm_Cliente : Form
    {
        private IClientePort service = new ClienteService();

        public Frm_Cliente()
        {
            InitializeComponent();
            dataGridViewCli.DataSource = service.GetAllCliente();
        }


        private void CadastrarCliente(object sender, EventArgs e)
        {
            var cliente = new Cliente()
            {
                Nome = txtNome.Text,
                Cpf_Cnpj = txtCPF.Text,
                Telefone = txtTel.Text,
                Cep = txtCEP.Text,
                Cidade = txtCidade.Text,
                Complemento = txtComple.Text,
                Email = txtEmail.Text,
                Estado = txtEstado.Text,
                Logradouro = txtLogra.Text,
                Numero = Convert.ToInt32(txtNum.Text),
                Bairro = txtBairro.Text,
            };

            try
            {
                //FAZER COM TODOS OS CAMPOS
                if (ValidarCampos())
                {
                    service.AddCliente(cliente);
                    dataGridViewCli.DataSource = service.GetAllCliente();
                    LimparCampos();
                    MessageBox.Show("Cliente cadastrado!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você deve preencher todos os campos!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar cliente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool ValidarCampos()
        {
            //FAZER COM TODOS OS CAMPOS
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtCPF.Text) ||
                String.IsNullOrEmpty(txtTel.Text) || String.IsNullOrEmpty(txtCEP.Text) ||
                String.IsNullOrEmpty(txtCidade.Text) || String.IsNullOrEmpty(txtComple.Text) ||
                String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtEstado.Text) ||
                String.IsNullOrEmpty(txtLogra.Text) || String.IsNullOrEmpty(txtNum.Text) || String.IsNullOrEmpty(txtBairro.Text))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtTel.Clear();
            txtCidade.Clear();
            txtEmail.Clear();
            txtLogra.Clear();
            txtCPF.Clear();
            txtCEP.Clear();
            txtComple.Clear();
            txtEstado.Clear();
            txtNum.Clear();
            txtBairro.Clear();
        }

        private void Frm_Cliente_Load(object sender, EventArgs e)
        {
            dataGridViewCli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCli.DataSource = service.GetAllCliente();
        }

        private void ClickSair(object sender, EventArgs e)
        {
            var principal = new Frm_Principal();
            this.Hide();
        }

        private void ClickPesquisar(object sender, EventArgs e)
        {
            dataGridViewCli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCli.DataSource = service.GetByNomeCliente(txtPesquisa.Text);
        }
    }
}


