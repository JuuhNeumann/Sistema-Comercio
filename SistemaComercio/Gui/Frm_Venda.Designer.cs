namespace SistemaComercio.Gui
{
    partial class Frm_Venda
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelecioneProduto = new System.Windows.Forms.TextBox();
            this.lblExemplo = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbSelecioneProduto = new System.Windows.Forms.ComboBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.cmbQuantidade = new System.Windows.Forms.ComboBox();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.btnLancarVenda = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbPeriodo = new System.Windows.Forms.RadioButton();
            this.rdbCliente = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnEmitirRelatorio = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tbcVenda = new System.Windows.Forms.TabControl();
            this.tbpLancarVenda = new System.Windows.Forms.TabPage();
            this.tbpCancelarVenda = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tbcVenda.SuspendLayout();
            this.tbpLancarVenda.SuspendLayout();
            this.tbpCancelarVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.tbcVenda);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnEmitirRelatorio);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(-7, -7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 545);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o produto que deseja vender:";
            // 
            // txtSelecioneProduto
            // 
            this.txtSelecioneProduto.Enabled = false;
            this.txtSelecioneProduto.Location = new System.Drawing.Point(302, 55);
            this.txtSelecioneProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSelecioneProduto.Name = "txtSelecioneProduto";
            this.txtSelecioneProduto.Size = new System.Drawing.Size(172, 21);
            this.txtSelecioneProduto.TabIndex = 1;
            // 
            // lblExemplo
            // 
            this.lblExemplo.AutoSize = true;
            this.lblExemplo.Location = new System.Drawing.Point(306, 31);
            this.lblExemplo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExemplo.Name = "lblExemplo";
            this.lblExemplo.Size = new System.Drawing.Size(74, 13);
            this.lblExemplo.TabIndex = 2;
            this.lblExemplo.Text = "Ex: Xbox 360";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(380, 26);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // cmbSelecioneProduto
            // 
            this.cmbSelecioneProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecioneProduto.FormattingEnabled = true;
            this.cmbSelecioneProduto.Location = new System.Drawing.Point(10, 28);
            this.cmbSelecioneProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSelecioneProduto.Name = "cmbSelecioneProduto";
            this.cmbSelecioneProduto.Size = new System.Drawing.Size(294, 21);
            this.cmbSelecioneProduto.TabIndex = 3;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(7, 58);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(64, 13);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // cmbQuantidade
            // 
            this.cmbQuantidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuantidade.FormattingEnabled = true;
            this.cmbQuantidade.Location = new System.Drawing.Point(70, 55);
            this.cmbQuantidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbQuantidade.Name = "cmbQuantidade";
            this.cmbQuantidade.Size = new System.Drawing.Size(152, 21);
            this.cmbQuantidade.TabIndex = 5;
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(225, 58);
            this.lblPrecoUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(79, 13);
            this.lblPrecoUnitario.TabIndex = 6;
            this.lblPrecoUnitario.Text = "Preço Unitário:";
            // 
            // btnLancarVenda
            // 
            this.btnLancarVenda.Location = new System.Drawing.Point(104, 90);
            this.btnLancarVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLancarVenda.Name = "btnLancarVenda";
            this.btnLancarVenda.Size = new System.Drawing.Size(118, 23);
            this.btnLancarVenda.TabIndex = 7;
            this.btnLancarVenda.Text = "Lançar Venda";
            this.btnLancarVenda.UseVisualStyleBackColor = true;
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Location = new System.Drawing.Point(202, 48);
            this.btnCancelarVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(118, 23);
            this.btnCancelarVenda.TabIndex = 8;
            this.btnCancelarVenda.Text = "Cancelar Venda";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(238, 90);
            this.btnLimparCampos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(118, 23);
            this.btnLimparCampos.TabIndex = 9;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbCliente);
            this.groupBox2.Controls.Add(this.rdbPeriodo);
            this.groupBox2.Location = new System.Drawing.Point(21, 179);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(126, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Consulta";
            // 
            // rdbPeriodo
            // 
            this.rdbPeriodo.AutoSize = true;
            this.rdbPeriodo.Checked = true;
            this.rdbPeriodo.Location = new System.Drawing.Point(8, 18);
            this.rdbPeriodo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbPeriodo.Name = "rdbPeriodo";
            this.rdbPeriodo.Size = new System.Drawing.Size(62, 17);
            this.rdbPeriodo.TabIndex = 2;
            this.rdbPeriodo.TabStop = true;
            this.rdbPeriodo.Text = "Período";
            this.rdbPeriodo.UseVisualStyleBackColor = true;
            // 
            // rdbCliente
            // 
            this.rdbCliente.AutoSize = true;
            this.rdbCliente.Location = new System.Drawing.Point(8, 41);
            this.rdbCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbCliente.Name = "rdbCliente";
            this.rdbCliente.Size = new System.Drawing.Size(58, 17);
            this.rdbCliente.TabIndex = 3;
            this.rdbCliente.Text = "Cliente";
            this.rdbCliente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selecione a venda que deseja consultar após selecionar o tipo de consulta:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 216);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(437, 216);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 249);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(491, 157);
            this.dataGridView1.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.cmbSituacao);
            this.groupBox3.Controls.Add(this.lblSituacao);
            this.groupBox3.Controls.Add(this.txtHora);
            this.groupBox3.Controls.Add(this.lblHora);
            this.groupBox3.Controls.Add(this.txtData);
            this.groupBox3.Controls.Add(this.lblData);
            this.groupBox3.Location = new System.Drawing.Point(21, 412);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(492, 91);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Operacionais";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(7, 29);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(32, 13);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(42, 26);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(212, 21);
            this.txtData.TabIndex = 10;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(274, 29);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(34, 13);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "Hora:";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(309, 26);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(174, 21);
            this.txtHora.TabIndex = 12;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(7, 58);
            this.lblSituacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(50, 13);
            this.lblSituacao.TabIndex = 13;
            this.lblSituacao.Text = "Situação:";
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Location = new System.Drawing.Point(55, 55);
            this.cmbSituacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(199, 21);
            this.cmbSituacao.TabIndex = 13;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(274, 58);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(309, 55);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(174, 21);
            this.txtTotal.TabIndex = 15;
            // 
            // btnEmitirRelatorio
            // 
            this.btnEmitirRelatorio.Location = new System.Drawing.Point(21, 509);
            this.btnEmitirRelatorio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEmitirRelatorio.Name = "btnEmitirRelatorio";
            this.btnEmitirRelatorio.Size = new System.Drawing.Size(115, 23);
            this.btnEmitirRelatorio.TabIndex = 10;
            this.btnEmitirRelatorio.Text = "Emitir Relatório";
            this.btnEmitirRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(426, 509);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // tbcVenda
            // 
            this.tbcVenda.Controls.Add(this.tbpLancarVenda);
            this.tbcVenda.Controls.Add(this.tbpCancelarVenda);
            this.tbcVenda.Location = new System.Drawing.Point(19, 19);
            this.tbcVenda.Name = "tbcVenda";
            this.tbcVenda.SelectedIndex = 0;
            this.tbcVenda.Size = new System.Drawing.Size(493, 149);
            this.tbcVenda.TabIndex = 14;
            // 
            // tbpLancarVenda
            // 
            this.tbpLancarVenda.BackColor = System.Drawing.Color.MistyRose;
            this.tbpLancarVenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpLancarVenda.Controls.Add(this.btnLimparCampos);
            this.tbpLancarVenda.Controls.Add(this.cmbQuantidade);
            this.tbpLancarVenda.Controls.Add(this.btnLancarVenda);
            this.tbpLancarVenda.Controls.Add(this.label1);
            this.tbpLancarVenda.Controls.Add(this.txtSelecioneProduto);
            this.tbpLancarVenda.Controls.Add(this.btnPesquisar);
            this.tbpLancarVenda.Controls.Add(this.cmbSelecioneProduto);
            this.tbpLancarVenda.Controls.Add(this.lblExemplo);
            this.tbpLancarVenda.Controls.Add(this.lblQuantidade);
            this.tbpLancarVenda.Controls.Add(this.lblPrecoUnitario);
            this.tbpLancarVenda.Location = new System.Drawing.Point(4, 22);
            this.tbpLancarVenda.Name = "tbpLancarVenda";
            this.tbpLancarVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLancarVenda.Size = new System.Drawing.Size(485, 123);
            this.tbpLancarVenda.TabIndex = 0;
            this.tbpLancarVenda.Text = "Lançar Venda";
            // 
            // tbpCancelarVenda
            // 
            this.tbpCancelarVenda.BackColor = System.Drawing.Color.MistyRose;
            this.tbpCancelarVenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpCancelarVenda.Controls.Add(this.btnCancelarVenda);
            this.tbpCancelarVenda.Location = new System.Drawing.Point(4, 22);
            this.tbpCancelarVenda.Name = "tbpCancelarVenda";
            this.tbpCancelarVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCancelarVenda.Size = new System.Drawing.Size(485, 123);
            this.tbpCancelarVenda.TabIndex = 1;
            this.tbpCancelarVenda.Text = "Cancelar Venda";
            // 
            // Frm_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 534);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Frm_Venda";
            this.Text = "Venda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tbcVenda.ResumeLayout(false);
            this.tbpLancarVenda.ResumeLayout(false);
            this.tbpLancarVenda.PerformLayout();
            this.tbpCancelarVenda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelecioneProduto;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblExemplo;
        private System.Windows.Forms.ComboBox cmbSelecioneProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.ComboBox cmbQuantidade;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button btnLancarVenda;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbCliente;
        private System.Windows.Forms.RadioButton rdbPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEmitirRelatorio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TabControl tbcVenda;
        private System.Windows.Forms.TabPage tbpLancarVenda;
        private System.Windows.Forms.TabPage tbpCancelarVenda;
    }
}