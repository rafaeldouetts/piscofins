namespace ICMS_PIS_COFFINS
{
    partial class FRM_Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Cadastro));
            this.LBL_Codigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_Codigo = new System.Windows.Forms.TextBox();
            this.TXT_NomeFantasia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_RazaoSocial = new System.Windows.Forms.TextBox();
            this.LBL_Cnpj = new System.Windows.Forms.Label();
            this.LBL_Inscricao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Ativar = new System.Windows.Forms.Button();
            this.LBL_Endereco = new System.Windows.Forms.Label();
            this.LBL_N = new System.Windows.Forms.Label();
            this.LBL_Cnae = new System.Windows.Forms.Label();
            this.LBL_Email = new System.Windows.Forms.Label();
            this.LBL_Bairro = new System.Windows.Forms.Label();
            this.LBL_Cidade = new System.Windows.Forms.Label();
            this.LBL_Site = new System.Windows.Forms.Label();
            this.TXT_CNPJ = new System.Windows.Forms.TextBox();
            this.TXT_InscricaoEstadual = new System.Windows.Forms.TextBox();
            this.TXT_InscricaoMunicipal = new System.Windows.Forms.TextBox();
            this.TXT_Endereco = new System.Windows.Forms.TextBox();
            this.TXT_Numero = new System.Windows.Forms.TextBox();
            this.TXT_Cnae = new System.Windows.Forms.TextBox();
            this.TXT_Email = new System.Windows.Forms.TextBox();
            this.TXT_Bairro = new System.Windows.Forms.TextBox();
            this.TXT_Cidade = new System.Windows.Forms.TextBox();
            this.TXT_Site = new System.Windows.Forms.TextBox();
            this.LBL_Estado = new System.Windows.Forms.Label();
            this.CBB_Estado = new System.Windows.Forms.ComboBox();
            this.LBL_Cep = new System.Windows.Forms.Label();
            this.LBL_Nfe = new System.Windows.Forms.Label();
            this.CBB_Nfe = new System.Windows.Forms.ComboBox();
            this.LBL_TipoLucro = new System.Windows.Forms.Label();
            this.CBB_TipoLucro = new System.Windows.Forms.ComboBox();
            this.TXT_Cep = new System.Windows.Forms.TextBox();
            this.LBL_Banco = new System.Windows.Forms.Label();
            this.TXT_NomeBanco = new System.Windows.Forms.TextBox();
            this.BTN_CriarBanco = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_Filiais = new System.Windows.Forms.TextBox();
            this.BTN_Salvar = new System.Windows.Forms.Button();
            this.BTN_Editar = new System.Windows.Forms.Button();
            this.BTN_Excluir = new System.Windows.Forms.Button();
            this.BTN_Pesquisar = new System.Windows.Forms.Button();
            this.BTN_Novo = new System.Windows.Forms.Button();
            this.CBB_TabelaBanco = new System.Windows.Forms.ComboBox();
            this.cfopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTG_Cfop = new System.Windows.Forms.DataGridView();
            this.DTG_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTG_Saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cfopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Cfop)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Codigo
            // 
            this.LBL_Codigo.AutoSize = true;
            this.LBL_Codigo.Location = new System.Drawing.Point(16, 70);
            this.LBL_Codigo.Name = "LBL_Codigo";
            this.LBL_Codigo.Size = new System.Drawing.Size(40, 13);
            this.LBL_Codigo.TabIndex = 0;
            this.LBL_Codigo.Text = "Codigo";
            this.LBL_Codigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razão Social";
            // 
            // TXT_Codigo
            // 
            this.TXT_Codigo.Enabled = false;
            this.TXT_Codigo.Location = new System.Drawing.Point(13, 86);
            this.TXT_Codigo.Name = "TXT_Codigo";
            this.TXT_Codigo.Size = new System.Drawing.Size(55, 20);
            this.TXT_Codigo.TabIndex = 3;
            this.TXT_Codigo.TextChanged += new System.EventHandler(this.TXT_Codigo_TextChanged);
            // 
            // TXT_NomeFantasia
            // 
            this.TXT_NomeFantasia.Enabled = false;
            this.TXT_NomeFantasia.Location = new System.Drawing.Point(102, 86);
            this.TXT_NomeFantasia.Name = "TXT_NomeFantasia";
            this.TXT_NomeFantasia.Size = new System.Drawing.Size(172, 20);
            this.TXT_NomeFantasia.TabIndex = 4;
            this.TXT_NomeFantasia.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Fantasia";
            // 
            // TXT_RazaoSocial
            // 
            this.TXT_RazaoSocial.Enabled = false;
            this.TXT_RazaoSocial.Location = new System.Drawing.Point(301, 86);
            this.TXT_RazaoSocial.Name = "TXT_RazaoSocial";
            this.TXT_RazaoSocial.Size = new System.Drawing.Size(201, 20);
            this.TXT_RazaoSocial.TabIndex = 5;
            // 
            // LBL_Cnpj
            // 
            this.LBL_Cnpj.AutoSize = true;
            this.LBL_Cnpj.Location = new System.Drawing.Point(13, 124);
            this.LBL_Cnpj.Name = "LBL_Cnpj";
            this.LBL_Cnpj.Size = new System.Drawing.Size(34, 13);
            this.LBL_Cnpj.TabIndex = 6;
            this.LBL_Cnpj.Text = "CNPJ";
            this.LBL_Cnpj.Click += new System.EventHandler(this.label2_Click);
            // 
            // LBL_Inscricao
            // 
            this.LBL_Inscricao.AutoSize = true;
            this.LBL_Inscricao.Location = new System.Drawing.Point(307, 125);
            this.LBL_Inscricao.Name = "LBL_Inscricao";
            this.LBL_Inscricao.Size = new System.Drawing.Size(94, 13);
            this.LBL_Inscricao.TabIndex = 7;
            this.LBL_Inscricao.Text = "Inscrição Estadual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Inscricao Municipal";
            // 
            // BTN_Ativar
            // 
            this.BTN_Ativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Ativar.Location = new System.Drawing.Point(213, 184);
            this.BTN_Ativar.Name = "BTN_Ativar";
            this.BTN_Ativar.Size = new System.Drawing.Size(110, 50);
            this.BTN_Ativar.TabIndex = 9;
            this.BTN_Ativar.Text = "Ativar";
            this.BTN_Ativar.UseVisualStyleBackColor = true;
            // 
            // LBL_Endereco
            // 
            this.LBL_Endereco.AutoSize = true;
            this.LBL_Endereco.Location = new System.Drawing.Point(16, 249);
            this.LBL_Endereco.Name = "LBL_Endereco";
            this.LBL_Endereco.Size = new System.Drawing.Size(53, 13);
            this.LBL_Endereco.TabIndex = 10;
            this.LBL_Endereco.Text = "Endereco";
            // 
            // LBL_N
            // 
            this.LBL_N.AutoSize = true;
            this.LBL_N.Location = new System.Drawing.Point(186, 249);
            this.LBL_N.Name = "LBL_N";
            this.LBL_N.Size = new System.Drawing.Size(19, 13);
            this.LBL_N.TabIndex = 11;
            this.LBL_N.Text = "Nº";
            // 
            // LBL_Cnae
            // 
            this.LBL_Cnae.AutoSize = true;
            this.LBL_Cnae.Location = new System.Drawing.Point(307, 247);
            this.LBL_Cnae.Name = "LBL_Cnae";
            this.LBL_Cnae.Size = new System.Drawing.Size(66, 13);
            this.LBL_Cnae.TabIndex = 12;
            this.LBL_Cnae.Text = "CNAE Fiscal";
            // 
            // LBL_Email
            // 
            this.LBL_Email.AutoSize = true;
            this.LBL_Email.Location = new System.Drawing.Point(510, 247);
            this.LBL_Email.Name = "LBL_Email";
            this.LBL_Email.Size = new System.Drawing.Size(36, 13);
            this.LBL_Email.TabIndex = 13;
            this.LBL_Email.Text = "E-Mail";
            // 
            // LBL_Bairro
            // 
            this.LBL_Bairro.AutoSize = true;
            this.LBL_Bairro.Location = new System.Drawing.Point(16, 307);
            this.LBL_Bairro.Name = "LBL_Bairro";
            this.LBL_Bairro.Size = new System.Drawing.Size(34, 13);
            this.LBL_Bairro.TabIndex = 14;
            this.LBL_Bairro.Text = "Bairro";
            // 
            // LBL_Cidade
            // 
            this.LBL_Cidade.AutoSize = true;
            this.LBL_Cidade.Location = new System.Drawing.Point(186, 308);
            this.LBL_Cidade.Name = "LBL_Cidade";
            this.LBL_Cidade.Size = new System.Drawing.Size(40, 13);
            this.LBL_Cidade.TabIndex = 15;
            this.LBL_Cidade.Text = "Cidade";
            // 
            // LBL_Site
            // 
            this.LBL_Site.AutoSize = true;
            this.LBL_Site.Location = new System.Drawing.Point(307, 307);
            this.LBL_Site.Name = "LBL_Site";
            this.LBL_Site.Size = new System.Drawing.Size(25, 13);
            this.LBL_Site.TabIndex = 16;
            this.LBL_Site.Text = "Site";
            this.LBL_Site.Click += new System.EventHandler(this.LBL_Site_Click);
            // 
            // TXT_CNPJ
            // 
            this.TXT_CNPJ.Enabled = false;
            this.TXT_CNPJ.Location = new System.Drawing.Point(10, 141);
            this.TXT_CNPJ.Name = "TXT_CNPJ";
            this.TXT_CNPJ.Size = new System.Drawing.Size(154, 20);
            this.TXT_CNPJ.TabIndex = 17;
            // 
            // TXT_InscricaoEstadual
            // 
            this.TXT_InscricaoEstadual.Enabled = false;
            this.TXT_InscricaoEstadual.Location = new System.Drawing.Point(301, 141);
            this.TXT_InscricaoEstadual.Name = "TXT_InscricaoEstadual";
            this.TXT_InscricaoEstadual.Size = new System.Drawing.Size(201, 20);
            this.TXT_InscricaoEstadual.TabIndex = 18;
            // 
            // TXT_InscricaoMunicipal
            // 
            this.TXT_InscricaoMunicipal.Enabled = false;
            this.TXT_InscricaoMunicipal.Location = new System.Drawing.Point(10, 201);
            this.TXT_InscricaoMunicipal.Name = "TXT_InscricaoMunicipal";
            this.TXT_InscricaoMunicipal.Size = new System.Drawing.Size(154, 20);
            this.TXT_InscricaoMunicipal.TabIndex = 19;
            // 
            // TXT_Endereco
            // 
            this.TXT_Endereco.Enabled = false;
            this.TXT_Endereco.Location = new System.Drawing.Point(10, 266);
            this.TXT_Endereco.Name = "TXT_Endereco";
            this.TXT_Endereco.Size = new System.Drawing.Size(154, 20);
            this.TXT_Endereco.TabIndex = 20;
            // 
            // TXT_Numero
            // 
            this.TXT_Numero.Enabled = false;
            this.TXT_Numero.Location = new System.Drawing.Point(186, 265);
            this.TXT_Numero.Name = "TXT_Numero";
            this.TXT_Numero.Size = new System.Drawing.Size(37, 20);
            this.TXT_Numero.TabIndex = 21;
            // 
            // TXT_Cnae
            // 
            this.TXT_Cnae.Enabled = false;
            this.TXT_Cnae.Location = new System.Drawing.Point(301, 265);
            this.TXT_Cnae.Name = "TXT_Cnae";
            this.TXT_Cnae.Size = new System.Drawing.Size(201, 20);
            this.TXT_Cnae.TabIndex = 22;
            this.TXT_Cnae.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // TXT_Email
            // 
            this.TXT_Email.Enabled = false;
            this.TXT_Email.Location = new System.Drawing.Point(513, 265);
            this.TXT_Email.Name = "TXT_Email";
            this.TXT_Email.Size = new System.Drawing.Size(198, 20);
            this.TXT_Email.TabIndex = 23;
            // 
            // TXT_Bairro
            // 
            this.TXT_Bairro.Enabled = false;
            this.TXT_Bairro.Location = new System.Drawing.Point(10, 325);
            this.TXT_Bairro.Name = "TXT_Bairro";
            this.TXT_Bairro.Size = new System.Drawing.Size(154, 20);
            this.TXT_Bairro.TabIndex = 24;
            // 
            // TXT_Cidade
            // 
            this.TXT_Cidade.Enabled = false;
            this.TXT_Cidade.Location = new System.Drawing.Point(186, 324);
            this.TXT_Cidade.Name = "TXT_Cidade";
            this.TXT_Cidade.Size = new System.Drawing.Size(100, 20);
            this.TXT_Cidade.TabIndex = 25;
            // 
            // TXT_Site
            // 
            this.TXT_Site.Enabled = false;
            this.TXT_Site.Location = new System.Drawing.Point(301, 323);
            this.TXT_Site.Name = "TXT_Site";
            this.TXT_Site.Size = new System.Drawing.Size(201, 20);
            this.TXT_Site.TabIndex = 26;
            // 
            // LBL_Estado
            // 
            this.LBL_Estado.AutoSize = true;
            this.LBL_Estado.Location = new System.Drawing.Point(13, 352);
            this.LBL_Estado.Name = "LBL_Estado";
            this.LBL_Estado.Size = new System.Drawing.Size(40, 13);
            this.LBL_Estado.TabIndex = 27;
            this.LBL_Estado.Text = "Estado";
            // 
            // CBB_Estado
            // 
            this.CBB_Estado.DisplayMember = "nome";
            this.CBB_Estado.Enabled = false;
            this.CBB_Estado.FormattingEnabled = true;
            this.CBB_Estado.Location = new System.Drawing.Point(10, 368);
            this.CBB_Estado.Name = "CBB_Estado";
            this.CBB_Estado.Size = new System.Drawing.Size(154, 21);
            this.CBB_Estado.TabIndex = 28;
            this.CBB_Estado.ValueMember = "nome";
            // 
            // LBL_Cep
            // 
            this.LBL_Cep.AutoSize = true;
            this.LBL_Cep.Location = new System.Drawing.Point(186, 352);
            this.LBL_Cep.Name = "LBL_Cep";
            this.LBL_Cep.Size = new System.Drawing.Size(28, 13);
            this.LBL_Cep.TabIndex = 29;
            this.LBL_Cep.Text = "CEP";
            // 
            // LBL_Nfe
            // 
            this.LBL_Nfe.AutoSize = true;
            this.LBL_Nfe.Location = new System.Drawing.Point(301, 352);
            this.LBL_Nfe.Name = "LBL_Nfe";
            this.LBL_Nfe.Size = new System.Drawing.Size(132, 13);
            this.LBL_Nfe.TabIndex = 30;
            this.LBL_Nfe.Text = "NFE - Cod.IBGE Municipio";
            // 
            // CBB_Nfe
            // 
            this.CBB_Nfe.Enabled = false;
            this.CBB_Nfe.FormattingEnabled = true;
            this.CBB_Nfe.Location = new System.Drawing.Point(301, 367);
            this.CBB_Nfe.Name = "CBB_Nfe";
            this.CBB_Nfe.Size = new System.Drawing.Size(201, 21);
            this.CBB_Nfe.TabIndex = 31;
            // 
            // LBL_TipoLucro
            // 
            this.LBL_TipoLucro.AutoSize = true;
            this.LBL_TipoLucro.Location = new System.Drawing.Point(510, 352);
            this.LBL_TipoLucro.Name = "LBL_TipoLucro";
            this.LBL_TipoLucro.Size = new System.Drawing.Size(73, 13);
            this.LBL_TipoLucro.TabIndex = 32;
            this.LBL_TipoLucro.Text = "Tipo de Lucro";
            // 
            // CBB_TipoLucro
            // 
            this.CBB_TipoLucro.Enabled = false;
            this.CBB_TipoLucro.FormattingEnabled = true;
            this.CBB_TipoLucro.Location = new System.Drawing.Point(513, 367);
            this.CBB_TipoLucro.Name = "CBB_TipoLucro";
            this.CBB_TipoLucro.Size = new System.Drawing.Size(198, 21);
            this.CBB_TipoLucro.TabIndex = 33;
            // 
            // TXT_Cep
            // 
            this.TXT_Cep.Enabled = false;
            this.TXT_Cep.Location = new System.Drawing.Point(186, 368);
            this.TXT_Cep.Name = "TXT_Cep";
            this.TXT_Cep.Size = new System.Drawing.Size(100, 20);
            this.TXT_Cep.TabIndex = 36;
            // 
            // LBL_Banco
            // 
            this.LBL_Banco.AutoSize = true;
            this.LBL_Banco.Location = new System.Drawing.Point(7, 470);
            this.LBL_Banco.Name = "LBL_Banco";
            this.LBL_Banco.Size = new System.Drawing.Size(87, 13);
            this.LBL_Banco.TabIndex = 37;
            this.LBL_Banco.Text = "Banco de Dados";
            // 
            // TXT_NomeBanco
            // 
            this.TXT_NomeBanco.Location = new System.Drawing.Point(100, 463);
            this.TXT_NomeBanco.Name = "TXT_NomeBanco";
            this.TXT_NomeBanco.Size = new System.Drawing.Size(186, 20);
            this.TXT_NomeBanco.TabIndex = 38;
            // 
            // BTN_CriarBanco
            // 
            this.BTN_CriarBanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CriarBanco.Location = new System.Drawing.Point(507, 463);
            this.BTN_CriarBanco.Name = "BTN_CriarBanco";
            this.BTN_CriarBanco.Size = new System.Drawing.Size(123, 23);
            this.BTN_CriarBanco.TabIndex = 40;
            this.BTN_CriarBanco.Text = "Criar Novo Banco";
            this.BTN_CriarBanco.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Selecionar CFOP\'S ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Filiais";
            // 
            // TXT_Filiais
            // 
            this.TXT_Filiais.Location = new System.Drawing.Point(437, 534);
            this.TXT_Filiais.Name = "TXT_Filiais";
            this.TXT_Filiais.Size = new System.Drawing.Size(100, 20);
            this.TXT_Filiais.TabIndex = 43;
            // 
            // BTN_Salvar
            // 
            this.BTN_Salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Salvar.BackgroundImage")));
            this.BTN_Salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Salvar.Location = new System.Drawing.Point(61, 26);
            this.BTN_Salvar.Name = "BTN_Salvar";
            this.BTN_Salvar.Size = new System.Drawing.Size(33, 28);
            this.BTN_Salvar.TabIndex = 44;
            this.BTN_Salvar.UseVisualStyleBackColor = true;
            this.BTN_Salvar.Click += new System.EventHandler(this.BTN_Salvar_Click);
            // 
            // BTN_Editar
            // 
            this.BTN_Editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Editar.BackgroundImage")));
            this.BTN_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Editar.Location = new System.Drawing.Point(100, 26);
            this.BTN_Editar.Name = "BTN_Editar";
            this.BTN_Editar.Size = new System.Drawing.Size(33, 28);
            this.BTN_Editar.TabIndex = 45;
            this.BTN_Editar.UseVisualStyleBackColor = true;
            this.BTN_Editar.Click += new System.EventHandler(this.BTN_Editar_Click);
            // 
            // BTN_Excluir
            // 
            this.BTN_Excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Excluir.BackgroundImage")));
            this.BTN_Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Excluir.Location = new System.Drawing.Point(139, 26);
            this.BTN_Excluir.Name = "BTN_Excluir";
            this.BTN_Excluir.Size = new System.Drawing.Size(33, 28);
            this.BTN_Excluir.TabIndex = 46;
            this.BTN_Excluir.UseVisualStyleBackColor = true;
            this.BTN_Excluir.Click += new System.EventHandler(this.BTN_Excluir_Click);
            // 
            // BTN_Pesquisar
            // 
            this.BTN_Pesquisar.AccessibleDescription = "";
            this.BTN_Pesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Pesquisar.BackgroundImage")));
            this.BTN_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Pesquisar.Location = new System.Drawing.Point(178, 26);
            this.BTN_Pesquisar.Name = "BTN_Pesquisar";
            this.BTN_Pesquisar.Size = new System.Drawing.Size(33, 28);
            this.BTN_Pesquisar.TabIndex = 47;
            this.BTN_Pesquisar.UseVisualStyleBackColor = true;
            this.BTN_Pesquisar.Click += new System.EventHandler(this.BTN_Pesquisar_Click);
            // 
            // BTN_Novo
            // 
            this.BTN_Novo.AccessibleDescription = "";
            this.BTN_Novo.AccessibleName = "";
            this.BTN_Novo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Novo.BackgroundImage")));
            this.BTN_Novo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Novo.Location = new System.Drawing.Point(20, 26);
            this.BTN_Novo.Name = "BTN_Novo";
            this.BTN_Novo.Size = new System.Drawing.Size(33, 28);
            this.BTN_Novo.TabIndex = 48;
            this.BTN_Novo.Tag = "";
            this.BTN_Novo.UseVisualStyleBackColor = true;
            this.BTN_Novo.Click += new System.EventHandler(this.BTN_Novo_Click);
            // 
            // CBB_TabelaBanco
            // 
            this.CBB_TabelaBanco.FormattingEnabled = true;
            this.CBB_TabelaBanco.Location = new System.Drawing.Point(301, 462);
            this.CBB_TabelaBanco.Name = "CBB_TabelaBanco";
            this.CBB_TabelaBanco.Size = new System.Drawing.Size(198, 21);
            this.CBB_TabelaBanco.TabIndex = 49;
            // 
            // DTG_Cfop
            // 
            this.DTG_Cfop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_Cfop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DTG_entrada,
            this.DTG_Saida});
            this.DTG_Cfop.Location = new System.Drawing.Point(10, 534);
            this.DTG_Cfop.MaximumSize = new System.Drawing.Size(534, 534);
            this.DTG_Cfop.Name = "DTG_Cfop";
            this.DTG_Cfop.Size = new System.Drawing.Size(251, 140);
            this.DTG_Cfop.TabIndex = 50;
            this.DTG_Cfop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // DTG_entrada
            // 
            this.DTG_entrada.HeaderText = "Entrada";
            this.DTG_entrada.Name = "DTG_entrada";
            // 
            // DTG_Saida
            // 
            this.DTG_Saida.HeaderText = "Saida";
            this.DTG_Saida.Name = "DTG_Saida";
            // 
            // FRM_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 704);
            this.Controls.Add(this.DTG_Cfop);
            this.Controls.Add(this.CBB_TabelaBanco);
            this.Controls.Add(this.BTN_Novo);
            this.Controls.Add(this.BTN_Pesquisar);
            this.Controls.Add(this.BTN_Excluir);
            this.Controls.Add(this.BTN_Editar);
            this.Controls.Add(this.BTN_Salvar);
            this.Controls.Add(this.TXT_Filiais);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_CriarBanco);
            this.Controls.Add(this.TXT_NomeBanco);
            this.Controls.Add(this.LBL_Banco);
            this.Controls.Add(this.TXT_Cep);
            this.Controls.Add(this.CBB_TipoLucro);
            this.Controls.Add(this.LBL_TipoLucro);
            this.Controls.Add(this.CBB_Nfe);
            this.Controls.Add(this.LBL_Nfe);
            this.Controls.Add(this.LBL_Cep);
            this.Controls.Add(this.CBB_Estado);
            this.Controls.Add(this.LBL_Estado);
            this.Controls.Add(this.TXT_Site);
            this.Controls.Add(this.TXT_Cidade);
            this.Controls.Add(this.TXT_Bairro);
            this.Controls.Add(this.TXT_Email);
            this.Controls.Add(this.TXT_Cnae);
            this.Controls.Add(this.TXT_Numero);
            this.Controls.Add(this.TXT_Endereco);
            this.Controls.Add(this.TXT_InscricaoMunicipal);
            this.Controls.Add(this.TXT_InscricaoEstadual);
            this.Controls.Add(this.TXT_CNPJ);
            this.Controls.Add(this.LBL_Site);
            this.Controls.Add(this.LBL_Cidade);
            this.Controls.Add(this.LBL_Bairro);
            this.Controls.Add(this.LBL_Email);
            this.Controls.Add(this.LBL_Cnae);
            this.Controls.Add(this.LBL_N);
            this.Controls.Add(this.LBL_Endereco);
            this.Controls.Add(this.BTN_Ativar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBL_Inscricao);
            this.Controls.Add(this.LBL_Cnpj);
            this.Controls.Add(this.TXT_RazaoSocial);
            this.Controls.Add(this.TXT_NomeFantasia);
            this.Controls.Add(this.TXT_Codigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_Codigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Cadastro";
            this.Text = "cadastro";
            this.Load += new System.EventHandler(this.FRM_Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cfopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Cfop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_NomeFantasia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_RazaoSocial;
        private System.Windows.Forms.Label LBL_Cnpj;
        private System.Windows.Forms.Label LBL_Inscricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Ativar;
        private System.Windows.Forms.Label LBL_Endereco;
        private System.Windows.Forms.Label LBL_N;
        private System.Windows.Forms.Label LBL_Cnae;
        private System.Windows.Forms.Label LBL_Email;
        private System.Windows.Forms.Label LBL_Bairro;
        private System.Windows.Forms.Label LBL_Cidade;
        private System.Windows.Forms.Label LBL_Site;
        private System.Windows.Forms.TextBox TXT_CNPJ;
        public System.Windows.Forms.TextBox TXT_InscricaoEstadual;
        private System.Windows.Forms.TextBox TXT_InscricaoMunicipal;
        private System.Windows.Forms.TextBox TXT_Endereco;
        private System.Windows.Forms.TextBox TXT_Numero;
        private System.Windows.Forms.TextBox TXT_Cnae;
        private System.Windows.Forms.TextBox TXT_Email;
        private System.Windows.Forms.TextBox TXT_Bairro;
        private System.Windows.Forms.TextBox TXT_Cidade;
        private System.Windows.Forms.TextBox TXT_Site;
        private System.Windows.Forms.Label LBL_Estado;
        private System.Windows.Forms.ComboBox CBB_Estado;
        private System.Windows.Forms.Label LBL_Cep;
        private System.Windows.Forms.Label LBL_Nfe;
        private System.Windows.Forms.ComboBox CBB_Nfe;
        private System.Windows.Forms.Label LBL_TipoLucro;
        private System.Windows.Forms.ComboBox CBB_TipoLucro;
        private System.Windows.Forms.TextBox TXT_Cep;
        private System.Windows.Forms.Label LBL_Banco;
        private System.Windows.Forms.TextBox TXT_NomeBanco;
        private System.Windows.Forms.Button BTN_CriarBanco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_Filiais;
        private System.Windows.Forms.Button BTN_Salvar;
        private System.Windows.Forms.Button BTN_Editar;
        private System.Windows.Forms.Button BTN_Excluir;
        private System.Windows.Forms.Button BTN_Pesquisar;
        private System.Windows.Forms.Button BTN_Novo;
        private System.Windows.Forms.ComboBox CBB_TabelaBanco;
        public System.Windows.Forms.TextBox TXT_Codigo;
        private System.Windows.Forms.BindingSource cfopBindingSource;
        private System.Windows.Forms.DataGridView DTG_Cfop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTG_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTG_Saida;
 
    }
    
}