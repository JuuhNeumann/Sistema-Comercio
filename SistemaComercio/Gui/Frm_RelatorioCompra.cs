using Microsoft.Reporting.WinForms;
using SistemaComercioLibrary.Entity;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SistemaComercio.Gui
{
    public partial class Frm_RelatorioCompra : Form
    {
        private ICompraPort serviceC;
        private IItemCompraPort serviceItemC;
        private List<ItemCompra> itemCompras;
        private ItemCompra itemCompra;
        private DataTable dt = new DataTable();


        public Frm_RelatorioCompra()
        {
            InitializeComponent();
            UpdateReportViewer();
        }

        private void Frm_RelatorioCompra_Load(object sender, EventArgs e)
        {
            this.rvRelatorioCompra.RefreshReport();
        }

        public void UpdateReportViewer()
        {
            serviceItemC = new ItemCompraService();
            serviceC = new CompraService();

            CreateDataTable();
            CreateReportViewer();
        }

        public void CreateDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Produto", typeof(string));
            dt.Columns.Add("Quantidade", typeof(string));

            itemCompras = serviceItemC.GetAllItemCompra();

            foreach (var itemCompra in itemCompras)
            {
                dt.Rows.Add(new object[]
                {
                    itemCompra.Id,
                    itemCompra.Produto.Nome,
                    itemCompra.Quantidade,
                });
            }

        }

        public void CreateReportViewer()
        {
            rvRelatorioCompra.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("ItemCompras", dt);

            rvRelatorioCompra.LocalReport.ReportPath = "RelatorioCompras.rdlc";
            rvRelatorioCompra.LocalReport.DataSources.Add(reportDataSource);
            rvRelatorioCompra.LocalReport.Refresh();
        }

        private void rvRelatorioCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
