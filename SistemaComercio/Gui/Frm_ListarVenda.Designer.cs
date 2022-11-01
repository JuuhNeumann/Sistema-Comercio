namespace SistemaComercio.Gui
{
    partial class Frm_ListarVenda
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
            this.GridLista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RbData = new System.Windows.Forms.RadioButton();
            this.Rbcliente = new System.Windows.Forms.RadioButton();
            this.BxPesquisa = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btfiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridLista)).BeginInit();
            this.SuspendLayout();
            // 
            // GridLista
            // 
            this.GridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Data,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.GridLista.Location = new System.Drawing.Point(34, 53);
            this.GridLista.Name = "GridLista";
            this.GridLista.Size = new System.Drawing.Size(643, 311);
            this.GridLista.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hora";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cliente";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Situação";
            this.Column5.Name = "Column5";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 415);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "filtrar por: ";
            // 
            // RbData
            // 
            this.RbData.AutoSize = true;
            this.RbData.Location = new System.Drawing.Point(211, 375);
            this.RbData.Name = "RbData";
            this.RbData.Size = new System.Drawing.Size(48, 17);
            this.RbData.TabIndex = 9;
            this.RbData.TabStop = true;
            this.RbData.Text = "Data";
            this.RbData.UseVisualStyleBackColor = true;
            // 
            // Rbcliente
            // 
            this.Rbcliente.AutoSize = true;
            this.Rbcliente.Location = new System.Drawing.Point(265, 373);
            this.Rbcliente.Name = "Rbcliente";
            this.Rbcliente.Size = new System.Drawing.Size(57, 17);
            this.Rbcliente.TabIndex = 10;
            this.Rbcliente.TabStop = true;
            this.Rbcliente.Text = "Cliente";
            this.Rbcliente.UseVisualStyleBackColor = true;
            // 
            // BxPesquisa
            // 
            this.BxPesquisa.Location = new System.Drawing.Point(190, 415);
            this.BxPesquisa.Name = "BxPesquisa";
            this.BxPesquisa.Size = new System.Drawing.Size(288, 20);
            this.BxPesquisa.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(662, 412);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar Venda";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btfiltrar
            // 
            this.btfiltrar.Location = new System.Drawing.Point(502, 412);
            this.btfiltrar.Name = "btfiltrar";
            this.btfiltrar.Size = new System.Drawing.Size(75, 23);
            this.btfiltrar.TabIndex = 13;
            this.btfiltrar.Text = "Filtrar";
            this.btfiltrar.UseVisualStyleBackColor = true;
            this.btfiltrar.Click += new System.EventHandler(this.btfiltrar_Click);
            // 
            // Frm_ListarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btfiltrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BxPesquisa);
            this.Controls.Add(this.Rbcliente);
            this.Controls.Add(this.RbData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.GridLista);
            this.Name = "Frm_ListarVenda";
            this.Text = "Frm_ListarVenda";
            ((System.ComponentModel.ISupportInitialize)(this.GridLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RbData;
        private System.Windows.Forms.RadioButton Rbcliente;
        private System.Windows.Forms.TextBox BxPesquisa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btfiltrar;
    }
}