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

namespace WindowsFormsApplication2.view
{
    public partial class FRM_PesquisarCadastro : Form
    {
        public FRM_PesquisarCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
         
;            if (RBN_Codigo.Checked == true)
            {
               string  P_Campo = "Codigo";
            }
            else
            {
              string  P_Campo = "Nome_Fantasia";
            }
            String strConexao = "Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True";
            Conexao conexao = new Conexao(strConexao);
            SqlConnection conn = new SqlConnection(@"Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True");
            string sql = "insert into Notas_Fiscais_Sped (Registro,Cfop,CNPJ,operacao,Data,V_ICMS) values (@Registro,@Cfop,@CNPJ,@operacao,@data,@V_ICMS)";
            try
            {
                  
                    // cria o comando sql
                    SqlCommand comando = new SqlCommand("P_PesquisarEmpresas", conn);
                    // abre a conexao
                    conn.Open();
                //prepara a query
                    comando.Parameters.AddWithValue("@P_Campo", P_Campo);
                    comando.Parameters.AddWithValue("@P_Informacao", P_Informacao);
                    comando.CommandType = CommandType.StoredProcedure;
                    // executa a query
                    comando.ExecuteNonQuery();
                    // fecha a conexao 
                    conn.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }*/
            
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
