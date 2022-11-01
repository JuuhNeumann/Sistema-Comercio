using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System;
using System.Collections;
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
    public partial class Frm_ListarVenda : Form
    {
        private List<Venda> Lista = new List<Venda>();
        private String filtro;
        private string funcao;
        private const string CANCELAR = "cancelar";
        private const string LISTAR = "listar";
        private IVendaPort vp = new VendaService();
        private IClientePort ic = new ClienteService();
        private IProdutoPort ip = new ProdutoService();
        public Frm_ListarVenda()
        {
            InitializeComponent();
        }
        public Frm_ListarVenda(String funcao)
        {
            InitializeComponent();
            this.funcao = funcao;
            if (this.funcao == LISTAR)
            {
                btnCancelar.Visible = true;
                btnCancelar.Enabled = true;
                btnCancelar.Text = "Gerar relatório";
                this.Text = "Listar vendas";
            }
            else
            {
                btnCancelar.Visible = true;
                btnCancelar.Enabled = true;
                this.Text = "Cancelar Venda";
            }
            Lista = vp.GetAllVenda();
            PreencherTabela();
        }

        private void PreencherTabela()
        {
            GridLista.Rows.Clear();
            foreach (Venda venda in Lista)
            {
                String[] row = { venda.Id.ToString(), venda.Data.ToString(), venda.Hora.ToString(),
                    ic.GetByIdCliente(venda.Id_Cliente).Nome.ToString(),
                    venda.Total_Venda.ToString(), venda.Situacao_Venda };
                GridLista.Rows.Add(row);

            }
            GridLista.Rows[0].Selected = true;

        }

        private bool ChecarSelecao()
        {
            if (RbData.Checked)
            {
                filtro = "Data";
                return true;
            }
            if (Rbcliente.Checked)
            {
                filtro = "Cliente";
                return true;
            }
            return false;
        }
        private void checar()
        {
            if (ChecarSelecao())
            {
                String busca = BxPesquisa.Text;
                GridLista.Rows.Clear();
                foreach (Venda venda in Lista)
                {
                    if (filtro == "data")
                    {
                        if (venda.Data.ToString().Contains(busca))
                        {
                            String[] row = { venda.Id.ToString(), venda.Data.ToString(), venda.Hora.ToString(),
                            ic.GetByIdCliente(venda.Id_Cliente).Nome.ToString(),
                            venda.Total_Venda.ToString(), venda.Situacao_Venda };
                            GridLista.Rows.Add(row);
                        }
                    }
                    if (filtro == "Cliente")
                    {
                        if (ic.GetByIdCliente(venda.Id_Cliente).Nome.ToString().Contains(busca))
                        {
                            String[] row = { venda.Id.ToString(), venda.Data.ToString(), venda.Hora.ToString(),
                            ic.GetByIdCliente(venda.Id_Cliente).Nome.ToString(),
                            venda.Total_Venda.ToString(), venda.Situacao_Venda };
                            GridLista.Rows.Add(row);
                        }
                    }
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Favor selecione um filtro", "Erro", MessageBoxButtons.OK);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (funcao == CANCELAR)
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja cancelar?", "Confirmação", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int pos = GridLista.CurrentCell.RowIndex;
                    int id = int.Parse(GridLista.Rows[pos].Cells[0].Value.ToString());


                    vp.UpdateVendaSituacao(id, "CANCELADA");
                    Lista = vp.GetAllVenda();
                    PreencherTabela();
                }
            }
            else if (funcao == LISTAR)
            {
                // GeradorPDF gerador = new(GridLista, "Relatório de Vendas.pdf");
                // gerador.GerarPDF();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btfiltrar_Click(object sender, EventArgs e)
        {
            checar();
        }
    }
}
