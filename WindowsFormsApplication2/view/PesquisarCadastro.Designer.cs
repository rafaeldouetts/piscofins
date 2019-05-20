namespace WindowsFormsApplication2.view
{
    partial class FRM_PesquisarCadastro
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PesquisarCadastro));
            this.LBL_Informacao = new System.Windows.Forms.Label();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.BTN_Procurar = new System.Windows.Forms.Button();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.TXT_Informacao = new System.Windows.Forms.TextBox();
            this.LBL_Campos = new System.Windows.Forms.Label();
            this.RBN_Codigo = new System.Windows.Forms.RadioButton();
            this.RBN_Nome = new System.Windows.Forms.RadioButton();
            this.LBL_Ordem = new System.Windows.Forms.Label();
            this.RBN_Crescente = new System.Windows.Forms.RadioButton();
            this.RBN_Descendente = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LBL_Informacao
            // 
            this.LBL_Informacao.AutoSize = true;
            this.LBL_Informacao.Location = new System.Drawing.Point(4, 1);
            this.LBL_Informacao.Name = "LBL_Informacao";
            this.LBL_Informacao.Size = new System.Drawing.Size(191, 13);
            this.LBL_Informacao.TabIndex = 0;
            this.LBL_Informacao.Text = "Escreve a informacao a ser consultada";
            this.LBL_Informacao.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTN_OK
            // 
            this.BTN_OK.Location = new System.Drawing.Point(346, 13);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.TabIndex = 1;
            this.BTN_OK.Text = "Ok";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_Procurar
            // 
            this.BTN_Procurar.Location = new System.Drawing.Point(346, 43);
            this.BTN_Procurar.Name = "BTN_Procurar";
            this.BTN_Procurar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Procurar.TabIndex = 2;
            this.BTN_Procurar.Text = "Procurar";
            this.BTN_Procurar.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.Location = new System.Drawing.Point(346, 73);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancelar.TabIndex = 3;
            this.BTN_Cancelar.Text = "Cancelar";
            this.BTN_Cancelar.UseVisualStyleBackColor = true;
            // 
            // TXT_Informacao
            // 
            this.TXT_Informacao.Location = new System.Drawing.Point(7, 15);
            this.TXT_Informacao.Name = "TXT_Informacao";
            this.TXT_Informacao.Size = new System.Drawing.Size(324, 20);
            this.TXT_Informacao.TabIndex = 4;
            // 
            // LBL_Campos
            // 
            this.LBL_Campos.AutoSize = true;
            this.LBL_Campos.Location = new System.Drawing.Point(7, 42);
            this.LBL_Campos.Name = "LBL_Campos";
            this.LBL_Campos.Size = new System.Drawing.Size(45, 13);
            this.LBL_Campos.TabIndex = 5;
            this.LBL_Campos.Text = "Campos";
            // 
            // RBN_Codigo
            // 
            this.RBN_Codigo.AutoSize = true;
            this.RBN_Codigo.Location = new System.Drawing.Point(7, 59);
            this.RBN_Codigo.Name = "RBN_Codigo";
            this.RBN_Codigo.Size = new System.Drawing.Size(57, 17);
            this.RBN_Codigo.TabIndex = 6;
            this.RBN_Codigo.TabStop = true;
            this.RBN_Codigo.Text = "codigo";
            this.RBN_Codigo.UseVisualStyleBackColor = true;
            // 
            // RBN_Nome
            // 
            this.RBN_Nome.AutoSize = true;
            this.RBN_Nome.Location = new System.Drawing.Point(7, 83);
            this.RBN_Nome.Name = "RBN_Nome";
            this.RBN_Nome.Size = new System.Drawing.Size(96, 17);
            this.RBN_Nome.TabIndex = 7;
            this.RBN_Nome.TabStop = true;
            this.RBN_Nome.Text = "Nome Fantasia";
            this.RBN_Nome.UseVisualStyleBackColor = true;
            // 
            // LBL_Ordem
            // 
            this.LBL_Ordem.AutoSize = true;
            this.LBL_Ordem.Location = new System.Drawing.Point(159, 42);
            this.LBL_Ordem.Name = "LBL_Ordem";
            this.LBL_Ordem.Size = new System.Drawing.Size(38, 13);
            this.LBL_Ordem.TabIndex = 8;
            this.LBL_Ordem.Text = "Ordem";
            // 
            // RBN_Crescente
            // 
            this.RBN_Crescente.AutoSize = true;
            this.RBN_Crescente.Location = new System.Drawing.Point(152, 59);
            this.RBN_Crescente.Name = "RBN_Crescente";
            this.RBN_Crescente.Size = new System.Drawing.Size(82, 17);
            this.RBN_Crescente.TabIndex = 9;
            this.RBN_Crescente.TabStop = true;
            this.RBN_Crescente.Text = "Ascendente";
            this.RBN_Crescente.UseVisualStyleBackColor = true;
            // 
            // RBN_Descendente
            // 
            this.RBN_Descendente.AutoSize = true;
            this.RBN_Descendente.Location = new System.Drawing.Point(152, 83);
            this.RBN_Descendente.Name = "RBN_Descendente";
            this.RBN_Descendente.Size = new System.Drawing.Size(89, 17);
            this.RBN_Descendente.TabIndex = 10;
            this.RBN_Descendente.TabStop = true;
            this.RBN_Descendente.Text = "Descendente";
            this.RBN_Descendente.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup3";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(7, 169);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(324, 97);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // FRM_PesquisarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 358);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.RBN_Descendente);
            this.Controls.Add(this.RBN_Crescente);
            this.Controls.Add(this.LBL_Ordem);
            this.Controls.Add(this.RBN_Nome);
            this.Controls.Add(this.RBN_Codigo);
            this.Controls.Add(this.LBL_Campos);
            this.Controls.Add(this.TXT_Informacao);
            this.Controls.Add(this.BTN_Cancelar);
            this.Controls.Add(this.BTN_Procurar);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.LBL_Informacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_PesquisarCadastro";
            this.Text = "PesquisarCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Informacao;
        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.Button BTN_Procurar;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.TextBox TXT_Informacao;
        private System.Windows.Forms.Label LBL_Campos;
        private System.Windows.Forms.RadioButton RBN_Codigo;
        private System.Windows.Forms.RadioButton RBN_Nome;
        private System.Windows.Forms.Label LBL_Ordem;
        private System.Windows.Forms.RadioButton RBN_Crescente;
        private System.Windows.Forms.RadioButton RBN_Descendente;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}