namespace SistemaComercio.Gui
{
    partial class Frm_ContaReceber
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEmitirRela = new System.Windows.Forms.Button();
            this.btnBaixarConta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblExemploStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValorRecebi = new System.Windows.Forms.TextBox();
            this.lblValorRecebi = new System.Windows.Forms.Label();
            this.txtDataRecebi = new System.Windows.Forms.TextBox();
            this.lblDataRecebi = new System.Windows.Forms.Label();
            this.txtDataVenci = new System.Windows.Forms.TextBox();
            this.lblDataVenci = new System.Windows.Forms.Label();
            this.txtDataLanca = new System.Windows.Forms.TextBox();
            this.lblDataLanca = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbSelecioneContaReceber = new System.Windows.Forms.ComboBox();
            this.lblSelecioneContaReceber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnEmitirRela);
            this.panel1.Controls.Add(this.btnBaixarConta);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-5, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 250);
            this.panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(504, 210);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnEmitirRela
            // 
            this.btnEmitirRela.Location = new System.Drawing.Point(139, 210);
            this.btnEmitirRela.Name = "btnEmitirRela";
            this.btnEmitirRela.Size = new System.Drawing.Size(113, 23);
            this.btnEmitirRela.TabIndex = 3;
            this.btnEmitirRela.Text = "Emitir Relatório";
            this.btnEmitirRela.UseVisualStyleBackColor = true;
            // 
            // btnBaixarConta
            // 
            this.btnBaixarConta.Location = new System.Drawing.Point(17, 210);
            this.btnBaixarConta.Name = "btnBaixarConta";
            this.btnBaixarConta.Size = new System.Drawing.Size(113, 23);
            this.btnBaixarConta.TabIndex = 2;
            this.btnBaixarConta.Text = "Baixar Conta";
            this.btnBaixarConta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblExemploStatus);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.txtPago);
            this.groupBox1.Controls.Add(this.lblPago);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.txtValorRecebi);
            this.groupBox1.Controls.Add(this.lblValorRecebi);
            this.groupBox1.Controls.Add(this.txtDataRecebi);
            this.groupBox1.Controls.Add(this.lblDataRecebi);
            this.groupBox1.Controls.Add(this.txtDataVenci);
            this.groupBox1.Controls.Add(this.lblDataVenci);
            this.groupBox1.Controls.Add(this.txtDataLanca);
            this.groupBox1.Controls.Add(this.lblDataLanca);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.cmbSelecioneContaReceber);
            this.groupBox1.Controls.Add(this.lblSelecioneContaReceber);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geração de Conta a Receber";
            // 
            // lblExemploStatus
            // 
            this.lblExemploStatus.AutoSize = true;
            this.lblExemploStatus.Location = new System.Drawing.Point(442, 152);
            this.lblExemploStatus.Name = "lblExemploStatus";
            this.lblExemploStatus.Size = new System.Drawing.Size(116, 13);
            this.lblExemploStatus.TabIndex = 18;
            this.lblExemploStatus.Text = "Conta ainda por vencer";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(397, 152);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 13);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status:";
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(241, 149);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(140, 21);
            this.txtPago.TabIndex = 16;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(189, 152);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(54, 13);
            this.lblPago.TabIndex = 15;
            this.lblPago.Text = "Recebido:";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(39, 149);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(138, 21);
            this.txtValor.TabIndex = 14;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(6, 152);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 13);
            this.lblValor.TabIndex = 13;
            this.lblValor.Text = "Valor:";
            // 
            // txtValorRecebi
            // 
            this.txtValorRecebi.Enabled = false;
            this.txtValorRecebi.Location = new System.Drawing.Point(412, 112);
            this.txtValorRecebi.Name = "txtValorRecebi";
            this.txtValorRecebi.Size = new System.Drawing.Size(158, 21);
            this.txtValorRecebi.TabIndex = 12;
            // 
            // lblValorRecebi
            // 
            this.lblValorRecebi.AutoSize = true;
            this.lblValorRecebi.Location = new System.Drawing.Point(290, 115);
            this.lblValorRecebi.Name = "lblValorRecebi";
            this.lblValorRecebi.Size = new System.Drawing.Size(116, 13);
            this.lblValorRecebi.TabIndex = 11;
            this.lblValorRecebi.Text = "Valor do Recebimento:";
            // 
            // txtDataRecebi
            // 
            this.txtDataRecebi.Enabled = false;
            this.txtDataRecebi.Location = new System.Drawing.Point(412, 86);
            this.txtDataRecebi.Name = "txtDataRecebi";
            this.txtDataRecebi.Size = new System.Drawing.Size(158, 21);
            this.txtDataRecebi.TabIndex = 10;
            // 
            // lblDataRecebi
            // 
            this.lblDataRecebi.AutoSize = true;
            this.lblDataRecebi.Location = new System.Drawing.Point(295, 89);
            this.lblDataRecebi.Name = "lblDataRecebi";
            this.lblDataRecebi.Size = new System.Drawing.Size(111, 13);
            this.lblDataRecebi.TabIndex = 9;
            this.lblDataRecebi.Text = "Data do Recebimento:";
            // 
            // txtDataVenci
            // 
            this.txtDataVenci.Enabled = false;
            this.txtDataVenci.Location = new System.Drawing.Point(110, 117);
            this.txtDataVenci.Name = "txtDataVenci";
            this.txtDataVenci.Size = new System.Drawing.Size(174, 21);
            this.txtDataVenci.TabIndex = 8;
            // 
            // lblDataVenci
            // 
            this.lblDataVenci.AutoSize = true;
            this.lblDataVenci.Location = new System.Drawing.Point(6, 120);
            this.lblDataVenci.Name = "lblDataVenci";
            this.lblDataVenci.Size = new System.Drawing.Size(107, 13);
            this.lblDataVenci.TabIndex = 7;
            this.lblDataVenci.Text = "Data do Vencimento:";
            // 
            // txtDataLanca
            // 
            this.txtDataLanca.Enabled = false;
            this.txtDataLanca.Location = new System.Drawing.Point(110, 86);
            this.txtDataLanca.Name = "txtDataLanca";
            this.txtDataLanca.Size = new System.Drawing.Size(174, 21);
            this.txtDataLanca.TabIndex = 6;
            // 
            // lblDataLanca
            // 
            this.lblDataLanca.AutoSize = true;
            this.lblDataLanca.Location = new System.Drawing.Point(6, 89);
            this.lblDataLanca.Name = "lblDataLanca";
            this.lblDataLanca.Size = new System.Drawing.Size(107, 13);
            this.lblDataLanca.TabIndex = 5;
            this.lblDataLanca.Text = "Data do Lançamento:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(60, 59);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(510, 21);
            this.txtDescricao.TabIndex = 4;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 62);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(57, 13);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descrição:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(471, 29);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(99, 21);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // cmbSelecioneContaReceber
            // 
            this.cmbSelecioneContaReceber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecioneContaReceber.FormattingEnabled = true;
            this.cmbSelecioneContaReceber.Location = new System.Drawing.Point(192, 29);
            this.cmbSelecioneContaReceber.Name = "cmbSelecioneContaReceber";
            this.cmbSelecioneContaReceber.Size = new System.Drawing.Size(273, 21);
            this.cmbSelecioneContaReceber.TabIndex = 1;
            // 
            // lblSelecioneContaReceber
            // 
            this.lblSelecioneContaReceber.AutoSize = true;
            this.lblSelecioneContaReceber.Location = new System.Drawing.Point(6, 32);
            this.lblSelecioneContaReceber.Name = "lblSelecioneContaReceber";
            this.lblSelecioneContaReceber.Size = new System.Drawing.Size(183, 13);
            this.lblSelecioneContaReceber.TabIndex = 0;
            this.lblSelecioneContaReceber.Text = "Selecione a venda que deseja receber:";
            // 
            // Frm_ContaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 239);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Frm_ContaReceber";
            this.Text = "Conta a Receber";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelecioneContaReceber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSelecioneContaReceber;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblDataVenci;
        private System.Windows.Forms.TextBox txtDataLanca;
        private System.Windows.Forms.Label lblDataLanca;
        private System.Windows.Forms.TextBox txtDataVenci;
        private System.Windows.Forms.TextBox txtValorRecebi;
        private System.Windows.Forms.Label lblValorRecebi;
        private System.Windows.Forms.TextBox txtDataRecebi;
        private System.Windows.Forms.Label lblDataRecebi;
        private System.Windows.Forms.Label lblExemploStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnBaixarConta;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEmitirRela;
    }
}