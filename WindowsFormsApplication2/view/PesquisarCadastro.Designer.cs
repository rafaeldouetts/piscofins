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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PesquisarCadastro));
            this.LBL_Informacao = new System.Windows.Forms.Label();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.BTN_Procurar = new System.Windows.Forms.Button();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.TXT_Informacao = new System.Windows.Forms.TextBox();
            this.LBL_Campos = new System.Windows.Forms.Label();
            this.RBN_Codigo = new System.Windows.Forms.RadioButton();
            this.RBN_Nome = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.testeDataSet = new WindowsFormsApplication2.testeDataSet();
            this.testeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testeDataSet1 = new WindowsFormsApplication2.testeDataSet1();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasTableAdapter = new WindowsFormsApplication2.testeDataSet1TableAdapters.EmpresasTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empresasTableAdapter1 = new WindowsFormsApplication2.testeDataSetTableAdapters.EmpresasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource1)).BeginInit();
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
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeFantasiaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empresasBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(7, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(266, 104);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // testeDataSet
            // 
            this.testeDataSet.DataSetName = "testeDataSet";
            this.testeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testeDataSetBindingSource
            // 
            this.testeDataSetBindingSource.DataSource = this.testeDataSet;
            this.testeDataSetBindingSource.Position = 0;
            // 
            // testeDataSet1
            // 
            this.testeDataSet1.DataSetName = "testeDataSet1";
            this.testeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.testeDataSet1;
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeFantasiaDataGridViewTextBoxColumn
            // 
            this.nomeFantasiaDataGridViewTextBoxColumn.DataPropertyName = "Nome_Fantasia";
            this.nomeFantasiaDataGridViewTextBoxColumn.HeaderText = "Nome_Fantasia";
            this.nomeFantasiaDataGridViewTextBoxColumn.Name = "nomeFantasiaDataGridViewTextBoxColumn";
            // 
            // empresasBindingSource1
            // 
            this.empresasBindingSource1.DataMember = "Empresas";
            this.empresasBindingSource1.DataSource = this.testeDataSetBindingSource;
            // 
            // empresasTableAdapter1
            // 
            this.empresasTableAdapter1.ClearBeforeFill = true;
            // 
            // FRM_PesquisarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 358);
            this.Controls.Add(this.dataGridView1);
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
            this.Load += new System.EventHandler(this.FRM_PesquisarCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private testeDataSet testeDataSet;
        private System.Windows.Forms.BindingSource testeDataSetBindingSource;
        private testeDataSet1 testeDataSet1;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private testeDataSet1TableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFantasiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource empresasBindingSource1;
        private testeDataSetTableAdapters.EmpresasTableAdapter empresasTableAdapter1;
    }
}