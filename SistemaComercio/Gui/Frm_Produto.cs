using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System;
using System.Windows.Forms;

namespace SistemaComercio.Gui
{
    public partial class Frm_Produto : Form
    {
        private IProdutoPort service = new ProdutoService();
        private IFornecedorPort serviceForne = new FornecedorService();

        public Frm_Produto()
        {
            InitializeComponent();
            AddComboBoxFornecedor();
            dataGridViewProd.DataSource = service.GetAllProduto();

        }

        private void AddComboBoxFornecedor()
        {
            var fornecedores = serviceForne.GetAllFornecedor();
            foreach (var fornecedor in fornecedores)
            {
                this.cmbNomeForne.Items.AddRange(new object[] {
                fornecedor.Nome.ToString()
                });
            }
        }

        private void CadastrarProduto(object sender, EventArgs e)
        {
            var nomeForne = cmbNomeForne.Text; //pego o nome marcado pelo usuario
            var umForne = serviceForne.GetByNomeFornecedor(nomeForne); //pego no banco o fornecedor q tem esse nome

            var produto = new Produto()
            {
                Id_Fornecedor = umForne.Id,
                Nome = txtNome.Text,
                Quantidade_Estoque = Convert.ToInt32(txtEstoque.Text), 
                Preco = Convert.ToDouble(txtPreco.Text), 
                Unidade = cmbUnidade.Text,
            };

            try
            {
                //FAZER COM TODOS OS CAMPOS
                if (ValidarCampos())
                {
                    service.AddProduto(produto);
                    dataGridViewProd.DataSource = service.GetAllProduto(); //trazer o fornecedor q acabamos de cadastrar no dataGrid
                    LimparCampos();
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
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(cmbUnidade.Text)
            || String.IsNullOrEmpty(txtEstoque.Text) || String.IsNullOrEmpty(txtPreco.Text))
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


        private void LimparCampos()
        {
            txtNome.Clear();
            txtEstoque.Clear();
            txtPreco.Clear();
            cmbUnidade.Text = "";
            cmbNomeForne.Text = "";
        }


        private void ClickLimpar(object sender, EventArgs e)
        {
            LimparCampos();
        }


        private void ClickSair(object sender, EventArgs e)
        {
            var principal = new Frm_Principal();
            this.Hide();
        }
    }
}