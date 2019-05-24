using ICMS_PIS_COFFINS.controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.controler;
using WindowsFormsApplication2.view;

namespace ICMS_PIS_COFFINS
{
    public partial class FRM_Cadastro : Form
    {


        public FRM_Cadastro()
        {
            InitializeComponent();


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LBL_Site_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTN_Novo_Click(object sender, EventArgs e)
        {
            string NomeFantasia = TXT_NomeFantasia.Text;
            string RazaoSocial = TXT_RazaoSocial.Text;
            string CNPJ = TXT_CNPJ.Text;
            string InscricaoEstadual = TXT_InscricaoEstadual.Text;
            string InscricaoMunicipal = TXT_InscricaoMunicipal.Text;
            string Endereco = TXT_Endereco.Text;
            string Numero = TXT_Numero.Text;
            string CNAe = TXT_Cnae.Text;
            string Email = TXT_Email.Text;
            string Bairro = TXT_Bairro.Text;
            string Cidade = TXT_Cidade.Text;
            string Site = TXT_Site.Text;
            string Estado = CBB_Estado.Text;
            string Cep = TXT_Cep.Text;
            string NFE = CBB_Nfe.Text;
            string TipoLucro = CBB_TipoLucro.Text;
            string NomeBanco = TXT_NomeBanco.Text;
            string TabelaBanco = CBB_TabelaBanco.Text;


            String strConexao = "Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True";
            Conexao conexao = new Conexao(strConexao);
            SqlConnection conn = new SqlConnection(@"Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True");

            try
            {
                if (TXT_NomeFantasia.Text != "")
                {
                    // cria o comando sql
                    SqlCommand comando = new SqlCommand("P_InsertEmpresa", conn);
                    // abre a conexao
                    conn.Open();
                    //prepara a query
                    comando.Parameters.AddWithValue("@p_NomeFantasia", NomeFantasia);
                    comando.Parameters.AddWithValue("@P_RazaoSocial", RazaoSocial);
                    comando.Parameters.AddWithValue("@P_CNPJ", CNPJ);
                    comando.Parameters.AddWithValue("@P_InscricaoEstadual", InscricaoEstadual);
                    comando.Parameters.AddWithValue("@P_InscricaoMunicipal", InscricaoMunicipal);
                    comando.Parameters.AddWithValue("@P_Endereco", Endereco);
                    comando.Parameters.AddWithValue("@P_Numero", Numero);
                    comando.Parameters.AddWithValue("@P_CNAe", CNAe);
                    comando.Parameters.AddWithValue("@P_Email", Email);
                    comando.Parameters.AddWithValue("@P_Bairro", Bairro);
                    comando.Parameters.AddWithValue("@P_Cidade", Cidade);
                    comando.Parameters.AddWithValue("@P_Sites", Site);
                    comando.Parameters.AddWithValue("@P_Estado", Estado);
                    comando.Parameters.AddWithValue("@P_Cep", Cep);
                    comando.Parameters.AddWithValue("@P_NFE", NFE);
                    comando.Parameters.AddWithValue("@P_TipoLucro", TipoLucro);
                    comando.CommandType = CommandType.StoredProcedure;
                    // executa a query
                    comando.ExecuteNonQuery();
                    // fecha a conexao 
                    conn.Close();
                    MessageBox.Show("empresa cadastrada com sucesso");
                }
                else {
                    TXT_NomeFantasia.BackColor = Color.Yellow;
                    MessageBox.Show("campo em amarelo obrigatorio");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }



        }

        private void FRM_Cadastro_Load(object sender, EventArgs e)
        {
            TXT_Codigo.Text = p.Codigo;
            TXT_NomeFantasia.Text = p.NomeFantasia;
            TXT_RazaoSocial.Text = p.RazaoSocial;
            TXT_CNPJ.Text = p.CNPJ;
            TXT_InscricaoEstadual.Text = p.InscricaoEstadual;
            TXT_InscricaoMunicipal.Text = p.InscricaoMunicipal;
            TXT_Endereco.Text = p.Endereco;
            TXT_Numero.Text = p.Numero;
            TXT_Cnae.Text = p.Cnae;
            TXT_Email.Text = p.Email;
            TXT_Bairro.Text = p.Bairro;
            TXT_Cidade.Text = p.Cidade;
            TXT_Site.Text = p.Site;
            CBB_Estado.Text = p.Estado;
            TXT_Cep.Text = p.Cep;
            CBB_Nfe.Text = p.Nfe;
            CBB_TipoLucro.Text = p.TipoLucro;
            if (p.ListaCfop != 0)
            {
                DTG_Cfop.Rows[0].Cells[0].Value = p.ListaCfop;
            }
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Pesquisar_Click(object sender, EventArgs e)
        {// verifica se algum form ja foi aberto
            if (Application.OpenForms.OfType<FRM_PesquisarCadastro>().Count() > 0)
            {
                MessageBox.Show("Pesquisar já está aberto!");
            }
            // abre o form
            else {
                FRM_PesquisarCadastro novaform = new FRM_PesquisarCadastro();
                novaform.Show();
            }
            this.Close();
        }

        private void BTN_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente excluir este cliente", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            switch (resultado)
            {
                case DialogResult.Yes:
                    try
                    {

                        string P_Codigo = TXT_Codigo.Text;
                        String strConexao = "Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True";
                        Conexao conexao = new Conexao(strConexao);
                        SqlConnection conn = new SqlConnection(@"Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True");

                        int valor = Convert.ToInt32(P_Codigo);
                        // cria o comando sql
                        SqlCommand comando = new SqlCommand("P_Excluir_Empresa", conn);
                        // abre a conexao   
                        conn.Open();
                        //prepara a query
                        comando.Parameters.AddWithValue("@P_Codigo", valor);
                        comando.CommandType = CommandType.StoredProcedure;
                        // executa a query
                        comando.ExecuteNonQuery();
                        // fecha a conexao 
                        conn.Close();
                        MessageBox.Show("Cliente excluido com sucesso", "Confirmação de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                    }

                    break;
                case DialogResult.No:
                    MessageBox.Show("cliente nao excluido", "Confirmação de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;


            }
        }

        private void BTN_Editar_Click(object sender, EventArgs e)
        {
            TXT_NomeFantasia.Enabled = true;
            TXT_RazaoSocial.Enabled = true;
            TXT_CNPJ.Enabled = true;
            TXT_InscricaoEstadual.Enabled = true;
            TXT_InscricaoMunicipal.Enabled = true;
            TXT_Endereco.Enabled = true;
            TXT_Numero.Enabled = true;
            TXT_Cnae.Enabled = true;
            TXT_Email.Enabled = true;
            TXT_Bairro.Enabled = true;
            TXT_Cidade.Enabled = true;
            TXT_Site.Enabled = true;
            CBB_Estado.Enabled = true;
            TXT_Cep.Enabled = true;
            CBB_Nfe.Enabled = true;
            CBB_TipoLucro.Enabled = true;
        }

        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            string Codigo = TXT_Codigo.Text;
            string NomeFantasia = TXT_NomeFantasia.Text;
            string RazaoSocial = TXT_RazaoSocial.Text;
            string CNPJ = TXT_CNPJ.Text;
            string InscricaoEstadual = TXT_InscricaoEstadual.Text;
            string InscricaoMunicipal = TXT_InscricaoMunicipal.Text;
            string Endereco = TXT_Endereco.Text;
            string Numero = TXT_Numero.Text;
            string CNAe = TXT_Cnae.Text;
            string Email = TXT_Email.Text;
            string Bairro = TXT_Bairro.Text;
            string Cidade = TXT_Cidade.Text;
            string Site = TXT_Site.Text;
            string Estado = CBB_Estado.Text;
            string Cep = TXT_Cep.Text;
            string NFE = CBB_Nfe.Text;
            string TipoLucro = CBB_TipoLucro.Text;
            string NomeBanco = TXT_NomeBanco.Text;
            string TabelaBanco = CBB_TabelaBanco.Text;

            String strConexao = "Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True";
            Conexao conexao = new Conexao(strConexao);
            SqlConnection conn = new SqlConnection(@"Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True");
            try
            { if (TXT_Codigo.Text != "")
                {
                    // cria o comando sql
                    SqlCommand comando = new SqlCommand("P_Atualizar_Empresa", conn);
                    // abre a conexao
                    conn.Open();
                    //prepara a query
                    comando.Parameters.AddWithValue("@P_Codigo", Codigo);
                    comando.Parameters.AddWithValue("@P_Nome_Fantasia", NomeFantasia);
                    comando.Parameters.AddWithValue("@P_Razao_Social", RazaoSocial);
                    comando.Parameters.AddWithValue("@P_CNPJ", CNPJ);
                    comando.Parameters.AddWithValue("@P_Inscricao_Estadual", InscricaoEstadual);
                    comando.Parameters.AddWithValue("@P_InscricaoMunicipal", InscricaoMunicipal);
                    comando.Parameters.AddWithValue("@P_Endereco", Endereco);
                    comando.Parameters.AddWithValue("@P_Numero", Numero);
                    comando.Parameters.AddWithValue("@P_CNAe", CNAe);
                    comando.Parameters.AddWithValue("@P_Email", Email);
                    comando.Parameters.AddWithValue("@P_Bairro", Bairro);
                    comando.Parameters.AddWithValue("@P_Cidade", Cidade);
                    comando.Parameters.AddWithValue("@P_Sites", Site);
                    comando.Parameters.AddWithValue("@P_Estado", Estado);
                    comando.Parameters.AddWithValue("@P_Cep", Cep);
                    comando.Parameters.AddWithValue("@P_NFE", NFE);
                    comando.Parameters.AddWithValue("@P_TipoLucro", TipoLucro);
                    comando.CommandType = CommandType.StoredProcedure;
                    // executa a query
                    comando.ExecuteNonQuery();
                    // fecha a conexao 
                    conn.Close();
                    MessageBox.Show("Atualização efetuada com sucesso ");
                }
                else {
                    MessageBox.Show("Por favor pesquise a empresa primeiro");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void TXT_Codigo_TextChanged(object sender, EventArgs e)
        {
            TXT_Codigo.Text = p.Codigo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TXT_Codigo.Text = p.Codigo;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

          
        }

    }
}
