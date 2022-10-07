using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System;
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

        private void CadastrarFornecedor(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor()
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
                Numero = txtNum.Text,
                Bairro = txtBairro.Text,
            };


            try
            {
                //FAZER COM TODOS OS CAMPOS
                if (!String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtNome.Text))
                {
                    service.AddFornecedor(fornecedor);
                    MessageBox.Show("Fornecedor cadastrado!");
                }
                else
                {
                    MessageBox.Show("Você deve preencher todos os campos!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar fornecedor!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
