namespace ICMS_PIS_COFFINS
{
    partial class FRM_GerarRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_GerarRelatorio));
            this.LBL_Descricao = new System.Windows.Forms.Label();
            this.LBL_Data = new System.Windows.Forms.Label();
            this.TXT_Inicial = new System.Windows.Forms.TextBox();
            this.LBL_Ate = new System.Windows.Forms.Label();
            this.TXT_Final = new System.Windows.Forms.TextBox();
            this.CHK_Mes = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.BTN_Relatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Descricao
            // 
            this.LBL_Descricao.AutoSize = true;
            this.LBL_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Descricao.Location = new System.Drawing.Point(115, 36);
            this.LBL_Descricao.Name = "LBL_Descricao";
            this.LBL_Descricao.Size = new System.Drawing.Size(356, 20);
            this.LBL_Descricao.TabIndex = 0;
            this.LBL_Descricao.Text = "Relatorio ICMS base de cálculo  PIS/Cofins";
            this.LBL_Descricao.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBL_Data
            // 
            this.LBL_Data.AutoSize = true;
            this.LBL_Data.Location = new System.Drawing.Point(70, 99);
            this.LBL_Data.Name = "LBL_Data";
            this.LBL_Data.Size = new System.Drawing.Size(93, 13);
            this.LBL_Data.TabIndex = 1;
            this.LBL_Data.Text = "Digite o Mês/Ano:";
            // 
            // TXT_Inicial
            // 
            this.TXT_Inicial.Location = new System.Drawing.Point(169, 96);
            this.TXT_Inicial.Name = "TXT_Inicial";
            this.TXT_Inicial.Size = new System.Drawing.Size(100, 20);
            this.TXT_Inicial.TabIndex = 2;
            // 
            // LBL_Ate
            // 
            this.LBL_Ate.AutoSize = true;
            this.LBL_Ate.Location = new System.Drawing.Point(293, 99);
            this.LBL_Ate.Name = "LBL_Ate";
            this.LBL_Ate.Size = new System.Drawing.Size(26, 13);
            this.LBL_Ate.TabIndex = 3;
            this.LBL_Ate.Text = "Até:";
            this.LBL_Ate.Visible = false;
            // 
            // TXT_Final
            // 
            this.TXT_Final.Location = new System.Drawing.Point(325, 96);
            this.TXT_Final.Name = "TXT_Final";
            this.TXT_Final.Size = new System.Drawing.Size(100, 20);
            this.TXT_Final.TabIndex = 4;
            this.TXT_Final.Visible = false;
            // 
            // CHK_Mes
            // 
            this.CHK_Mes.AutoSize = true;
            this.CHK_Mes.Location = new System.Drawing.Point(466, 96);
            this.CHK_Mes.Name = "CHK_Mes";
            this.CHK_Mes.Size = new System.Drawing.Size(130, 17);
            this.CHK_Mes.TabIndex = 5;
            this.CHK_Mes.Text = "Gerar mais de um mês";
            this.CHK_Mes.UseVisualStyleBackColor = true;
            this.CHK_Mes.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(169, 134);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(86, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Com entrada";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // BTN_Relatorio
            // 
            this.BTN_Relatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Relatorio.Location = new System.Drawing.Point(219, 166);
            this.BTN_Relatorio.Name = "BTN_Relatorio";
            this.BTN_Relatorio.Size = new System.Drawing.Size(163, 50);
            this.BTN_Relatorio.TabIndex = 7;
            this.BTN_Relatorio.Text = "Gerar Relatório (Periodo)";
            this.BTN_Relatorio.UseVisualStyleBackColor = true;
            // 
            // FRM_GerarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 261);
            this.Controls.Add(this.BTN_Relatorio);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.CHK_Mes);
            this.Controls.Add(this.TXT_Final);
            this.Controls.Add(this.LBL_Ate);
            this.Controls.Add(this.TXT_Inicial);
            this.Controls.Add(this.LBL_Data);
            this.Controls.Add(this.LBL_Descricao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_GerarRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geração de relatorios";
            this.Load += new System.EventHandler(this.FRM_GerarRelatorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Descricao;
        private System.Windows.Forms.Label LBL_Data;
        private System.Windows.Forms.TextBox TXT_Inicial;
        private System.Windows.Forms.Label LBL_Ate;
        private System.Windows.Forms.TextBox TXT_Final;
        private System.Windows.Forms.CheckBox CHK_Mes;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button BTN_Relatorio;
    }
}