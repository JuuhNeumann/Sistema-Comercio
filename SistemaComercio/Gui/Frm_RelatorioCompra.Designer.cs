namespace SistemaComercio.Gui
{
    partial class Frm_RelatorioCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleCompra = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.rvRelatorioCompra = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.lblTitleCompra);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 61);
            this.panel1.TabIndex = 0;
            // 
            // lblTitleCompra
            // 
            this.lblTitleCompra.AutoSize = true;
            this.lblTitleCompra.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitleCompra.Location = new System.Drawing.Point(23, 18);
            this.lblTitleCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleCompra.Name = "lblTitleCompra";
            this.lblTitleCompra.Size = new System.Drawing.Size(215, 23);
            this.lblTitleCompra.TabIndex = 1;
            this.lblTitleCompra.Text = "Relatório de Compras";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblData.Location = new System.Drawing.Point(395, 28);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(37, 13);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatus.Location = new System.Drawing.Point(611, 28);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(431, 25);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(159, 21);
            this.txtData.TabIndex = 1;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(658, 25);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(184, 21);
            this.cmbStatus.TabIndex = 1;
            // 
            // rvRelatorioCompra
            // 
            this.rvRelatorioCompra.Location = new System.Drawing.Point(-2, 55);
            this.rvRelatorioCompra.Name = "rvRelatorioCompra";
            this.rvRelatorioCompra.ServerReport.BearerToken = null;
            this.rvRelatorioCompra.Size = new System.Drawing.Size(857, 362);
            this.rvRelatorioCompra.TabIndex = 1;
            // 
            // Frm_RelatorioCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 415);
            this.Controls.Add(this.rvRelatorioCompra);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Frm_RelatorioCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Compras";
            this.Load += new System.EventHandler(this.Frm_RelatorioCompra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTitleCompra;
        private Microsoft.Reporting.WinForms.ReportViewer rvRelatorioCompra;
    }
}