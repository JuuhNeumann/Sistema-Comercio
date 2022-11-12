using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Entity;
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
    public partial class Frm_Caixa : Form
    {
        private DataTable dt = new DataTable();

        public Frm_Caixa()
        {
            InitializeComponent();
            UpdateCaixaInDataGrid();
        }

        private void UpdateCaixaInDataGrid()
        {

            dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Data", typeof(string));
            dt.Columns.Add("Hora", typeof(string));
            dt.Columns.Add("Id Produto", typeof(string));
            dt.Columns.Add("Produto", typeof(string));
            dt.Columns.Add("Quantidade", typeof(string));
            dt.Columns.Add("Total", typeof(string));
            dt.Columns.Add("Forma de pagamento", typeof(string));
      

            dataGridViewCaixa.DataSource = dt;


        }

        private void FormattingRows(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //centraliza os dados da coluna
            dataGridViewCaixa.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCaixa.Columns["Data"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCaixa.Columns["Hora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCaixa.Columns["Id Produto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCaixa.Columns["Produto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCaixa.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCaixa.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCaixa.Columns["Forma de pagamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn coluna in dataGridViewCaixa.Columns)
            {
                switch (coluna.Name)
                {
                    case "Id":
                        coluna.Width = 40;
                        break;
                    case "Data":
                        coluna.Width = 100;
                        break;
                    case "Hora":
                        coluna.Width = 100;
                        break;
                    case "Id Produto":
                        coluna.Width = 55;
                        break;
                    case "Produto":
                        coluna.Width = 150;
                        break;
                    case "Quantidade":
                        coluna.Width = 55;
                        break;
                    case "Total":
                        coluna.DefaultCellStyle.Format = "C2";
                        coluna.Width = 70;
                        break;
                    case "Forma de pagamento":
                        coluna.Width = 120;
                        break;
                    case "Situacao":
                        coluna.DisplayIndex = 1;
                        coluna.Width = 135;
                        break;
                }
            }

        }
        private void ClickSair(object sender, EventArgs e)
        {
            var principal = new Frm_Principal();
            this.Hide();
        }

        private void ClickGerarRelatorio(object sender, EventArgs e)
        {
            var relatorio = new Frm_RelatorioCaixa();
            relatorio.Show();
        }

    }
}