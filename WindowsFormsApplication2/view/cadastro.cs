using ICMS_PIS_COFFINS.controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            string ICMS = CBB_Icms.Text;
            string NomeBanco = TXT_NomeBanco.Text;
            string TabelaBanco = CBB_TabelaBanco.Text;


            String strConexao = "Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True";
            Conexao conexao = new Conexao(strConexao);
            SqlConnection conn = new SqlConnection(@"Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True");

            try
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
                comando.Parameters.AddWithValue("@P_ICMS", ICMS);
                comando.CommandType = CommandType.StoredProcedure;
                // executa a query
                comando.ExecuteNonQuery();
                // fecha a conexao 
                conn.Close();



            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }



        }

        private void FRM_Cadastro_Load(object sender, EventArgs e)
        {

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
        }

        private void BTN_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente excluir este cliente", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            switch (resultado)
            {
                case DialogResult.Yes:
                    try
                    {
                        string P_Codigo = TXT_NomeFantasia.Text ;
                        String strConexao = "Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True";
                        Conexao conexao = new Conexao(strConexao);
                        SqlConnection conn = new SqlConnection(@"Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True");

                        // cria o comando sql
                        SqlCommand comando = new SqlCommand("P_ExcluirEmpresa", conn);
                        // abre a conexao   
                        conn.Open();
                        //prepara a query
                        comando.Parameters.AddWithValue("@P_Codigo", P_Codigo);
                        comando.CommandType = CommandType.StoredProcedure;
                        // executa a query
                        comando.ExecuteNonQuery();
                        // fecha a conexao 
                        conn.Close();
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
    }

}