namespace SistemaComercio.Gui
{
    partial class Frm_RegistroVenda
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbidvenda = new System.Windows.Forms.TextBox();
            this.tbidcliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbvalortotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbidproduto = new System.Windows.Forms.TextBox();
            this.tbquantidade = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbpreco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbvalorpago = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbtroco = new System.Windows.Forms.TextBox();
            this.RbDinheiro = new System.Windows.Forms.RadioButton();
            this.RbCredito = new System.Windows.Forms.RadioButton();
            this.RbDebito = new System.Windows.Forms.RadioButton();
            this.RbPix = new System.Windows.Forms.RadioButton();
            this.RbBoleto = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.DataGridItemVenda = new System.Windows.Forms.DataGridView();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridItemVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "adicionar item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbidvenda
            // 
            this.tbidvenda.Location = new System.Drawing.Point(80, 18);
            this.tbidvenda.Name = "tbidvenda";
            this.tbidvenda.Size = new System.Drawing.Size(100, 20);
            this.tbidvenda.TabIndex = 1;
            // 
            // tbidcliente
            // 
            this.tbidcliente.Location = new System.Drawing.Point(454, 94);
            this.tbidcliente.Name = "tbidcliente";
            this.tbidcliente.Size = new System.Drawing.Size(100, 20);
            this.tbidcliente.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "id_cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "valor total";
            // 
            // tbvalortotal
            // 
            this.tbvalortotal.Location = new System.Drawing.Point(104, 376);
            this.tbvalortotal.Name = "tbvalortotal";
            this.tbvalortotal.Size = new System.Drawing.Size(153, 20);
            this.tbvalortotal.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "id_venda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "preco";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "id_produto";
            // 
            // tbidproduto
            // 
            this.tbidproduto.Location = new System.Drawing.Point(454, 164);
            this.tbidproduto.Name = "tbidproduto";
            this.tbidproduto.Size = new System.Drawing.Size(56, 20);
            this.tbidproduto.TabIndex = 16;
            // 
            // tbquantidade
            // 
            this.tbquantidade.Location = new System.Drawing.Point(454, 209);
            this.tbquantidade.Name = "tbquantidade";
            this.tbquantidade.Size = new System.Drawing.Size(147, 20);
            this.tbquantidade.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "remover produto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbpreco
            // 
            this.tbpreco.Location = new System.Drawing.Point(454, 252);
            this.tbpreco.Name = "tbpreco";
            this.tbpreco.Size = new System.Drawing.Size(100, 20);
            this.tbpreco.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "quantidade";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(479, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "cadastrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(479, 453);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbvalorpago
            // 
            this.tbvalorpago.Location = new System.Drawing.Point(99, 413);
            this.tbvalorpago.Name = "tbvalorpago";
            this.tbvalorpago.Size = new System.Drawing.Size(136, 20);
            this.tbvalorpago.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "pagar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 453);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "troco";
            // 
            // tbtroco
            // 
            this.tbtroco.Location = new System.Drawing.Point(99, 453);
            this.tbtroco.Name = "tbtroco";
            this.tbtroco.Size = new System.Drawing.Size(136, 20);
            this.tbtroco.TabIndex = 28;
            // 
            // RbDinheiro
            // 
            this.RbDinheiro.AutoSize = true;
            this.RbDinheiro.Location = new System.Drawing.Point(300, 379);
            this.RbDinheiro.Name = "RbDinheiro";
            this.RbDinheiro.Size = new System.Drawing.Size(64, 17);
            this.RbDinheiro.TabIndex = 30;
            this.RbDinheiro.TabStop = true;
            this.RbDinheiro.Text = "Dinheiro";
            this.RbDinheiro.UseVisualStyleBackColor = true;
            // 
            // RbCredito
            // 
            this.RbCredito.AutoSize = true;
            this.RbCredito.Location = new System.Drawing.Point(300, 402);
            this.RbCredito.Name = "RbCredito";
            this.RbCredito.Size = new System.Drawing.Size(58, 17);
            this.RbCredito.TabIndex = 31;
            this.RbCredito.TabStop = true;
            this.RbCredito.Text = "Credito";
            this.RbCredito.UseVisualStyleBackColor = true;
            // 
            // RbDebito
            // 
            this.RbDebito.AutoSize = true;
            this.RbDebito.Location = new System.Drawing.Point(300, 425);
            this.RbDebito.Name = "RbDebito";
            this.RbDebito.Size = new System.Drawing.Size(56, 17);
            this.RbDebito.TabIndex = 32;
            this.RbDebito.TabStop = true;
            this.RbDebito.Text = "Debito";
            this.RbDebito.UseVisualStyleBackColor = true;
            // 
            // RbPix
            // 
            this.RbPix.AutoSize = true;
            this.RbPix.Location = new System.Drawing.Point(300, 448);
            this.RbPix.Name = "RbPix";
            this.RbPix.Size = new System.Drawing.Size(39, 17);
            this.RbPix.TabIndex = 33;
            this.RbPix.TabStop = true;
            this.RbPix.Text = "Pix";
            this.RbPix.UseVisualStyleBackColor = true;
            // 
            // RbBoleto
            // 
            this.RbBoleto.AutoSize = true;
            this.RbBoleto.Location = new System.Drawing.Point(300, 471);
            this.RbBoleto.Name = "RbBoleto";
            this.RbBoleto.Size = new System.Drawing.Size(55, 17);
            this.RbBoleto.TabIndex = 34;
            this.RbBoleto.TabStop = true;
            this.RbBoleto.Text = "Boleto";
            this.RbBoleto.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(526, 161);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 35;
            this.button5.Text = "selecionar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbtotal
            // 
            this.tbtotal.Location = new System.Drawing.Point(454, 289);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.Size = new System.Drawing.Size(100, 20);
            this.tbtotal.TabIndex = 36;
            // 
            // DataGridItemVenda
            // 
            this.DataGridItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridItemVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.id_produto,
            this.nome,
            this.quantidade,
            this.valorUnidade,
            this.valorTotal});
            this.DataGridItemVenda.Location = new System.Drawing.Point(12, 83);
            this.DataGridItemVenda.Name = "DataGridItemVenda";
            this.DataGridItemVenda.Size = new System.Drawing.Size(352, 272);
            this.DataGridItemVenda.TabIndex = 37;
            this.DataGridItemVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridItemVenda_CellContentClick);
            // 
            // N
            // 
            this.N.HeaderText = "N";
            this.N.Name = "N";
            this.N.Width = 50;
            // 
            // id_produto
            // 
            this.id_produto.HeaderText = "idProduto";
            this.id_produto.Name = "id_produto";
            this.id_produto.Width = 60;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 60;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.Width = 60;
            // 
            // valorUnidade
            // 
            this.valorUnidade.HeaderText = "valor_unidade";
            this.valorUnidade.Name = "valorUnidade";
            this.valorUnidade.Width = 70;
            // 
            // valorTotal
            // 
            this.valorTotal.HeaderText = "valor_total";
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.Width = 70;
            // 
            // Frm_RegistroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 500);
            this.Controls.Add(this.DataGridItemVenda);
            this.Controls.Add(this.tbtotal);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.RbBoleto);
            this.Controls.Add(this.RbPix);
            this.Controls.Add(this.RbDebito);
            this.Controls.Add(this.RbCredito);
            this.Controls.Add(this.RbDinheiro);
            this.Controls.Add(this.tbtroco);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbvalorpago);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbpreco);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbquantidade);
            this.Controls.Add(this.tbidproduto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbvalortotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbidcliente);
            this.Controls.Add(this.tbidvenda);
            this.Controls.Add(this.button1);
            this.Name = "Frm_RegistroVenda";
            this.Text = "¨¨¨¨¨¨¨¨¨¨";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridItemVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbidvenda;
        private System.Windows.Forms.TextBox tbidcliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbvalortotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbidproduto;
        private System.Windows.Forms.TextBox tbquantidade;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbpreco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbvalorpago;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbtroco;
        private System.Windows.Forms.RadioButton RbDinheiro;
        private System.Windows.Forms.RadioButton RbCredito;
        private System.Windows.Forms.RadioButton RbDebito;
        private System.Windows.Forms.RadioButton RbPix;
        private System.Windows.Forms.RadioButton RbBoleto;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.DataGridView DataGridItemVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
    }
}