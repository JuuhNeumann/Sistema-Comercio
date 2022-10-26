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
            this.DataGridItemVenda = new System.Windows.Forms.DataGridView();
            this.ClienteLabel = new System.Windows.Forms.Label();
            this.BtSelecionarCliente = new System.Windows.Forms.Button();
            this.RbCredito = new System.Windows.Forms.RadioButton();
            this.LbVenda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbProduto = new System.Windows.Forms.Label();
            this.BtProcurar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.LbPreco = new System.Windows.Forms.Label();
            this.RbDinheiro = new System.Windows.Forms.RadioButton();
            this.RbBoleto = new System.Windows.Forms.RadioButton();
            this.RbDebito = new System.Windows.Forms.RadioButton();
            this.BxCliente = new System.Windows.Forms.TextBox();
            this.BxQuantidade = new System.Windows.Forms.NumericUpDown();
            this.LbCliente = new System.Windows.Forms.Label();
            this.BxProcurar = new System.Windows.Forms.TextBox();
            this.LbNome = new System.Windows.Forms.Label();
            this.BtFinalizar = new System.Windows.Forms.Button();
            this.LbQuantidade = new System.Windows.Forms.Label();
            this.LbTotalItem = new System.Windows.Forms.Label();
            this.LbSubTotal = new System.Windows.Forms.Label();
            this.BtRemoverCarrinho = new System.Windows.Forms.Button();
            this.BxTotal = new System.Windows.Forms.TextBox();
            this.BxPreco = new System.Windows.Forms.TextBox();
            this.btAdicionarCarrinho = new System.Windows.Forms.Button();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btlistar = new System.Windows.Forms.Button();
            this.btcancelarvenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridItemVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BxQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridItemVenda
            // 
            this.DataGridItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridItemVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.dataGridViewTextBoxColumn5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DataGridItemVenda.Location = new System.Drawing.Point(12, 41);
            this.DataGridItemVenda.Name = "DataGridItemVenda";
            this.DataGridItemVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridItemVenda.Size = new System.Drawing.Size(535, 435);
            this.DataGridItemVenda.TabIndex = 24;
            this.DataGridItemVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridItemVenda_CellContentClick);
            // 
            // ClienteLabel
            // 
            this.ClienteLabel.AutoSize = true;
            this.ClienteLabel.Location = new System.Drawing.Point(553, 31);
            this.ClienteLabel.Name = "ClienteLabel";
            this.ClienteLabel.Size = new System.Drawing.Size(39, 13);
            this.ClienteLabel.TabIndex = 1;
            this.ClienteLabel.Text = "Cliente";
            // 
            // BtSelecionarCliente
            // 
            this.BtSelecionarCliente.Location = new System.Drawing.Point(737, 28);
            this.BtSelecionarCliente.Name = "BtSelecionarCliente";
            this.BtSelecionarCliente.Size = new System.Drawing.Size(75, 23);
            this.BtSelecionarCliente.TabIndex = 2;
            this.BtSelecionarCliente.Text = "Busca";
            this.BtSelecionarCliente.UseVisualStyleBackColor = true;
            this.BtSelecionarCliente.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // RbCredito
            // 
            this.RbCredito.AutoSize = true;
            this.RbCredito.Location = new System.Drawing.Point(633, 390);
            this.RbCredito.Name = "RbCredito";
            this.RbCredito.Size = new System.Drawing.Size(58, 17);
            this.RbCredito.TabIndex = 3;
            this.RbCredito.TabStop = true;
            this.RbCredito.Text = "Credito";
            this.RbCredito.UseVisualStyleBackColor = true;
            // 
            // LbVenda
            // 
            this.LbVenda.AutoSize = true;
            this.LbVenda.Location = new System.Drawing.Point(12, 9);
            this.LbVenda.Name = "LbVenda";
            this.LbVenda.Size = new System.Drawing.Size(59, 13);
            this.LbVenda.TabIndex = 4;
            this.LbVenda.Text = "Venda Nº: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pagamento";
            // 
            // LbProduto
            // 
            this.LbProduto.AutoSize = true;
            this.LbProduto.Location = new System.Drawing.Point(553, 130);
            this.LbProduto.Name = "LbProduto";
            this.LbProduto.Size = new System.Drawing.Size(89, 13);
            this.LbProduto.TabIndex = 6;
            this.LbProduto.Text = "Procurar produto:";
            // 
            // BtProcurar
            // 
            this.BtProcurar.Location = new System.Drawing.Point(775, 164);
            this.BtProcurar.Name = "BtProcurar";
            this.BtProcurar.Size = new System.Drawing.Size(96, 23);
            this.BtProcurar.TabIndex = 8;
            this.BtProcurar.Text = "Procurar";
            this.BtProcurar.UseVisualStyleBackColor = true;
            this.BtProcurar.Click += new System.EventHandler(this.AdicionarButton_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(526, 524);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(148, 55);
            this.BtCancelar.TabIndex = 9;
            this.BtCancelar.Text = "Cancelar compra";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.FinalizarButton_Click);
            // 
            // LbPreco
            // 
            this.LbPreco.AutoSize = true;
            this.LbPreco.Location = new System.Drawing.Point(571, 275);
            this.LbPreco.Name = "LbPreco";
            this.LbPreco.Size = new System.Drawing.Size(74, 13);
            this.LbPreco.TabIndex = 10;
            this.LbPreco.Text = "Preço Unitario";
            // 
            // RbDinheiro
            // 
            this.RbDinheiro.AutoSize = true;
            this.RbDinheiro.Location = new System.Drawing.Point(633, 436);
            this.RbDinheiro.Name = "RbDinheiro";
            this.RbDinheiro.Size = new System.Drawing.Size(64, 17);
            this.RbDinheiro.TabIndex = 11;
            this.RbDinheiro.TabStop = true;
            this.RbDinheiro.Text = "Dinheiro";
            this.RbDinheiro.UseVisualStyleBackColor = true;
            // 
            // RbBoleto
            // 
            this.RbBoleto.AutoSize = true;
            this.RbBoleto.Location = new System.Drawing.Point(633, 459);
            this.RbBoleto.Name = "RbBoleto";
            this.RbBoleto.Size = new System.Drawing.Size(55, 17);
            this.RbBoleto.TabIndex = 12;
            this.RbBoleto.TabStop = true;
            this.RbBoleto.Text = "Boleto";
            this.RbBoleto.UseVisualStyleBackColor = true;
            // 
            // RbDebito
            // 
            this.RbDebito.AutoSize = true;
            this.RbDebito.Location = new System.Drawing.Point(632, 413);
            this.RbDebito.Name = "RbDebito";
            this.RbDebito.Size = new System.Drawing.Size(56, 17);
            this.RbDebito.TabIndex = 13;
            this.RbDebito.TabStop = true;
            this.RbDebito.Text = "Debito";
            this.RbDebito.UseVisualStyleBackColor = true;
            this.RbDebito.CheckedChanged += new System.EventHandler(this.rbDebito_CheckedChanged);
            // 
            // BxCliente
            // 
            this.BxCliente.Location = new System.Drawing.Point(598, 28);
            this.BxCliente.Name = "BxCliente";
            this.BxCliente.Size = new System.Drawing.Size(120, 20);
            this.BxCliente.TabIndex = 14;
            // 
            // BxQuantidade
            // 
            this.BxQuantidade.Location = new System.Drawing.Point(651, 167);
            this.BxQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BxQuantidade.Name = "BxQuantidade";
            this.BxQuantidade.Size = new System.Drawing.Size(120, 20);
            this.BxQuantidade.TabIndex = 15;
            this.BxQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LbCliente
            // 
            this.LbCliente.AutoSize = true;
            this.LbCliente.Location = new System.Drawing.Point(683, 69);
            this.LbCliente.Name = "LbCliente";
            this.LbCliente.Size = new System.Drawing.Size(106, 13);
            this.LbCliente.TabIndex = 17;
            this.LbCliente.Text = "NOME DO CLIENTE";
            // 
            // BxProcurar
            // 
            this.BxProcurar.Location = new System.Drawing.Point(651, 127);
            this.BxProcurar.Name = "BxProcurar";
            this.BxProcurar.Size = new System.Drawing.Size(100, 20);
            this.BxProcurar.TabIndex = 19;
            // 
            // LbNome
            // 
            this.LbNome.AutoSize = true;
            this.LbNome.Location = new System.Drawing.Point(674, 240);
            this.LbNome.Name = "LbNome";
            this.LbNome.Size = new System.Drawing.Size(115, 13);
            this.LbNome.TabIndex = 21;
            this.LbNome.Text = "NOME DO PRODUTO";
            // 
            // BtFinalizar
            // 
            this.BtFinalizar.Location = new System.Drawing.Point(697, 524);
            this.BtFinalizar.Name = "BtFinalizar";
            this.BtFinalizar.Size = new System.Drawing.Size(155, 55);
            this.BtFinalizar.TabIndex = 22;
            this.BtFinalizar.Text = "Finalizar compra";
            this.BtFinalizar.UseVisualStyleBackColor = true;
            this.BtFinalizar.Click += new System.EventHandler(this.BtFinalizar_Click);
            // 
            // LbQuantidade
            // 
            this.LbQuantidade.AutoSize = true;
            this.LbQuantidade.Location = new System.Drawing.Point(580, 167);
            this.LbQuantidade.Name = "LbQuantidade";
            this.LbQuantidade.Size = new System.Drawing.Size(65, 13);
            this.LbQuantidade.TabIndex = 23;
            this.LbQuantidade.Text = "Quantidade:";
            // 
            // LbTotalItem
            // 
            this.LbTotalItem.AutoSize = true;
            this.LbTotalItem.Location = new System.Drawing.Point(580, 312);
            this.LbTotalItem.Name = "LbTotalItem";
            this.LbTotalItem.Size = new System.Drawing.Size(56, 13);
            this.LbTotalItem.TabIndex = 24;
            this.LbTotalItem.Text = "Total item:";
            // 
            // LbSubTotal
            // 
            this.LbSubTotal.AutoSize = true;
            this.LbSubTotal.Location = new System.Drawing.Point(21, 513);
            this.LbSubTotal.Name = "LbSubTotal";
            this.LbSubTotal.Size = new System.Drawing.Size(97, 13);
            this.LbSubTotal.TabIndex = 25;
            this.LbSubTotal.Text = "Sub-Total: R$ 0,00";
            // 
            // BtRemoverCarrinho
            // 
            this.BtRemoverCarrinho.Location = new System.Drawing.Point(210, 482);
            this.BtRemoverCarrinho.Name = "BtRemoverCarrinho";
            this.BtRemoverCarrinho.Size = new System.Drawing.Size(138, 57);
            this.BtRemoverCarrinho.TabIndex = 26;
            this.BtRemoverCarrinho.Text = "Remover do carrinho";
            this.BtRemoverCarrinho.UseVisualStyleBackColor = true;
            this.BtRemoverCarrinho.Click += new System.EventHandler(this.BtRemoverCarrinho_Click);
            // 
            // BxTotal
            // 
            this.BxTotal.Location = new System.Drawing.Point(651, 309);
            this.BxTotal.Name = "BxTotal";
            this.BxTotal.Size = new System.Drawing.Size(100, 20);
            this.BxTotal.TabIndex = 27;
            this.BxTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BxPreco
            // 
            this.BxPreco.Location = new System.Drawing.Point(651, 272);
            this.BxPreco.Name = "BxPreco";
            this.BxPreco.Size = new System.Drawing.Size(100, 20);
            this.BxPreco.TabIndex = 28;
            // 
            // btAdicionarCarrinho
            // 
            this.btAdicionarCarrinho.Location = new System.Drawing.Point(651, 335);
            this.btAdicionarCarrinho.Name = "btAdicionarCarrinho";
            this.btAdicionarCarrinho.Size = new System.Drawing.Size(138, 38);
            this.btAdicionarCarrinho.TabIndex = 29;
            this.btAdicionarCarrinho.Text = "Adicionar no carrinho";
            this.btAdicionarCarrinho.UseVisualStyleBackColor = true;
            this.btAdicionarCarrinho.Click += new System.EventHandler(this.btAdicionarCarrinho_Click);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "N";
            this.Column5.Name = "Column5";
            this.Column5.Width = 40;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Cod";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Produto";
            this.Column1.Name = "Column1";
            this.Column1.Width = 235;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Qtd";
            this.Column2.Name = "Column2";
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Unidade";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "PRODUTO: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "CLIENTE: ";
            // 
            // btlistar
            // 
            this.btlistar.Location = new System.Drawing.Point(33, 574);
            this.btlistar.Name = "btlistar";
            this.btlistar.Size = new System.Drawing.Size(138, 37);
            this.btlistar.TabIndex = 32;
            this.btlistar.Text = "Listar Vendas";
            this.btlistar.UseVisualStyleBackColor = true;
            this.btlistar.Click += new System.EventHandler(this.btlistar_Click);
            // 
            // btcancelarvenda
            // 
            this.btcancelarvenda.Location = new System.Drawing.Point(177, 574);
            this.btcancelarvenda.Name = "btcancelarvenda";
            this.btcancelarvenda.Size = new System.Drawing.Size(138, 37);
            this.btcancelarvenda.TabIndex = 33;
            this.btcancelarvenda.Text = "Cancelar Vendas";
            this.btcancelarvenda.UseVisualStyleBackColor = true;
            this.btcancelarvenda.Click += new System.EventHandler(this.btcancelarvenda_Click);
            // 
            // Frm_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 623);
            this.Controls.Add(this.btcancelarvenda);
            this.Controls.Add(this.btlistar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdicionarCarrinho);
            this.Controls.Add(this.BxPreco);
            this.Controls.Add(this.BxTotal);
            this.Controls.Add(this.BtRemoverCarrinho);
            this.Controls.Add(this.LbSubTotal);
            this.Controls.Add(this.LbTotalItem);
            this.Controls.Add(this.LbQuantidade);
            this.Controls.Add(this.BtFinalizar);
            this.Controls.Add(this.LbNome);
            this.Controls.Add(this.BxProcurar);
            this.Controls.Add(this.LbCliente);
            this.Controls.Add(this.BxQuantidade);
            this.Controls.Add(this.BxCliente);
            this.Controls.Add(this.RbDebito);
            this.Controls.Add(this.RbBoleto);
            this.Controls.Add(this.RbDinheiro);
            this.Controls.Add(this.LbPreco);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtProcurar);
            this.Controls.Add(this.LbProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbVenda);
            this.Controls.Add(this.RbCredito);
            this.Controls.Add(this.BtSelecionarCliente);
            this.Controls.Add(this.ClienteLabel);
            this.Controls.Add(this.DataGridItemVenda);
            this.Name = "Frm_Venda";
            this.Text = "Frm_Venda";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridItemVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BxQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridItemVenda;
        private System.Windows.Forms.Label ClienteLabel;
        private System.Windows.Forms.Button BtSelecionarCliente;
        private System.Windows.Forms.RadioButton RbCredito;
        private System.Windows.Forms.Label LbVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbProduto;
        private System.Windows.Forms.Button BtProcurar;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Label LbPreco;
        private System.Windows.Forms.RadioButton RbDinheiro;
        private System.Windows.Forms.RadioButton RbBoleto;
        private System.Windows.Forms.RadioButton RbDebito;
        private System.Windows.Forms.TextBox BxCliente;
        private System.Windows.Forms.NumericUpDown BxQuantidade;
        private System.Windows.Forms.Label LbCliente;
        private System.Windows.Forms.TextBox BxProcurar;
        private System.Windows.Forms.Label LbNome;
        private System.Windows.Forms.Button BtFinalizar;
        private System.Windows.Forms.Label LbQuantidade;
        private System.Windows.Forms.Label LbTotalItem;
        private System.Windows.Forms.Label LbSubTotal;
        private System.Windows.Forms.Button BtRemoverCarrinho;
        private System.Windows.Forms.TextBox BxTotal;
        private System.Windows.Forms.TextBox BxPreco;
        private System.Windows.Forms.Button btAdicionarCarrinho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btlistar;
        private System.Windows.Forms.Button btcancelarvenda;
    }
}