namespace SistemaComercio
{
    partial class Frm_Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.ImgCliente = new System.Windows.Forms.PictureBox();
            this.ImgFornecedor = new System.Windows.Forms.PictureBox();
            this.ChkCliente = new System.Windows.Forms.CheckBox();
            this.ChkFornecedor = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(248, 243);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(241, 20);
            this.TxtUsuario.TabIndex = 0;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged_1);
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(248, 269);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(241, 20);
            this.TxtSenha.TabIndex = 1;
            this.TxtSenha.TextChanged += new System.EventHandler(this.TxtSenha_TextChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.BtnLogin.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(250, 306);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(93, 23);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Logar";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Thistle;
            this.LblTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(271, 48);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(162, 14);
            this.LblTitulo.TabIndex = 5;
            this.LblTitulo.Text = "Escolha o tipo de conta:";
            this.LblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // ImgCliente
            // 
            this.ImgCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgCliente.Image = global::SistemaComercio.Properties.Resources.ImgCliente;
            this.ImgCliente.Location = new System.Drawing.Point(250, 75);
            this.ImgCliente.Name = "ImgCliente";
            this.ImgCliente.Size = new System.Drawing.Size(92, 98);
            this.ImgCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImgCliente.TabIndex = 7;
            this.ImgCliente.TabStop = false;
            // 
            // ImgFornecedor
            // 
            this.ImgFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgFornecedor.Image = global::SistemaComercio.Properties.Resources.ImgFornecedor;
            this.ImgFornecedor.Location = new System.Drawing.Point(359, 75);
            this.ImgFornecedor.Name = "ImgFornecedor";
            this.ImgFornecedor.Size = new System.Drawing.Size(93, 98);
            this.ImgFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImgFornecedor.TabIndex = 6;
            this.ImgFornecedor.TabStop = false;
            // 
            // ChkCliente
            // 
            this.ChkCliente.AutoSize = true;
            this.ChkCliente.BackColor = System.Drawing.Color.Plum;
            this.ChkCliente.Location = new System.Drawing.Point(241, 168);
            this.ChkCliente.Name = "ChkCliente";
            this.ChkCliente.Size = new System.Drawing.Size(15, 14);
            this.ChkCliente.TabIndex = 8;
            this.ChkCliente.UseVisualStyleBackColor = false;
            // 
            // ChkFornecedor
            // 
            this.ChkFornecedor.AutoSize = true;
            this.ChkFornecedor.BackColor = System.Drawing.Color.Plum;
            this.ChkFornecedor.Location = new System.Drawing.Point(447, 168);
            this.ChkFornecedor.Name = "ChkFornecedor";
            this.ChkFornecedor.Size = new System.Drawing.Size(15, 14);
            this.ChkFornecedor.TabIndex = 9;
            this.ChkFornecedor.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Thistle;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(193, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::SistemaComercio.Properties.Resources.ImgFundo;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(687, 411);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(360, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Por favor preencha os campos abaixo.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Olá Cliente!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ainda não possui uma conta?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Thistle;
            this.linkLabel1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(390, 345);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cadastre-se";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Thistle;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "E-mail:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Thistle;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Senha:";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 408);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChkFornecedor);
            this.Controls.Add(this.ChkCliente);
            this.Controls.Add(this.ImgCliente);
            this.Controls.Add(this.ImgFornecedor);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Frm_Login";
            this.Text = "Logar no Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.ImgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.PictureBox PicUsuario;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox PicFornecedor;
        private System.Windows.Forms.PictureBox ImgFornecedor;
        private System.Windows.Forms.PictureBox ImgCliente;
        private System.Windows.Forms.CheckBox ChkCliente;
        private System.Windows.Forms.CheckBox ChkFornecedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

