namespace ICMS_PIS_COFFINS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTN_Entrar = new System.Windows.Forms.Button();
            this.BTN_Sair = new System.Windows.Forms.Button();
            this.LBL_Usuario = new System.Windows.Forms.Label();
            this.LBL_Senha = new System.Windows.Forms.Label();
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.LBL_Banco = new System.Windows.Forms.Label();
            this.LBL_NomeBanco = new System.Windows.Forms.Label();
            this.PRG_Login = new System.Windows.Forms.ProgressBar();
            this.TXT_Senha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Entrar
            // 
            this.BTN_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Entrar.Location = new System.Drawing.Point(364, 139);
            this.BTN_Entrar.Name = "BTN_Entrar";
            this.BTN_Entrar.Size = new System.Drawing.Size(85, 23);
            this.BTN_Entrar.TabIndex = 0;
            this.BTN_Entrar.Text = "Entrar ";
            this.BTN_Entrar.UseVisualStyleBackColor = true;
            this.BTN_Entrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_Sair
            // 
            this.BTN_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Sair.Location = new System.Drawing.Point(238, 139);
            this.BTN_Sair.Name = "BTN_Sair";
            this.BTN_Sair.Size = new System.Drawing.Size(75, 23);
            this.BTN_Sair.TabIndex = 1;
            this.BTN_Sair.Text = "Sair ";
            this.BTN_Sair.UseVisualStyleBackColor = true;
            this.BTN_Sair.Click += new System.EventHandler(this.button2_Click);
            // 
            // LBL_Usuario
            // 
            this.LBL_Usuario.AutoSize = true;
            this.LBL_Usuario.Location = new System.Drawing.Point(232, 26);
            this.LBL_Usuario.Name = "LBL_Usuario";
            this.LBL_Usuario.Size = new System.Drawing.Size(46, 13);
            this.LBL_Usuario.TabIndex = 2;
            this.LBL_Usuario.Text = "Usuario:";
            this.LBL_Usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBL_Senha
            // 
            this.LBL_Senha.AutoSize = true;
            this.LBL_Senha.Location = new System.Drawing.Point(235, 74);
            this.LBL_Senha.Name = "LBL_Senha";
            this.LBL_Senha.Size = new System.Drawing.Size(41, 13);
            this.LBL_Senha.TabIndex = 3;
            this.LBL_Senha.Text = "Senha:";
            // 
            // TXT_Usuario
            // 
            this.TXT_Usuario.Location = new System.Drawing.Point(238, 43);
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.Size = new System.Drawing.Size(211, 20);
            this.TXT_Usuario.TabIndex = 4;
            // 
            // LBL_Banco
            // 
            this.LBL_Banco.AutoSize = true;
            this.LBL_Banco.Location = new System.Drawing.Point(103, 184);
            this.LBL_Banco.Name = "LBL_Banco";
            this.LBL_Banco.Size = new System.Drawing.Size(41, 13);
            this.LBL_Banco.TabIndex = 6;
            this.LBL_Banco.Text = "Banco:";
            // 
            // LBL_NomeBanco
            // 
            this.LBL_NomeBanco.AutoSize = true;
            this.LBL_NomeBanco.Location = new System.Drawing.Point(151, 184);
            this.LBL_NomeBanco.Name = "LBL_NomeBanco";
            this.LBL_NomeBanco.Size = new System.Drawing.Size(83, 13);
            this.LBL_NomeBanco.TabIndex = 7;
            this.LBL_NomeBanco.Text = "Nome do banco";
            // 
            // PRG_Login
            // 
            this.PRG_Login.Location = new System.Drawing.Point(292, 212);
            this.PRG_Login.Name = "PRG_Login";
            this.PRG_Login.Size = new System.Drawing.Size(157, 23);
            this.PRG_Login.TabIndex = 8;
            // 
            // TXT_Senha
            // 
            this.TXT_Senha.Location = new System.Drawing.Point(238, 91);
            this.TXT_Senha.Name = "TXT_Senha";
            this.TXT_Senha.PasswordChar = '*';
            this.TXT_Senha.Size = new System.Drawing.Size(211, 20);
            this.TXT_Senha.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 266);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TXT_Senha);
            this.Controls.Add(this.PRG_Login);
            this.Controls.Add(this.LBL_NomeBanco);
            this.Controls.Add(this.LBL_Banco);
            this.Controls.Add(this.TXT_Usuario);
            this.Controls.Add(this.LBL_Senha);
            this.Controls.Add(this.LBL_Usuario);
            this.Controls.Add(this.BTN_Sair);
            this.Controls.Add(this.BTN_Entrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Entrar;
        private System.Windows.Forms.Button BTN_Sair;
        private System.Windows.Forms.Label LBL_Usuario;
        private System.Windows.Forms.Label LBL_Senha;
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.Label LBL_Banco;
        private System.Windows.Forms.Label LBL_NomeBanco;
        private System.Windows.Forms.ProgressBar PRG_Login;
        private System.Windows.Forms.TextBox TXT_Senha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

