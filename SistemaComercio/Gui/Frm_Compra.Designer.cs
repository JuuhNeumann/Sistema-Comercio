namespace SistemaComercio.Gui
{
    partial class Frm_Compra
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
            this.gpbDadosOperacionais = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblSelecionarProduto = new System.Windows.Forms.Label();
            this.lblExemplo = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.cmbQuant = new System.Windows.Forms.ComboBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.gpbDadosGerais = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpbConsulta = new System.Windows.Forms.GroupBox();
            this.rdbForne = new System.Windows.Forms.RadioButton();
            this.rdbPeriodo = new System.Windows.Forms.RadioButton();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbConsulta = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSelecioneProduto = new System.Windows.Forms.ComboBox();
            this.gpbDadosOperacionais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbDadosGerais.SuspendLayout();
            this.gpbConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDadosOperacionais
            // 
            this.gpbDadosOperacionais.BackColor = System.Drawing.Color.LightYellow;
            this.gpbDadosOperacionais.Controls.Add(this.txtTotal);
            this.gpbDadosOperacionais.Controls.Add(this.cmbSituacao);
            this.gpbDadosOperacionais.Controls.Add(this.lblTotal);
            this.gpbDadosOperacionais.Controls.Add(this.txtHora);
            this.gpbDadosOperacionais.Controls.Add(this.lblSituacao);
            this.gpbDadosOperacionais.Controls.Add(this.txtData);
            this.gpbDadosOperacionais.Controls.Add(this.lblHora);
            this.gpbDadosOperacionais.Controls.Add(this.lblData);
            this.gpbDadosOperacionais.Location = new System.Drawing.Point(14, 400);
            this.gpbDadosOperacionais.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbDadosOperacionais.Name = "gpbDadosOperacionais";
            this.gpbDadosOperacionais.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbDadosOperacionais.Size = new System.Drawing.Size(492, 91);
            this.gpbDadosOperacionais.TabIndex = 0;
            this.gpbDadosOperacionais.TabStop = false;
            this.gpbDadosOperacionais.Text = "Dados Operacionais";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(310, 53);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(174, 21);
            this.txtTotal.TabIndex = 4;
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Items.AddRange(new object[] {
            "Finalizado",
            "Cancelado"});
            this.cmbSituacao.Location = new System.Drawing.Point(64, 53);
            this.cmbSituacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(190, 21);
            this.cmbSituacao.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(273, 56);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // txtHora
            // 
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(310, 24);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(174, 21);
            this.txtHora.TabIndex = 3;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(7, 56);
            this.lblSituacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(50, 13);
            this.lblSituacao.TabIndex = 5;
            this.lblSituacao.Text = "Situação:";
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(42, 24);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(212, 21);
            this.txtData.TabIndex = 2;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(273, 27);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(34, 13);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "Hora:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(7, 27);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(32, 13);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data:";
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(14, 497);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(115, 23);
            this.btnRelatorio.TabIndex = 1;
            this.btnRelatorio.Text = "Emitir Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(420, 497);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // lblSelecionarProduto
            // 
            this.lblSelecionarProduto.AutoSize = true;
            this.lblSelecionarProduto.Location = new System.Drawing.Point(7, 26);
            this.lblSelecionarProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecionarProduto.Name = "lblSelecionarProduto";
            this.lblSelecionarProduto.Size = new System.Drawing.Size(198, 13);
            this.lblSelecionarProduto.TabIndex = 3;
            this.lblSelecionarProduto.Text = "Selecione o produto que deseja comprar:";
            // 
            // lblExemplo
            // 
            this.lblExemplo.AutoSize = true;
            this.lblExemplo.Location = new System.Drawing.Point(307, 45);
            this.lblExemplo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExemplo.Name = "lblExemplo";
            this.lblExemplo.Size = new System.Drawing.Size(74, 13);
            this.lblExemplo.TabIndex = 5;
            this.lblExemplo.Text = "Ex: Xbox 360";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(389, 39);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 23);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 214);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(491, 180);
            this.dataGridView1.TabIndex = 7;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(230, 71);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(76, 13);
            this.lblPreco.TabIndex = 8;
            this.lblPreco.Text = "Preço unitário:";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(7, 72);
            this.lblQuant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(64, 13);
            this.lblQuant.TabIndex = 9;
            this.lblQuant.Text = "Quantidade:";
            // 
            // cmbQuant
            // 
            this.cmbQuant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuant.FormattingEnabled = true;
            this.cmbQuant.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbQuant.Location = new System.Drawing.Point(70, 68);
            this.cmbQuant.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbQuant.Name = "cmbQuant";
            this.cmbQuant.Size = new System.Drawing.Size(152, 21);
            this.cmbQuant.TabIndex = 7;
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(303, 68);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(180, 21);
            this.txtPreco.TabIndex = 7;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(64, 101);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(118, 23);
            this.btnComprar.TabIndex = 10;
            this.btnComprar.Text = "Lançar Compra";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.Location = new System.Drawing.Point(190, 101);
            this.btnCancelarCompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(118, 23);
            this.btnCancelarCompra.TabIndex = 11;
            this.btnCancelarCompra.Text = "Cancelar Compra";
            this.btnCancelarCompra.UseVisualStyleBackColor = true;
            // 
            // gpbDadosGerais
            // 
            this.gpbDadosGerais.BackColor = System.Drawing.Color.LightYellow;
            this.gpbDadosGerais.Controls.Add(this.cmbSelecioneProduto);
            this.gpbDadosGerais.Controls.Add(this.btnLimpar);
            this.gpbDadosGerais.Controls.Add(this.btnPesquisar);
            this.gpbDadosGerais.Controls.Add(this.btnCancelarCompra);
            this.gpbDadosGerais.Controls.Add(this.lblSelecionarProduto);
            this.gpbDadosGerais.Controls.Add(this.btnComprar);
            this.gpbDadosGerais.Controls.Add(this.lblExemplo);
            this.gpbDadosGerais.Controls.Add(this.txtPreco);
            this.gpbDadosGerais.Controls.Add(this.lblPreco);
            this.gpbDadosGerais.Controls.Add(this.cmbQuant);
            this.gpbDadosGerais.Controls.Add(this.lblQuant);
            this.gpbDadosGerais.Location = new System.Drawing.Point(14, 8);
            this.gpbDadosGerais.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbDadosGerais.Name = "gpbDadosGerais";
            this.gpbDadosGerais.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbDadosGerais.Size = new System.Drawing.Size(491, 130);
            this.gpbDadosGerais.TabIndex = 7;
            this.gpbDadosGerais.TabStop = false;
            this.gpbDadosGerais.Text = "Dados Gerais";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(316, 101);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // gpbConsulta
            // 
            this.gpbConsulta.BackColor = System.Drawing.Color.LightYellow;
            this.gpbConsulta.Controls.Add(this.rdbForne);
            this.gpbConsulta.Controls.Add(this.rdbPeriodo);
            this.gpbConsulta.Location = new System.Drawing.Point(14, 144);
            this.gpbConsulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbConsulta.Name = "gpbConsulta";
            this.gpbConsulta.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbConsulta.Size = new System.Drawing.Size(126, 64);
            this.gpbConsulta.TabIndex = 13;
            this.gpbConsulta.TabStop = false;
            this.gpbConsulta.Text = "Tipo de Consulta:";
            // 
            // rdbForne
            // 
            this.rdbForne.AutoSize = true;
            this.rdbForne.Location = new System.Drawing.Point(10, 42);
            this.rdbForne.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbForne.Name = "rdbForne";
            this.rdbForne.Size = new System.Drawing.Size(79, 17);
            this.rdbForne.TabIndex = 15;
            this.rdbForne.TabStop = true;
            this.rdbForne.Text = "Fornecedor";
            this.rdbForne.UseVisualStyleBackColor = true;
            // 
            // rdbPeriodo
            // 
            this.rdbPeriodo.AutoSize = true;
            this.rdbPeriodo.Location = new System.Drawing.Point(10, 19);
            this.rdbPeriodo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbPeriodo.Name = "rdbPeriodo";
            this.rdbPeriodo.Size = new System.Drawing.Size(62, 17);
            this.rdbPeriodo.TabIndex = 14;
            this.rdbPeriodo.TabStop = true;
            this.rdbPeriodo.Text = "Período";
            this.rdbPeriodo.UseVisualStyleBackColor = true;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.BackColor = System.Drawing.Color.LightYellow;
            this.lblConsulta.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(148, 157);
            this.lblConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(360, 13);
            this.lblConsulta.TabIndex = 13;
            this.lblConsulta.Text = "Selecione a compra que deseja consultar após selecionar o tipo de consulta:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(430, 173);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // cmbConsulta
            // 
            this.cmbConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsulta.FormattingEnabled = true;
            this.cmbConsulta.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbConsulta.Location = new System.Drawing.Point(151, 173);
            this.cmbConsulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbConsulta.Name = "cmbConsulta";
            this.cmbConsulta.Size = new System.Drawing.Size(272, 21);
            this.cmbConsulta.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Location = new System.Drawing.Point(-3, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 543);
            this.panel1.TabIndex = 15;
            // 
            // cmbSelecioneProduto
            // 
            this.cmbSelecioneProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecioneProduto.FormattingEnabled = true;
            this.cmbSelecioneProduto.Items.AddRange(new object[] {
            "Finalizado",
            "Cancelado"});
            this.cmbSelecioneProduto.Location = new System.Drawing.Point(8, 42);
            this.cmbSelecioneProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSelecioneProduto.Name = "cmbSelecioneProduto";
            this.cmbSelecioneProduto.Size = new System.Drawing.Size(300, 21);
            this.cmbSelecioneProduto.TabIndex = 13;
            // 
            // Frm_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 532);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.gpbDadosOperacionais);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cmbConsulta);
            this.Controls.Add(this.gpbConsulta);
            this.Controls.Add(this.gpbDadosGerais);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Frm_Compra";
            this.Text = "Compra";
            this.gpbDadosOperacionais.ResumeLayout(false);
            this.gpbDadosOperacionais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbDadosGerais.ResumeLayout(false);
            this.gpbDadosGerais.PerformLayout();
            this.gpbConsulta.ResumeLayout(false);
            this.gpbConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadosOperacionais;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblSelecionarProduto;
        private System.Windows.Forms.Label lblExemplo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.ComboBox cmbQuant;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.GroupBox gpbDadosGerais;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gpbConsulta;
        private System.Windows.Forms.RadioButton rdbForne;
        private System.Windows.Forms.RadioButton rdbPeriodo;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmbConsulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSelecioneProduto;
    }
}