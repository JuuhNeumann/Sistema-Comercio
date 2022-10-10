namespace SistemaComercio.Gui
{
    partial class Frm_Produto
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.pnlMeio = new System.Windows.Forms.Panel();
            this.dataGridViewProd = new System.Windows.Forms.DataGridView();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblNome.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblEstoque.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(12, 37);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(120, 13);
            this.lblEstoque.TabIndex = 1;
            this.lblEstoque.Text = "Quantidade em estoque:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblPreco.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(12, 66);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(37, 13);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço:";
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblUnidade.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.Location = new System.Drawing.Point(256, 71);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(50, 13);
            this.lblUnidade.TabIndex = 3;
            this.lblUnidade.Text = "Unidade:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(47, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(408, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(132, 34);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(323, 20);
            this.txtEstoque.TabIndex = 5;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(47, 63);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(200, 20);
            this.txtPreco.TabIndex = 6;
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(305, 68);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(153, 20);
            this.txtUnidade.TabIndex = 7;
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlFundo.Controls.Add(this.txtUnidade);
            this.pnlFundo.Controls.Add(this.btnSair);
            this.pnlFundo.Controls.Add(this.btnExcluir);
            this.pnlFundo.Controls.Add(this.btnLimpar);
            this.pnlFundo.Controls.Add(this.btnAtualizar);
            this.pnlFundo.Controls.Add(this.btnCadastrar);
            this.pnlFundo.Controls.Add(this.lblUnidade);
            this.pnlFundo.Controls.Add(this.btnPesquisar);
            this.pnlFundo.Controls.Add(this.txtPesquisar);
            this.pnlFundo.Controls.Add(this.lblPesquisar);
            this.pnlFundo.Controls.Add(this.dataGridViewProd);
            this.pnlFundo.Controls.Add(this.pnlMeio);
            this.pnlFundo.Location = new System.Drawing.Point(-3, -4);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(475, 390);
            this.pnlFundo.TabIndex = 8;
            // 
            // pnlMeio
            // 
            this.pnlMeio.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlMeio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMeio.Location = new System.Drawing.Point(0, 103);
            this.pnlMeio.Name = "pnlMeio";
            this.pnlMeio.Size = new System.Drawing.Size(472, 10);
            this.pnlMeio.TabIndex = 0;
            // 
            // dataGridViewProd
            // 
            this.dataGridViewProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProd.Location = new System.Drawing.Point(15, 165);
            this.dataGridViewProd.Name = "dataGridViewProd";
            this.dataGridViewProd.Size = new System.Drawing.Size(443, 171);
            this.dataGridViewProd.TabIndex = 1;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblPesquisar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(15, 130);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(104, 13);
            this.lblPesquisar.TabIndex = 9;
            this.lblPesquisar.Text = "Pesquisar por nome:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(115, 127);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(251, 20);
            this.txtPesquisar.TabIndex = 9;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = global::SistemaComercio.Properties.Resources.lupa;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(372, 123);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(86, 28);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "    Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = global::SistemaComercio.Properties.Resources.adicionar;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(15, 344);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(81, 26);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "    Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = global::SistemaComercio.Properties.Resources.atualizar;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(102, 344);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(81, 26);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "    Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::SistemaComercio.Properties.Resources.limpar;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(189, 344);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(81, 26);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "    Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::SistemaComercio.Properties.Resources.lixo;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(276, 344);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 26);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "     Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::SistemaComercio.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(386, 344);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(72, 26);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "    Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // Frm_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 374);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.pnlFundo);
            this.Name = "Frm_Produto";
            this.Text = "Produto";
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewProd;
        private System.Windows.Forms.Panel pnlMeio;
    }
}