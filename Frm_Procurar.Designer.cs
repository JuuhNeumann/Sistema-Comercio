namespace SistemaComercio.Gui
{
    partial class Frm_Procurar
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
            this.BtSelecionar = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BtSelecionar
            // 
            this.BtSelecionar.Location = new System.Drawing.Point(266, 28);
            this.BtSelecionar.Name = "BtSelecionar";
            this.BtSelecionar.Size = new System.Drawing.Size(75, 61);
            this.BtSelecionar.TabIndex = 0;
            this.BtSelecionar.Text = "Selecionar";
            this.BtSelecionar.UseVisualStyleBackColor = true;
            this.BtSelecionar.Click += new System.EventHandler(this.BtSelecionar_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Nome});
            this.DataGrid.Location = new System.Drawing.Point(27, 28);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(193, 294);
            this.DataGrid.TabIndex = 1;
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(266, 108);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 72);
            this.BtCancelar.TabIndex = 2;
            this.BtCancelar.Text = "cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Frm_Procurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 333);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.BtSelecionar);
            this.Name = "Frm_Procurar";
            this.Text = "Frm_Procurar";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtSelecionar;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}