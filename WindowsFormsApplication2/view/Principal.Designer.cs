namespace ICMS_PIS_COFFINS
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_cad_lic = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroLicenciadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarSPEDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_cad_lic,
            this.importaçãoToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1072, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_cad_lic
            // 
            this.Menu_cad_lic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroLicenciadoToolStripMenuItem});
            this.Menu_cad_lic.Name = "Menu_cad_lic";
            this.Menu_cad_lic.Size = new System.Drawing.Size(66, 20);
            this.Menu_cad_lic.Text = "Cadastro";
            this.Menu_cad_lic.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // cadastroLicenciadoToolStripMenuItem
            // 
            this.cadastroLicenciadoToolStripMenuItem.Name = "cadastroLicenciadoToolStripMenuItem";
            this.cadastroLicenciadoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cadastroLicenciadoToolStripMenuItem.Text = "Cadastro Licenciado";
            this.cadastroLicenciadoToolStripMenuItem.Click += new System.EventHandler(this.cadastroLicenciadoToolStripMenuItem_Click);
            // 
            // importaçãoToolStripMenuItem
            // 
            this.importaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarSPEDToolStripMenuItem});
            this.importaçãoToolStripMenuItem.Name = "importaçãoToolStripMenuItem";
            this.importaçãoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.importaçãoToolStripMenuItem.Text = "Importação ";
            this.importaçãoToolStripMenuItem.Click += new System.EventHandler(this.importaçãoToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarRelatorioToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // importarSPEDToolStripMenuItem
            // 
            this.importarSPEDToolStripMenuItem.Name = "importarSPEDToolStripMenuItem";
            this.importarSPEDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importarSPEDToolStripMenuItem.Text = "Importar SPED";
            this.importarSPEDToolStripMenuItem.Click += new System.EventHandler(this.importarSPEDToolStripMenuItem_Click);
            // 
            // gerarRelatorioToolStripMenuItem
            // 
            this.gerarRelatorioToolStripMenuItem.Name = "gerarRelatorioToolStripMenuItem";
            this.gerarRelatorioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gerarRelatorioToolStripMenuItem.Text = "Gerar Relatorio";
            this.gerarRelatorioToolStripMenuItem.Click += new System.EventHandler(this.gerarRelatorioToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1072, 527);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Artvel Itapira";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_cad_lic;
        private System.Windows.Forms.ToolStripMenuItem cadastroLicenciadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarSPEDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}