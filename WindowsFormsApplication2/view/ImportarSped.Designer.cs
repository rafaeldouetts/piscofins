namespace ICMS_PIS_COFFINS
{
    partial class FRM_ImportarSped
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ImportarSped));
            this.BTN_SpedFiscal = new System.Windows.Forms.Button();
            this.BTN_Cancela = new System.Windows.Forms.Button();
            this.Rad_Seleciona1 = new System.Windows.Forms.RadioButton();
            this.Rad_TodosArquivos = new System.Windows.Forms.RadioButton();
            this.LBL_Status = new System.Windows.Forms.Label();
            this.LBL_Linha = new System.Windows.Forms.Label();
            this.PGB_Linha = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.LBL_Nlinha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_SpedFiscal
            // 
            this.BTN_SpedFiscal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SpedFiscal.Location = new System.Drawing.Point(320, 72);
            this.BTN_SpedFiscal.Name = "BTN_SpedFiscal";
            this.BTN_SpedFiscal.Size = new System.Drawing.Size(111, 52);
            this.BTN_SpedFiscal.TabIndex = 0;
            this.BTN_SpedFiscal.Text = "Importar SPED Fiscal";
            this.BTN_SpedFiscal.UseVisualStyleBackColor = true;
            this.BTN_SpedFiscal.Click += new System.EventHandler(this.BTN_SpedFiscal_Click);
            // 
            // BTN_Cancela
            // 
            this.BTN_Cancela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cancela.Location = new System.Drawing.Point(464, 69);
            this.BTN_Cancela.Name = "BTN_Cancela";
            this.BTN_Cancela.Size = new System.Drawing.Size(124, 55);
            this.BTN_Cancela.TabIndex = 2;
            this.BTN_Cancela.Text = "Cancelar Importação";
            this.BTN_Cancela.UseVisualStyleBackColor = true;
            // 
            // Rad_Seleciona1
            // 
            this.Rad_Seleciona1.AutoSize = true;
            this.Rad_Seleciona1.Checked = true;
            this.Rad_Seleciona1.Location = new System.Drawing.Point(36, 47);
            this.Rad_Seleciona1.Name = "Rad_Seleciona1";
            this.Rad_Seleciona1.Size = new System.Drawing.Size(114, 17);
            this.Rad_Seleciona1.TabIndex = 3;
            this.Rad_Seleciona1.TabStop = true;
            this.Rad_Seleciona1.Text = "Selecionar Arquivo";
            this.Rad_Seleciona1.UseVisualStyleBackColor = true;
            // 
            // Rad_TodosArquivos
            // 
            this.Rad_TodosArquivos.AutoSize = true;
            this.Rad_TodosArquivos.Location = new System.Drawing.Point(36, 90);
            this.Rad_TodosArquivos.Name = "Rad_TodosArquivos";
            this.Rad_TodosArquivos.Size = new System.Drawing.Size(166, 17);
            this.Rad_TodosArquivos.TabIndex = 4;
            this.Rad_TodosArquivos.TabStop = true;
            this.Rad_TodosArquivos.Text = "Todos Arquivos de uma pasta";
            this.Rad_TodosArquivos.UseVisualStyleBackColor = true;
            // 
            // LBL_Status
            // 
            this.LBL_Status.AutoSize = true;
            this.LBL_Status.Location = new System.Drawing.Point(36, 165);
            this.LBL_Status.Name = "LBL_Status";
            this.LBL_Status.Size = new System.Drawing.Size(53, 13);
            this.LBL_Status.TabIndex = 6;
            this.LBL_Status.Text = "STATUS:";
            // 
            // LBL_Linha
            // 
            this.LBL_Linha.AutoSize = true;
            this.LBL_Linha.Location = new System.Drawing.Point(36, 208);
            this.LBL_Linha.Name = "LBL_Linha";
            this.LBL_Linha.Size = new System.Drawing.Size(36, 13);
            this.LBL_Linha.TabIndex = 7;
            this.LBL_Linha.Text = "Linha:";
            // 
            // PGB_Linha
            // 
            this.PGB_Linha.Location = new System.Drawing.Point(36, 225);
            this.PGB_Linha.Name = "PGB_Linha";
            this.PGB_Linha.Size = new System.Drawing.Size(166, 23);
            this.PGB_Linha.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Arquivo:";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(388, 225);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(166, 23);
            this.progressBar2.TabIndex = 10;
            // 
            // LBL_Nlinha
            // 
            this.LBL_Nlinha.AutoSize = true;
            this.LBL_Nlinha.Location = new System.Drawing.Point(151, 208);
            this.LBL_Nlinha.Name = "LBL_Nlinha";
            this.LBL_Nlinha.Size = new System.Drawing.Size(48, 13);
            this.LBL_Nlinha.TabIndex = 11;
            this.LBL_Nlinha.Text = "Nº Linha";
            this.LBL_Nlinha.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nº Coluna";
            this.label3.Visible = false;
            // 
            // FRM_ImportarSped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 278);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBL_Nlinha);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PGB_Linha);
            this.Controls.Add(this.LBL_Linha);
            this.Controls.Add(this.LBL_Status);
            this.Controls.Add(this.Rad_TodosArquivos);
            this.Controls.Add(this.Rad_Seleciona1);
            this.Controls.Add(this.BTN_Cancela);
            this.Controls.Add(this.BTN_SpedFiscal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_ImportarSped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importação de SPED\'S";
            this.Load += new System.EventHandler(this.ImportarSped_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_SpedFiscal;
        private System.Windows.Forms.Button BTN_Cancela;
        private System.Windows.Forms.RadioButton Rad_Seleciona1;
        private System.Windows.Forms.RadioButton Rad_TodosArquivos;
        private System.Windows.Forms.Label LBL_Status;
        private System.Windows.Forms.Label LBL_Linha;
        private System.Windows.Forms.ProgressBar PGB_Linha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label LBL_Nlinha;
        private System.Windows.Forms.Label label3;
    }
}