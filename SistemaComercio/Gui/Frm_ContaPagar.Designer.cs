namespace SistemaComercio.Gui
{
    partial class Frm_ContaPagar
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
            this.gpbContaPagar = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbSelecioneCompra = new System.Windows.Forms.ComboBox();
            this.lblRespostaStatus = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSelecioneCompra = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtValorPaga = new System.Windows.Forms.TextBox();
            this.txtDataPaga = new System.Windows.Forms.TextBox();
            this.txtDataFecha = new System.Windows.Forms.TextBox();
            this.txtDataLanca = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblValorPaga = new System.Windows.Forms.Label();
            this.lblDataPaga = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDataFecha = new System.Windows.Forms.Label();
            this.lblDataLanca = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnBaixarConta = new System.Windows.Forms.Button();
            this.btnEmitirRelatorio = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbFormaPagamento = new System.Windows.Forms.GroupBox();
            this.lblSlecionePagamento = new System.Windows.Forms.Label();
            this.rdbPix = new System.Windows.Forms.RadioButton();
            this.rdbDinheiro = new System.Windows.Forms.RadioButton();
            this.rdbCartaoDebito = new System.Windows.Forms.RadioButton();
            this.rdbCartaoCredito = new System.Windows.Forms.RadioButton();
            this.cmbParcelamento = new System.Windows.Forms.ComboBox();
            this.lblParcelamento = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.gpbContaPagar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpbFormaPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbContaPagar
            // 
            this.gpbContaPagar.BackColor = System.Drawing.Color.Tan;
            this.gpbContaPagar.Controls.Add(this.btnPesquisar);
            this.gpbContaPagar.Controls.Add(this.cmbSelecioneCompra);
            this.gpbContaPagar.Controls.Add(this.lblRespostaStatus);
            this.gpbContaPagar.Controls.Add(this.txtPago);
            this.gpbContaPagar.Controls.Add(this.lblStatus);
            this.gpbContaPagar.Controls.Add(this.lblSelecioneCompra);
            this.gpbContaPagar.Controls.Add(this.txtValor);
            this.gpbContaPagar.Controls.Add(this.txtValorPaga);
            this.gpbContaPagar.Controls.Add(this.txtDataPaga);
            this.gpbContaPagar.Controls.Add(this.txtDataFecha);
            this.gpbContaPagar.Controls.Add(this.txtDataLanca);
            this.gpbContaPagar.Controls.Add(this.txtDescricao);
            this.gpbContaPagar.Controls.Add(this.lblValorPaga);
            this.gpbContaPagar.Controls.Add(this.lblDataPaga);
            this.gpbContaPagar.Controls.Add(this.lblPago);
            this.gpbContaPagar.Controls.Add(this.lblValor);
            this.gpbContaPagar.Controls.Add(this.lblDataFecha);
            this.gpbContaPagar.Controls.Add(this.lblDataLanca);
            this.gpbContaPagar.Controls.Add(this.lblDescricao);
            this.gpbContaPagar.Location = new System.Drawing.Point(14, 12);
            this.gpbContaPagar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbContaPagar.Name = "gpbContaPagar";
            this.gpbContaPagar.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbContaPagar.Size = new System.Drawing.Size(576, 177);
            this.gpbContaPagar.TabIndex = 0;
            this.gpbContaPagar.TabStop = false;
            this.gpbContaPagar.Text = "Geração de Conta a Pagar";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(466, 26);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 22);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // cmbSelecioneCompra
            // 
            this.cmbSelecioneCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecioneCompra.FormattingEnabled = true;
            this.cmbSelecioneCompra.Location = new System.Drawing.Point(187, 26);
            this.cmbSelecioneCompra.Name = "cmbSelecioneCompra";
            this.cmbSelecioneCompra.Size = new System.Drawing.Size(272, 21);
            this.cmbSelecioneCompra.TabIndex = 17;
            // 
            // lblRespostaStatus
            // 
            this.lblRespostaStatus.AutoSize = true;
            this.lblRespostaStatus.Location = new System.Drawing.Point(457, 149);
            this.lblRespostaStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespostaStatus.Name = "lblRespostaStatus";
            this.lblRespostaStatus.Size = new System.Drawing.Size(77, 13);
            this.lblRespostaStatus.TabIndex = 16;
            this.lblRespostaStatus.Text = "Conta Vencida";
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(239, 146);
            this.txtPago.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(151, 21);
            this.txtPago.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(410, 149);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 13);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status:";
            // 
            // lblSelecioneCompra
            // 
            this.lblSelecioneCompra.AutoSize = true;
            this.lblSelecioneCompra.Location = new System.Drawing.Point(7, 29);
            this.lblSelecioneCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecioneCompra.Name = "lblSelecioneCompra";
            this.lblSelecioneCompra.Size = new System.Drawing.Size(182, 13);
            this.lblSelecioneCompra.TabIndex = 14;
            this.lblSelecioneCompra.Text = "Selecione a compra que deseja pagar:";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(43, 146);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(151, 21);
            this.txtValor.TabIndex = 12;
            // 
            // txtValorPaga
            // 
            this.txtValorPaga.Enabled = false;
            this.txtValorPaga.Location = new System.Drawing.Point(397, 111);
            this.txtValorPaga.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValorPaga.Name = "txtValorPaga";
            this.txtValorPaga.Size = new System.Drawing.Size(169, 21);
            this.txtValorPaga.TabIndex = 11;
            // 
            // txtDataPaga
            // 
            this.txtDataPaga.Enabled = false;
            this.txtDataPaga.Location = new System.Drawing.Point(397, 84);
            this.txtDataPaga.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDataPaga.Name = "txtDataPaga";
            this.txtDataPaga.Size = new System.Drawing.Size(169, 21);
            this.txtDataPaga.TabIndex = 10;
            // 
            // txtDataFecha
            // 
            this.txtDataFecha.Enabled = false;
            this.txtDataFecha.Location = new System.Drawing.Point(111, 111);
            this.txtDataFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDataFecha.Name = "txtDataFecha";
            this.txtDataFecha.Size = new System.Drawing.Size(169, 21);
            this.txtDataFecha.TabIndex = 9;
            // 
            // txtDataLanca
            // 
            this.txtDataLanca.Enabled = false;
            this.txtDataLanca.Location = new System.Drawing.Point(111, 84);
            this.txtDataLanca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDataLanca.Name = "txtDataLanca";
            this.txtDataLanca.Size = new System.Drawing.Size(169, 21);
            this.txtDataLanca.TabIndex = 8;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(61, 58);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(505, 21);
            this.txtDescricao.TabIndex = 7;
            // 
            // lblValorPaga
            // 
            this.lblValorPaga.AutoSize = true;
            this.lblValorPaga.Location = new System.Drawing.Point(292, 114);
            this.lblValorPaga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorPaga.Name = "lblValorPaga";
            this.lblValorPaga.Size = new System.Drawing.Size(107, 13);
            this.lblValorPaga.TabIndex = 6;
            this.lblValorPaga.Text = "Valor do Pagamento:";
            // 
            // lblDataPaga
            // 
            this.lblDataPaga.AutoSize = true;
            this.lblDataPaga.Location = new System.Drawing.Point(297, 87);
            this.lblDataPaga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataPaga.Name = "lblDataPaga";
            this.lblDataPaga.Size = new System.Drawing.Size(102, 13);
            this.lblDataPaga.TabIndex = 5;
            this.lblDataPaga.Text = "Data do Pagamento:";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(206, 149);
            this.lblPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(34, 13);
            this.lblPago.TabIndex = 4;
            this.lblPago.Text = "Pago:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(7, 149);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor:";
            // 
            // lblDataFecha
            // 
            this.lblDataFecha.AutoSize = true;
            this.lblDataFecha.Location = new System.Drawing.Point(7, 114);
            this.lblDataFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataFecha.Name = "lblDataFecha";
            this.lblDataFecha.Size = new System.Drawing.Size(107, 13);
            this.lblDataFecha.TabIndex = 2;
            this.lblDataFecha.Text = "Data do Fechamento:";
            // 
            // lblDataLanca
            // 
            this.lblDataLanca.AutoSize = true;
            this.lblDataLanca.Location = new System.Drawing.Point(7, 88);
            this.lblDataLanca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataLanca.Name = "lblDataLanca";
            this.lblDataLanca.Size = new System.Drawing.Size(107, 13);
            this.lblDataLanca.TabIndex = 1;
            this.lblDataLanca.Text = "Data do Lançamento:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(7, 62);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(57, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";
            // 
            // btnBaixarConta
            // 
            this.btnBaixarConta.Location = new System.Drawing.Point(21, 319);
            this.btnBaixarConta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBaixarConta.Name = "btnBaixarConta";
            this.btnBaixarConta.Size = new System.Drawing.Size(114, 22);
            this.btnBaixarConta.TabIndex = 1;
            this.btnBaixarConta.Text = "Baixar Conta";
            this.btnBaixarConta.UseVisualStyleBackColor = true;
            // 
            // btnEmitirRelatorio
            // 
            this.btnEmitirRelatorio.Location = new System.Drawing.Point(143, 319);
            this.btnEmitirRelatorio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEmitirRelatorio.Name = "btnEmitirRelatorio";
            this.btnEmitirRelatorio.Size = new System.Drawing.Size(114, 22);
            this.btnEmitirRelatorio.TabIndex = 2;
            this.btnEmitirRelatorio.Text = "Emitir Relatório";
            this.btnEmitirRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(483, 319);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(114, 22);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.gpbFormaPagamento);
            this.panel1.Controls.Add(this.btnEmitirRelatorio);
            this.panel1.Controls.Add(this.btnBaixarConta);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Location = new System.Drawing.Point(-7, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 354);
            this.panel1.TabIndex = 4;
            // 
            // gpbFormaPagamento
            // 
            this.gpbFormaPagamento.Controls.Add(this.btnPagar);
            this.gpbFormaPagamento.Controls.Add(this.txtTotal);
            this.gpbFormaPagamento.Controls.Add(this.lblTotal);
            this.gpbFormaPagamento.Controls.Add(this.lblParcelamento);
            this.gpbFormaPagamento.Controls.Add(this.cmbParcelamento);
            this.gpbFormaPagamento.Controls.Add(this.rdbCartaoCredito);
            this.gpbFormaPagamento.Controls.Add(this.rdbCartaoDebito);
            this.gpbFormaPagamento.Controls.Add(this.rdbDinheiro);
            this.gpbFormaPagamento.Controls.Add(this.rdbPix);
            this.gpbFormaPagamento.Controls.Add(this.lblSlecionePagamento);
            this.gpbFormaPagamento.Location = new System.Drawing.Point(21, 201);
            this.gpbFormaPagamento.Name = "gpbFormaPagamento";
            this.gpbFormaPagamento.Size = new System.Drawing.Size(576, 112);
            this.gpbFormaPagamento.TabIndex = 4;
            this.gpbFormaPagamento.TabStop = false;
            this.gpbFormaPagamento.Text = "Forma de Pagamento";
            // 
            // lblSlecionePagamento
            // 
            this.lblSlecionePagamento.AutoSize = true;
            this.lblSlecionePagamento.Location = new System.Drawing.Point(9, 27);
            this.lblSlecionePagamento.Name = "lblSlecionePagamento";
            this.lblSlecionePagamento.Size = new System.Drawing.Size(196, 13);
            this.lblSlecionePagamento.TabIndex = 0;
            this.lblSlecionePagamento.Text = "Selecione abaixo a forma de pagamento:";
            // 
            // rdbPix
            // 
            this.rdbPix.AutoSize = true;
            this.rdbPix.Location = new System.Drawing.Point(10, 53);
            this.rdbPix.Name = "rdbPix";
            this.rdbPix.Size = new System.Drawing.Size(41, 17);
            this.rdbPix.TabIndex = 1;
            this.rdbPix.TabStop = true;
            this.rdbPix.Text = "Pix";
            this.rdbPix.UseVisualStyleBackColor = true;
            // 
            // rdbDinheiro
            // 
            this.rdbDinheiro.AutoSize = true;
            this.rdbDinheiro.Location = new System.Drawing.Point(12, 76);
            this.rdbDinheiro.Name = "rdbDinheiro";
            this.rdbDinheiro.Size = new System.Drawing.Size(67, 17);
            this.rdbDinheiro.TabIndex = 2;
            this.rdbDinheiro.TabStop = true;
            this.rdbDinheiro.Text = "Dinheiro";
            this.rdbDinheiro.UseVisualStyleBackColor = true;
            // 
            // rdbCartaoDebito
            // 
            this.rdbCartaoDebito.AutoSize = true;
            this.rdbCartaoDebito.Location = new System.Drawing.Point(111, 53);
            this.rdbCartaoDebito.Name = "rdbCartaoDebito";
            this.rdbCartaoDebito.Size = new System.Drawing.Size(105, 17);
            this.rdbCartaoDebito.TabIndex = 3;
            this.rdbCartaoDebito.TabStop = true;
            this.rdbCartaoDebito.Text = "Cartão de Débito";
            this.rdbCartaoDebito.UseVisualStyleBackColor = true;
            // 
            // rdbCartaoCredito
            // 
            this.rdbCartaoCredito.AutoSize = true;
            this.rdbCartaoCredito.Location = new System.Drawing.Point(111, 76);
            this.rdbCartaoCredito.Name = "rdbCartaoCredito";
            this.rdbCartaoCredito.Size = new System.Drawing.Size(108, 17);
            this.rdbCartaoCredito.TabIndex = 4;
            this.rdbCartaoCredito.TabStop = true;
            this.rdbCartaoCredito.Text = "Cartão de Crédito";
            this.rdbCartaoCredito.UseVisualStyleBackColor = true;
            // 
            // cmbParcelamento
            // 
            this.cmbParcelamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParcelamento.FormattingEnabled = true;
            this.cmbParcelamento.Items.AddRange(new object[] {
            "1x sem juros",
            "2x sem juros",
            "3x sem juros",
            "4x sem juros",
            "5x sem juros"});
            this.cmbParcelamento.Location = new System.Drawing.Point(252, 69);
            this.cmbParcelamento.Name = "cmbParcelamento";
            this.cmbParcelamento.Size = new System.Drawing.Size(147, 21);
            this.cmbParcelamento.TabIndex = 5;
            // 
            // lblParcelamento
            // 
            this.lblParcelamento.AutoSize = true;
            this.lblParcelamento.Location = new System.Drawing.Point(249, 53);
            this.lblParcelamento.Name = "lblParcelamento";
            this.lblParcelamento.Size = new System.Drawing.Size(73, 13);
            this.lblParcelamento.TabIndex = 6;
            this.lblParcelamento.Text = "Parcelamento:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(394, 27);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(426, 24);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(140, 21);
            this.txtTotal.TabIndex = 8;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(436, 67);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(120, 23);
            this.btnPagar.TabIndex = 9;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // Frm_ContaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 344);
            this.Controls.Add(this.gpbContaPagar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Frm_ContaPagar";
            this.Text = "Contas a Pagar";
            this.gpbContaPagar.ResumeLayout(false);
            this.gpbContaPagar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gpbFormaPagamento.ResumeLayout(false);
            this.gpbFormaPagamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbContaPagar;
        private System.Windows.Forms.Label lblDataLanca;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblDataFecha;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtValorPaga;
        private System.Windows.Forms.TextBox txtDataPaga;
        private System.Windows.Forms.TextBox txtDataFecha;
        private System.Windows.Forms.TextBox txtDataLanca;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblValorPaga;
        private System.Windows.Forms.Label lblDataPaga;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblSelecioneCompra;
        private System.Windows.Forms.Button btnBaixarConta;
        private System.Windows.Forms.Label lblRespostaStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnEmitirRelatorio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cmbSelecioneCompra;
        private System.Windows.Forms.GroupBox gpbFormaPagamento;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblParcelamento;
        private System.Windows.Forms.ComboBox cmbParcelamento;
        private System.Windows.Forms.RadioButton rdbCartaoCredito;
        private System.Windows.Forms.RadioButton rdbCartaoDebito;
        private System.Windows.Forms.RadioButton rdbDinheiro;
        private System.Windows.Forms.RadioButton rdbPix;
        private System.Windows.Forms.Label lblSlecionePagamento;
    }
}