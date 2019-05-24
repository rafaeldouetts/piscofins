using ICMS_PIS_COFFINS;
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
using WindowsFormsApplication2.controler;

namespace WindowsFormsApplication2.view
{
    public partial class FRM_PesquisarCadastro : Form
    {
        string Codigo = "";
        public FRM_PesquisarCadastro()
        {
            InitializeComponent();
        }
        public int Getcodigo { get; set; }
 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Codigo = (dataGridView1.CurrentRow.Cells[0].Value.ToString());
            p.Codigo = Codigo;
            String strConexao = "Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True";
            Conexao conexao = new Conexao(strConexao);
            SqlConnection conn = new SqlConnection(@"Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True");
            try
            {
                // cria o comando sql
                SqlCommand comando = new SqlCommand("P_PesquisarEmpresa", conn);
                // abre a conexao
                conn.Open();
                comando.Parameters.Clear();
                //prepara a query
                comando.Parameters.Add("@P_Codigo", Codigo);

                comando.CommandType = CommandType.StoredProcedure;

                // recebe os parametros da query 
                SqlDataReader reader;
                reader = comando.ExecuteReader();
                reader.Read();
                string _nomeFantasia = reader.GetString(1);
                string _razaosocial = reader.GetString(2);
                string _cnpj = reader.GetString(3);
                string _inscricaoestadual = reader.GetString(4);
                string _inscricaomunicipal = reader.GetString(5);
                string _endereco = reader.GetString(6);
                string _numero = reader.GetString(7);
                string _cnae = reader.GetString(8);
                string _email = reader.GetString(9);
                string _bairro = reader.GetString(10);
                string _cidade = reader.GetString(11);
                string _site = reader.GetString(12);
                string _estado = reader.GetString(13);
                string _cep = reader.GetString(14);
                string _nfe = reader.GetString(15);
                string _tipolucro = reader.GetString(16);
                p.NomeFantasia = _nomeFantasia;
                p.RazaoSocial = _razaosocial;
                p.CNPJ = _cnpj;
                p.InscricaoEstadual = _inscricaoestadual;
                p.InscricaoMunicipal = _inscricaomunicipal;
                p.Endereco = _endereco;
                p.Numero = _numero;
                p.Cnae = _cnae;
                p.Email = _email;
                p.Bairro = _bairro;
                p.Cidade = _cidade;
                p.Site = _site;
                p.Estado = _estado;
                p.Cep = _cep;
                p.Nfe = _nfe;
                p.TipoLucro = _tipolucro;
                conn.Close();



                this.Close();
                FRM_Cadastro novaform = new FRM_Cadastro();
                novaform.Show();
                // separando os campos de retorno da query


                // fecha a conexao 
                conn.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FRM_PesquisarCadastro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testeDataSet.Empresas' table. You can move, or remove it, as needed.
            this.empresasTableAdapter1.Fill(this.testeDataSet.Empresas);
            // TODO: This line of code loads data into the 'testeDataSet1.Empresas' table. You can move, or remove it, as needed.
            this.empresasTableAdapter.Fill(this.testeDataSet1.Empresas);
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Codigo = (dataGridView1.CurrentRow.Cells[0].Value.ToString());
            p.Codigo = Codigo;
            String strConexao = "Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True";
            Conexao conexao = new Conexao(strConexao);
            SqlConnection conn = new SqlConnection(@"Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True");
            try
            {
                    // cria o comando sql
                SqlCommand comando = new SqlCommand("P_PesquisarEmpresa", conn);    
                // abre a conexao
                    conn.Open();
                comando.Parameters.Clear();
                    //prepara a query
                    comando.Parameters.AddWithValue("@P_Codigo",Codigo);
                  
                    comando.CommandType = CommandType.StoredProcedure;

                // recebe os parametros da query 
                SqlDataReader reader;
                reader = comando.ExecuteReader();
                reader.Read();
                string _nomeFantasia = reader.GetString(1);
               string _razaosocial = reader.GetString(2);
                string _cnpj = reader.GetString(3);
                string _inscricaoestadual = reader.GetString(4);
                string _inscricaomunicipal = reader.GetString(5);
                string _endereco = reader.GetString(6);
                string _numero = reader.GetString(7);
                string _cnae  = reader.GetString(8);
                string _email = reader.GetString(9);
                string _bairro = reader.GetString(10);
                string _cidade = reader.GetString(11);
                string _site = reader.GetString(12);
                string _estado = reader.GetString(13);
                string _cep = reader.GetString(14);
                string _nfe = reader.GetString(15);
                string _tipolucro = reader.GetString(16);
                p.NomeFantasia = _nomeFantasia;
                p.RazaoSocial = _razaosocial;
                p.CNPJ = _cnpj;
                p.InscricaoEstadual = _inscricaoestadual;
                p.InscricaoMunicipal = _inscricaomunicipal;
                p.Endereco = _endereco;
                p.Numero = _numero;
                p.Cnae = _cnae;
                p.Email = _email;
                p.Bairro = _bairro;
                p.Cidade = _cidade;
                p.Site = _site;
                p.Estado = _estado;
                p.Cep = _cep;
                p.Nfe = _nfe;
                p.TipoLucro = _tipolucro;
                conn.Close();


                // teste 
                conn.Open();
                comando.Parameters.Clear();
                comando = new SqlCommand ("Pesquisar_Cfop", conn);
                comando.Parameters.AddWithValue("@P_Codigo", Codigo);

                comando.CommandType = CommandType.StoredProcedure;
                reader = comando.ExecuteReader();
                reader.Read();
                // int teste = Convert.ToInt32(reader.GetString(0));
                // p.ListaCfop = teste;
                while (reader.Read())
                {
                    int i=0;
                    p.ListaCfop = Convert.ToInt32(reader.GetString(i));
                    i++;
                }


               
                
                this.Close();
                FRM_Cadastro novaform = new FRM_Cadastro();
                novaform.Show();
                // separando os campos de retorno da query


                // fecha a conexao 
                conn.Close(); 
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

