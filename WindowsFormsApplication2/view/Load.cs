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

namespace ICMS_PIS_COFFINS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ao apertar enter acionar o BTN_entrar
            this.AcceptButton = BTN_Entrar;

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            String strConexao = "Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True";
        Conexao conexao = new Conexao(strConexao);
        SqlConnection conn = new SqlConnection(@"Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True");
            try
            {
                    // cria o comando sql
                SqlCommand comando = new SqlCommand("P_PesquisarUsuario", conn);
        // abre a conexao
        conn.Open();
                comando.Parameters.Clear();
                    //prepara a query
                    comando.Parameters.AddWithValue("@P_Nome",TXT_Usuario.Text);
                comando.Parameters.AddWithValue("@P_Senha", TXT_Senha.Text);
                    comando.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader;
                reader= comando.ExecuteReader();
                reader.Read();

                try
                {
                    string nome = reader.GetString(0);



                    if (nome != null) {

                        int i = 0;
                        PRG_Login.Minimum = 0;
                        PRG_Login.Maximum = 200;
                        for (i = 0; i < 200; i++)
                        {
                            PRG_Login.Value = i;
                            System.Threading.Thread.Sleep(5);

                        }
                        Principal novaform = new Principal();
                        novaform.Show();
                        this.Hide();
                    }
                }
                catch (Exception erro )
                {
                    MessageBox.Show(erro.Message);
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
            
            
            
            /* verificando login
        { if (TXT_Usuario.Text == "admin" && TXT_Senha.Text == "satelite")
            {
                // controlando progress bar 
                int i = 0;
                PRG_Login.Minimum = 0;
                PRG_Login.Maximum = 200;
                for (i = 0; i < 200; i++)
                {
                    PRG_Login.Value = i;
                    System.Threading.Thread.Sleep(5);

                }
                Principal novaform = new Principal();
                novaform.Show();
                this.Hide();
            }
            else
            {
                // se a senha esta incorreta apresenta mensagem de login invalido 
                MessageBox.Show("Usuario ou senha invalido");
            }
            */
            
           
           

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // pressionando sair ele fecha a aplicacao 
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
