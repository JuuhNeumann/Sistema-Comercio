namespace SistemaComercio
{
    partial class Frm_Cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.L = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblCpfCnpj = new System.Windows.Forms.Label();
            this.LblLogradouro = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblComplemento = new System.Windows.Forms.Label();
            this.LblBairro = new System.Windows.Forms.Label();
            this.LblCidade = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblCep = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.LblEmailAdd = new System.Windows.Forms.Label();
            this.LblSenhaAdd = new System.Windows.Forms.Label();
            this.TxtNomeCad = new System.Windows.Forms.TextBox();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.TxtLogra = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtComp = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.TxtCep = new System.Windows.Forms.TextBox();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.TxtEmailCad = new System.Windows.Forms.TextBox();
            this.TxtSenhaCad = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BnCancelarCad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faça aqui seu cadastro";
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L.Location = new System.Drawing.Point(31, 58);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(148, 14);
            this.L.TabIndex = 1;
            this.L.Text = "Escolha o tipo de usuário:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cliente",
            "Fornecedor"});
            this.comboBox1.Location = new System.Drawing.Point(179, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Nenhum";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::SistemaComercio.Properties.Resources.ImgNovoUsuario;
            this.pictureBox1.Location = new System.Drawing.Point(316, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(31, 109);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(43, 14);
            this.LblNome.TabIndex = 4;
            this.LblNome.Text = "Nome:";
            // 
            // LblCpfCnpj
            // 
            this.LblCpfCnpj.AutoSize = true;
            this.LblCpfCnpj.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCpfCnpj.Location = new System.Drawing.Point(31, 141);
            this.LblCpfCnpj.Name = "LblCpfCnpj";
            this.LblCpfCnpj.Size = new System.Drawing.Size(68, 14);
            this.LblCpfCnpj.TabIndex = 5;
            this.LblCpfCnpj.Text = "CPF/CNPJ:";
            // 
            // LblLogradouro
            // 
            this.LblLogradouro.AutoSize = true;
            this.LblLogradouro.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogradouro.Location = new System.Drawing.Point(31, 169);
            this.LblLogradouro.Name = "LblLogradouro";
            this.LblLogradouro.Size = new System.Drawing.Size(75, 14);
            this.LblLogradouro.TabIndex = 6;
            this.LblLogradouro.Text = "Logradouro:";
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumero.Location = new System.Drawing.Point(31, 201);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(54, 14);
            this.LblNumero.TabIndex = 7;
            this.LblNumero.Text = "Número:";
            // 
            // LblComplemento
            // 
            this.LblComplemento.AutoSize = true;
            this.LblComplemento.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComplemento.Location = new System.Drawing.Point(31, 225);
            this.LblComplemento.Name = "LblComplemento";
            this.LblComplemento.Size = new System.Drawing.Size(88, 14);
            this.LblComplemento.TabIndex = 8;
            this.LblComplemento.Text = "Complemento:";
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBairro.Location = new System.Drawing.Point(31, 252);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.Size = new System.Drawing.Size(45, 14);
            this.LblBairro.TabIndex = 9;
            this.LblBairro.Text = "Bairro:";
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCidade.Location = new System.Drawing.Point(31, 282);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(50, 14);
            this.LblCidade.TabIndex = 10;
            this.LblCidade.Text = "Cidade:";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(31, 312);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(48, 14);
            this.LblEstado.TabIndex = 11;
            this.LblEstado.Text = "Estado:";
            // 
            // LblCep
            // 
            this.LblCep.AutoSize = true;
            this.LblCep.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCep.Location = new System.Drawing.Point(31, 340);
            this.LblCep.Name = "LblCep";
            this.LblCep.Size = new System.Drawing.Size(33, 14);
            this.LblCep.TabIndex = 12;
            this.LblCep.Text = "Cep:";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefone.Location = new System.Drawing.Point(31, 367);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(59, 14);
            this.LblTelefone.TabIndex = 13;
            this.LblTelefone.Text = "Telefone:";
            // 
            // LblEmailAdd
            // 
            this.LblEmailAdd.AutoSize = true;
            this.LblEmailAdd.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailAdd.Location = new System.Drawing.Point(29, 394);
            this.LblEmailAdd.Name = "LblEmailAdd";
            this.LblEmailAdd.Size = new System.Drawing.Size(47, 14);
            this.LblEmailAdd.TabIndex = 14;
            this.LblEmailAdd.Text = "E-mail:";
            // 
            // LblSenhaAdd
            // 
            this.LblSenhaAdd.AutoSize = true;
            this.LblSenhaAdd.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenhaAdd.Location = new System.Drawing.Point(29, 423);
            this.LblSenhaAdd.Name = "LblSenhaAdd";
            this.LblSenhaAdd.Size = new System.Drawing.Size(44, 14);
            this.LblSenhaAdd.TabIndex = 15;
            this.LblSenhaAdd.Text = "Senha:";
            // 
            // TxtNomeCad
            // 
            this.TxtNomeCad.Location = new System.Drawing.Point(80, 106);
            this.TxtNomeCad.Name = "TxtNomeCad";
            this.TxtNomeCad.Size = new System.Drawing.Size(220, 20);
            this.TxtNomeCad.TabIndex = 16;
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(105, 138);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(303, 20);
            this.TxtCpf.TabIndex = 17;
            // 
            // TxtLogra
            // 
            this.TxtLogra.Location = new System.Drawing.Point(110, 166);
            this.TxtLogra.Name = "TxtLogra";
            this.TxtLogra.Size = new System.Drawing.Size(298, 20);
            this.TxtLogra.TabIndex = 18;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(91, 195);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(317, 20);
            this.TxtNumero.TabIndex = 19;
            // 
            // TxtComp
            // 
            this.TxtComp.Location = new System.Drawing.Point(125, 222);
            this.TxtComp.Name = "TxtComp";
            this.TxtComp.Size = new System.Drawing.Size(283, 20);
            this.TxtComp.TabIndex = 20;
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(80, 249);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(328, 20);
            this.TxtBairro.TabIndex = 21;
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(80, 279);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(328, 20);
            this.TxtCidade.TabIndex = 22;
            // 
            // TxtEstado
            // 
            this.TxtEstado.Location = new System.Drawing.Point(80, 309);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(328, 20);
            this.TxtEstado.TabIndex = 23;
            // 
            // TxtCep
            // 
            this.TxtCep.Location = new System.Drawing.Point(70, 335);
            this.TxtCep.Name = "TxtCep";
            this.TxtCep.Size = new System.Drawing.Size(338, 20);
            this.TxtCep.TabIndex = 24;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(91, 364);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(317, 20);
            this.TxtTel.TabIndex = 25;
            // 
            // TxtEmailCad
            // 
            this.TxtEmailCad.Location = new System.Drawing.Point(80, 391);
            this.TxtEmailCad.Name = "TxtEmailCad";
            this.TxtEmailCad.Size = new System.Drawing.Size(328, 20);
            this.TxtEmailCad.TabIndex = 26;
            // 
            // TxtSenhaCad
            // 
            this.TxtSenhaCad.Location = new System.Drawing.Point(79, 417);
            this.TxtSenhaCad.Name = "TxtSenhaCad";
            this.TxtSenhaCad.Size = new System.Drawing.Size(328, 20);
            this.TxtSenhaCad.TabIndex = 27;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(105, 452);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(105, 23);
            this.BtnSalvar.TabIndex = 28;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // BnCancelarCad
            // 
            this.BnCancelarCad.Location = new System.Drawing.Point(236, 452);
            this.BnCancelarCad.Name = "BnCancelarCad";
            this.BnCancelarCad.Size = new System.Drawing.Size(106, 23);
            this.BnCancelarCad.TabIndex = 29;
            this.BnCancelarCad.Text = "Cancelar";
            this.BnCancelarCad.UseVisualStyleBackColor = true;
            // 
            // Frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 484);
            this.Controls.Add(this.BnCancelarCad);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxtSenhaCad);
            this.Controls.Add(this.TxtEmailCad);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.TxtCep);
            this.Controls.Add(this.TxtEstado);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.TxtComp);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.TxtLogra);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.TxtNomeCad);
            this.Controls.Add(this.LblSenhaAdd);
            this.Controls.Add(this.LblEmailAdd);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.LblCep);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblCidade);
            this.Controls.Add(this.LblBairro);
            this.Controls.Add(this.LblComplemento);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.LblLogradouro);
            this.Controls.Add(this.LblCpfCnpj);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.L);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Cadastro";
            this.Text = "Tela de Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblCpfCnpj;
        private System.Windows.Forms.Label LblLogradouro;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label LblComplemento;
        private System.Windows.Forms.Label LblBairro;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblCep;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.Label LblEmailAdd;
        private System.Windows.Forms.Label LblSenhaAdd;
        private System.Windows.Forms.TextBox TxtNomeCad;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox TxtLogra;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtComp;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.TextBox TxtCep;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.TextBox TxtEmailCad;
        private System.Windows.Forms.TextBox TxtSenhaCad;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BnCancelarCad;
    }
}