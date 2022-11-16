using Microsoft.Reporting.WinForms;
using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Entity;
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
    public partial class Frm_RelatorioContaPagar : Form
    {
        private IContaPagarPort service;
        private ICompraPort serviceC;
        private List<Compra> compras;
        private Compra compra;
        private DataTable dt = new DataTable();
        private Frm_Principal frmprincipal;

        public Frm_RelatorioContaPagar()
        {
            InitializeComponent();
        }

        private void Frm_RelatorioContaPagar_Load(object sender, EventArgs e)
        {
            this.rvRelatorioContaPagar.RefreshReport();
        }

        public void UpdateReportViewer()
        {
            serviceC = new CompraService();
            service = new ContaPagarService();

            CreateDataTable();
            CreateReportViewer();
        }

        public void CreateDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("IdCompra", typeof(string));
            dt.Columns.Add("Descricao", typeof(string));
            dt.Columns.Add("DataLancamento", typeof(string));
            dt.Columns.Add("DataVencimento", typeof(string));
            dt.Columns.Add("Valor", typeof(string));
            dt.Columns.Add("Pago", typeof(string));
            dt.Columns.Add("DataPagamento", typeof(string));
            dt.Columns.Add("ValorPagamento", typeof(string));
            dt.Columns.Add("FormaPagamento", typeof(string));
            dt.Columns.Add("Parcelamento", typeof(string));
            dt.Columns.Add("Fornecedor", typeof(string));

            if (compras == null)
                compras = serviceC.GetAllCompra();

            foreach (var compra in compras)
            {
                var FormRelatorioCP = new FormRelatorioContaPagar(compra);

                dt.Rows.Add(new object[]
                {
                    FormRelatorioCP.Id,
                    FormRelatorioCP.IdCompra,
                    FormRelatorioCP.Descricao,
                    FormRelatorioCP.DataLancamento,
                    FormRelatorioCP.DataVencimento,
                    FormRelatorioCP.Valor,
                    FormRelatorioCP.Pago,
                    FormRelatorioCP.DataPagamento,
                    FormRelatorioCP.ValorPagamento,
                    FormRelatorioCP.FormaPagamento,
                    FormRelatorioCP.Parcelamento,
                    FormRelatorioCP.Fornecedor,
                });
            }

        } //ta certo???

        public void CreateReportViewer()
        {
            rvRelatorioContaPagar.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("ItemCompras", dt);
            rvRelatorioContaPagar.LocalReport.ReportPath = "RelatorioCompras.rdlc";
            rvRelatorioContaPagar.LocalReport.DataSources.Add(reportDataSource);

            AddParameter("TotalContaPagar", compras.Count.ToString());
            rvRelatorioContaPagar.LocalReport.Refresh();
        }

        public void AddParameter(string parameter, string value)
        {
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter(parameter, value);
            rvRelatorioContaPagar.LocalReport.SetParameters(parameters);
        }

        private void cmbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = serviceC.GetAllCompra();
            compras = item.Where(x => x.Situacao_Compra.Equals(cmbSituacao.Text)).ToList();
            ClearReportViewer();
            UpdateReportViewer();
            rvRelatorioContaPagar.RefreshReport();
        }

        private void ClearReportViewer()
        {
            rvRelatorioContaPagar.ResetPageSettings();
            rvRelatorioContaPagar.LocalReport.Refresh();
            this.rvRelatorioContaPagar.LocalReport.DataSources.Clear();
        }

        private void rvRelatorioContaPagar_ReportRefresh(object sender, CancelEventArgs e)
        {
            CreateReportViewer();
        }

        private void ClickSair(object sender, EventArgs e)
        {
            var contaC = new Frm_ContaPagar(frmprincipal);
            this.Hide();
        }
    }
}
