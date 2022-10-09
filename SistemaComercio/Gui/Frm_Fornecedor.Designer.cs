namespace SistemaComercio.Gui
{
    partial class Frm_Fornecedor
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
            this.components = new System.ComponentModel.Container();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblComple = new System.Windows.Forms.Label();
            this.lblLogra = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.lblEst = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.pnlFundoForne = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.lblProcurarNome = new System.Windows.Forms.Label();
            this.dataGridViewForne = new System.Windows.Forms.DataGridView();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaComercioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaComercioDataSet = new SistemaComercio.SistemaComercioDataSet();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComple = new System.Windows.Forms.TextBox();
            this.txtLogra = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.fornecedorTableAdapter = new SistemaComercio.SistemaComercioDataSetTableAdapters.FornecedorTableAdapter();
            this.pnlFundoForne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComercioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComercioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(13, 35);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(62, 13);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF/CNPJ:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(381, 9);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Telefone:";
            // 
            // lblComple
            // 
            this.lblComple.AutoSize = true;
            this.lblComple.Location = new System.Drawing.Point(13, 90);
            this.lblComple.Name = "lblComple";
            this.lblComple.Size = new System.Drawing.Size(74, 13);
            this.lblComple.TabIndex = 3;
            this.lblComple.Text = "Complemento:";
            // 
            // lblLogra
            // 
            this.lblLogra.AutoSize = true;
            this.lblLogra.Location = new System.Drawing.Point(13, 61);
            this.lblLogra.Name = "lblLogra";
            this.lblLogra.Size = new System.Drawing.Size(64, 13);
            this.lblLogra.TabIndex = 4;
            this.lblLogra.Text = "Logradouro:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(13, 119);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 5;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Location = new System.Drawing.Point(381, 35);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(43, 13);
            this.lblCid.TabIndex = 6;
            this.lblCid.Text = "Cidade:";
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.Location = new System.Drawing.Point(381, 61);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(43, 13);
            this.lblEst.TabIndex = 7;
            this.lblEst.Text = "Estado:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(381, 90);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 8;
            this.lblCEP.Text = "CEP:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(13, 152);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(47, 13);
            this.lblNum.TabIndex = 9;
            this.lblNum.Text = "Número:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(381, 119);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(381, 148);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha:";
            // 
            // pnlFundoForne
            // 
            this.pnlFundoForne.BackColor = System.Drawing.Color.Thistle;
            this.pnlFundoForne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFundoForne.Controls.Add(this.panel1);
            this.pnlFundoForne.Controls.Add(this.btnSair);
            this.pnlFundoForne.Controls.Add(this.btnExcluir);
            this.pnlFundoForne.Controls.Add(this.btnAtualizar);
            this.pnlFundoForne.Controls.Add(this.btnProcurar);
            this.pnlFundoForne.Controls.Add(this.txtProcurar);
            this.pnlFundoForne.Controls.Add(this.lblProcurarNome);
            this.pnlFundoForne.Controls.Add(this.dataGridViewForne);
            this.pnlFundoForne.Controls.Add(this.btnLimpar);
            this.pnlFundoForne.Controls.Add(this.btnCad);
            this.pnlFundoForne.Controls.Add(this.txtSenha);
            this.pnlFundoForne.Controls.Add(this.txtEmail);
            this.pnlFundoForne.Controls.Add(this.txtEstado);
            this.pnlFundoForne.Controls.Add(this.txtCidade);
            this.pnlFundoForne.Controls.Add(this.txtTel);
            this.pnlFundoForne.Controls.Add(this.txtCEP);
            this.pnlFundoForne.Controls.Add(this.txtNum);
            this.pnlFundoForne.Controls.Add(this.txtBairro);
            this.pnlFundoForne.Controls.Add(this.txtComple);
            this.pnlFundoForne.Controls.Add(this.txtLogra);
            this.pnlFundoForne.Controls.Add(this.txtCPF);
            this.pnlFundoForne.Controls.Add(this.lblSenha);
            this.pnlFundoForne.Controls.Add(this.txtNome);
            this.pnlFundoForne.Controls.Add(this.lblNome);
            this.pnlFundoForne.Controls.Add(this.lblEmail);
            this.pnlFundoForne.Controls.Add(this.lblNum);
            this.pnlFundoForne.Controls.Add(this.lblCPF);
            this.pnlFundoForne.Controls.Add(this.lblCEP);
            this.pnlFundoForne.Controls.Add(this.lblEst);
            this.pnlFundoForne.Controls.Add(this.lblTel);
            this.pnlFundoForne.Controls.Add(this.lblLogra);
            this.pnlFundoForne.Controls.Add(this.lblCid);
            this.pnlFundoForne.Controls.Add(this.lblComple);
            this.pnlFundoForne.Controls.Add(this.lblBairro);
            this.pnlFundoForne.Location = new System.Drawing.Point(-1, -1);
            this.pnlFundoForne.Name = "pnlFundoForne";
            this.pnlFundoForne.Size = new System.Drawing.Size(679, 452);
            this.pnlFundoForne.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(-1, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 10);
            this.panel1.TabIndex = 32;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(571, 411);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 27);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(199, 411);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 27);
            this.btnExcluir.TabIndex = 30;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(108, 411);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(85, 27);
            this.btnAtualizar.TabIndex = 29;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(282, 203);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(85, 20);
            this.btnProcurar.TabIndex = 28;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // txtProcurar
            // 
            this.txtProcurar.Location = new System.Drawing.Point(108, 203);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(168, 20);
            this.txtProcurar.TabIndex = 27;
            // 
            // lblProcurarNome
            // 
            this.lblProcurarNome.AutoSize = true;
            this.lblProcurarNome.Location = new System.Drawing.Point(13, 206);
            this.lblProcurarNome.Name = "lblProcurarNome";
            this.lblProcurarNome.Size = new System.Drawing.Size(97, 13);
            this.lblProcurarNome.TabIndex = 26;
            this.lblProcurarNome.Text = "Procurar por nome:";
            // 
            // dataGridViewForne
            // 
            this.dataGridViewForne.AllowUserToAddRows = false;
            this.dataGridViewForne.AllowUserToDeleteRows = false;
            this.dataGridViewForne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForne.Location = new System.Drawing.Point(16, 229);
            this.dataGridViewForne.Name = "dataGridViewForne";
            this.dataGridViewForne.ReadOnly = true;
            this.dataGridViewForne.Size = new System.Drawing.Size(640, 170);
            this.dataGridViewForne.TabIndex = 25;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.sistemaComercioDataSetBindingSource;
            // 
            // sistemaComercioDataSetBindingSource
            // 
            this.sistemaComercioDataSetBindingSource.DataSource = this.sistemaComercioDataSet;
            this.sistemaComercioDataSetBindingSource.Position = 0;
            // 
            // sistemaComercioDataSet
            // 
            this.sistemaComercioDataSet.DataSetName = "SistemaComercioDataSet";
            this.sistemaComercioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpar.Location = new System.Drawing.Point(290, 411);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 27);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnCad
            // 
            this.btnCad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCad.Location = new System.Drawing.Point(16, 411);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(85, 27);
            this.btnCad.TabIndex = 23;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = false;
            this.btnCad.Click += new System.EventHandler(this.CadastrarFornecedor);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(423, 145);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(237, 20);
            this.txtSenha.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(415, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(423, 58);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(237, 20);
            this.txtEstado.TabIndex = 20;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(423, 32);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(237, 20);
            this.txtCidade.TabIndex = 19;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(430, 6);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(230, 20);
            this.txtTel.TabIndex = 18;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(415, 87);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(245, 20);
            this.txtCEP.TabIndex = 17;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(55, 148);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(312, 20);
            this.txtNum.TabIndex = 16;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(47, 116);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(320, 20);
            this.txtBairro.TabIndex = 15;
            // 
            // txtComple
            // 
            this.txtComple.Location = new System.Drawing.Point(85, 87);
            this.txtComple.Name = "txtComple";
            this.txtComple.Size = new System.Drawing.Size(282, 20);
            this.txtComple.TabIndex = 14;
            // 
            // txtLogra
            // 
            this.txtLogra.Location = new System.Drawing.Point(75, 58);
            this.txtLogra.Name = "txtLogra";
            this.txtLogra.Size = new System.Drawing.Size(292, 20);
            this.txtLogra.TabIndex = 13;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(75, 32);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(292, 20);
            this.txtCPF.TabIndex = 12;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(47, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(320, 20);
            this.txtNome.TabIndex = 11;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 449);
            this.Controls.Add(this.pnlFundoForne);
            this.MaximizeBox = false;
            this.Name = "Frm_Fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Fornecedor";
            this.Load += new System.EventHandler(this.Frm_Fornecedor_Load);
            this.pnlFundoForne.ResumeLayout(false);
            this.pnlFundoForne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComercioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComercioDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblComple;
        private System.Windows.Forms.Label lblLogra;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Panel pnlFundoForne;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComple;
        private System.Windows.Forms.TextBox txtLogra;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dataGridViewForne;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Label lblProcurarNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource sistemaComercioDataSetBindingSource;
        private SistemaComercioDataSet sistemaComercioDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private SistemaComercioDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
    }
}