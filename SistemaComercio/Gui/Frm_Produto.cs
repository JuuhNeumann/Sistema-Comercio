using SistemaComercioBiblioteca.Classes;
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
    public partial class Frm_Produto : Form
    {
        private IProdutoPort service = new ProdutoService();

        public Frm_Produto()
        {
            InitializeComponent();
        }

        private void CadastrarProduto(object sender, EventArgs e)
        {

            var produto = new Produto()
            {
                Nome = txtNome.Text,
                //Quantidade_Estoque = txtEstoque.Text, INT
                //Preco = txtPreco.Text, DOUBLE
                Unidade = txtUnidade.Text,
            };

            try
            {
                //FAZER COM TODOS OS CAMPOS
                if (ValidarCampos())
                {
                    service.AddProduto(produto);
                    MessageBox.Show("Produto cadastrado!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você deve preencher todos os campos!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar produto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool ValidarCampos()
        {
            //FAZER COM TODOS OS CAMPOS
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtUnidade.Text))
                //|| String.IsNullOrEmpty(txtEstoque.Text) || String.IsNullOrEmpty(txtPreco.Text))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void Frm_Produto_Load(object sender, EventArgs e)
        {
            dataGridViewProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProd.DataSource = service.GetAllProduto();
        }

        private void ClickSair(object sender, EventArgs e)
        {
            var principal = new Frm_Principal();
            this.Hide();
        }
    }
}