using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ICMS_PIS_COFFINS.controler;
using System.Data.SqlClient;

namespace ICMS_PIS_COFFINS
{
    public partial class FRM_ImportarSped : Form
    {
        public FRM_ImportarSped()
        {
            InitializeComponent();
        }

        private void LBL_Aviso_Click(object sender, EventArgs e)
        {

        }

        private void ImportarSped_Load(object sender, EventArgs e)
        {

        }

        private void BTN_SpedFiscal_Click(object sender, EventArgs e)
        { // pegando um arquivo so 

            switch (Rad_Seleciona1.Checked)
            {
                // caso esteja selecionado para importar um arquivo 
                case true:


                    OpenFileDialog SelecionarSPED = new OpenFileDialog();
                    SelecionarSPED.DefaultExt = "txt";
                    SelecionarSPED.Filter = "arquivo de texto (*.txt;)|*.txt*.*";
                    SelecionarSPED.ShowDialog();
                    // recebe o diretorio e o nome do arquivo selecionado
                    String nomearquivo = SelecionarSPED.FileName;
                    string NomeArquivo = SelecionarSPED.SafeFileName;
                    Stream entrada = File.Open(nomearquivo, FileMode.Open); 

                    StreamReader leitor = new StreamReader(entrada);
                    string linha = leitor.ReadLine();
                    string p_query_CNPJ = "";
                    while (linha != null)
                    {
                        string Registro = "C190";
                        string p_query_registro = "";
                        string p_query_CFOP = "";
                        string p_query_V_ICMS = "";
                        string p_query = "'";
                        string liquota = "";
                        string operacao = "";
                        string situacao = "";
                        //string p_query_CNPJ = "";
                        string inicio = "0000";
                        int tamanhoString = 0;
                        String[] CFOP = new String[5] { "5102", "6102", "1102", "1202", "2102" };
                        int contador = 0;
                        int y = 0;
                        for (int x = 0; x < CFOP.Length; x++)
                        {

                            // procura a linha que comece com o registro e o CFOP cadastrado 
                           
                                if (linha.Substring(1, 4) == Registro && linha.Substring(10, 4) == CFOP[x].ToString())
                                {

                                    for (int i = 0; i < linha.Length - 1; i++)
                                    {
                                        // enquanto a linha nao terminar passa pro proximo caracter
                                        for (y = 0; y < linha.Length; y++)
                                        {
                                            //contador de barras 
                                            if (linha[y].ToString() == "|")
                                            {
                                                contador += 1;
                                            }
                                            // na primeira passada coloca as aspas duplas 
                                            if (contador == 1 && y == 0)
                                            {

                                                p_query += "";
                                                y += 1;

                                            }
                                            // pegar a situacao 
                                            if (contador == 2)
                                            {
                                            if (linha[y].ToString() == "|")
                                                {
                                                    //p_query_CFOP += "', '";
                                                }
                                                else {
                                                    // se nao pega o caracter e adiciona na query
                                                    situacao += linha.Substring(y, 1);
                                                }
                                            }
                                            if (contador == 3)
                                            {
                                                if (linha[y].ToString() == "|")
                                                {
                                                    //p_query_CFOP += "', '";
                                                }
                                                else {
                                                    // se nao pega o caracter e adiciona na query
                                                    p_query_CFOP += linha.Substring(y, 1);
                                                }
                                            }
                                            // pegar a liquota 
                                            if (contador == 4)
                                            {
                                                if (linha[y].ToString() == "|")
                                                {

                                                }
                                                else {
                                                    liquota += linha.Substring(y, 1);
                                                }
                                            }

                                            tamanhoString++;

                                            if (contador == 6)
                                            {
                                                p_query += "'";
                                                contador++;
                                            }
                                            // quando encontrar o campo do registro do CFOP e do ICMS separa o valor 

                                            if (contador == 1)
                                            {
                                                if (linha[y].ToString() == "|")
                                                {
                                                    //  p_query_registro += "', '";
                                                }
                                                else {
                                                    // se nao pega o caracter e adiciona na query
                                                    p_query_registro += linha.Substring(y, 1);
                                                }
                                            }

                                            if (contador == 7)
                                            {
                                                if (linha[y].ToString() == "|")
                                                {
                                                    //  p_query_V_ICMS += "', '";
                                                }
                                                else {
                                                    // se nao pega o caracter e adiciona na query
                                                    p_query_V_ICMS += linha.Substring(y, 1);

                                                }
                                                /* if (contador == 7 && situacao == "020" || situacao == "040" || situacao == "000") {
                                                 }
                                                     }*/



                                            }


                                            tamanhoString += 1;

                                        }

                                    }


                                    // pegar registro 
                                    if (p_query_CFOP == "5102" || p_query_CFOP == "6102")
                                    {
                                        operacao = "-";
                                    }
                                    else
                                    {
                                        operacao = "+";
                                    }


                                }
                            
                        }



                        /*pegar cnpj 
                         
                            if (linha.Substring(1, 4) == inicio)
                            {
                                for (int tes = 0; tes < linha.Length; tes++)
                                {
                                    if (linha[tes].ToString() == "|")
                                    {
                                        contador += 1;
                                    }

                                    if (contador == 7)
                                    {
                                        if (linha[tes].ToString() == "|")
                                        {

                                        }
                                        else {

                                            p_query_CNPJ += linha.Substring(tes, 1);
                                        }
                                    }
                                }
                            
                            }*/






                            String strConexao = "Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True";
                            Conexao conexao = new Conexao(strConexao);
                            SqlConnection conn = new SqlConnection(@"Data Source=RAFAEL-PC;Initial Catalog=teste;Integrated Security=True"); 
                            try
                            {
                                if (p_query_CFOP != "" && p_query_V_ICMS != "" && liquota != "0")
                                {
                                    // pega a data do arquivo 
                                    string p_query_data = NomeArquivo.Substring(28, 8);

                                    //prepara o valor do icms pro banco 
                                    decimal valor = Convert.ToDecimal(p_query_V_ICMS);
                                    // cria o comando sql
                                    SqlCommand comando = new SqlCommand("P_InsertSped", conn);
                                    // abre a conexao
                                    conn.Open();
                                    //prepara a query
                                    comando.Parameters.AddWithValue("@Registro",p_query_registro);
                                    comando.Parameters.AddWithValue("@Cfop", p_query_CFOP);
                                   comando.Parameters.AddWithValue("@CNPJ", p_query_CNPJ);
                                    comando.Parameters.AddWithValue("@operacao", operacao);
                                    comando.Parameters.AddWithValue("@V_ICMS", valor);
                                    comando.Parameters.AddWithValue("@Data", p_query_data);
                                    comando.CommandType = CommandType.StoredProcedure;
                                    // executa a query
                                    comando.ExecuteNonQuery();
                                    // fecha a conexao 
                                    conn.Close();
                                    linha = leitor.ReadLine();

                                }



                            }
                            catch (Exception erro)
                            {
                                MessageBox.Show(erro.Message);
                            }
                            linha = leitor.ReadLine();
                        
                        
                        }
                        leitor.Close();
                        entrada.Close();
                    
                        
                    
                    break;
                // caso esteja selecionado para importar uma basta
                case false :
                    
                    FolderBrowserDialog SelecionarPastaSPED = new FolderBrowserDialog();
                    string sCaminhos;
                   
                    
                    // seleciona a pasta 
                    SelecionarPastaSPED.ShowDialog();
                    // salva o diretorio da pasta 
                    sCaminhos = SelecionarPastaSPED.SelectedPath;
                    
                    
                    
                    
                        //pega a pasta
                        
                        DirectoryInfo pasta = new DirectoryInfo(sCaminhos);

                      
              
                        //iCountArqTxt = MetodosDeExtensao.ContagemTipoArquivo(sCaminhos, ".TXT");
                        
                     // prepara o endereco do diretorio 
                        String diretorio = "" + pasta +"";
                        
                        // pega os arquivos 
                        string[] arquivos = Directory.GetFiles(diretorio);

                        for (int percorrer = 0; percorrer < arquivos.Length; percorrer++)
                        {

                            Stream arquivo = File.Open(arquivos[percorrer], FileMode.Open);
                            StreamReader ponteiro = new StreamReader(arquivo);
                            string NomeArquivoPasta = arquivos[percorrer];
                            string Proxima = ponteiro.ReadLine();
                            while (Proxima != null) {

                                string Registro = "C190";
                                string p_query = "'";
                               // string p_query_CNPJ = "";
                                string inicio = "0000";
                                int tamanhoString = 0;
                                String[] CFOP = new String[5] { "5102", "6102", "1102", "1202", "2102" };
                                int contador = 0;
                                int y = 0;
                                for (int x = 0; x < CFOP.Length; x++)
                                {

                                    // procura a linha que comece com o registro e o CFOP cadastrado 
                                    if (Proxima.Substring(1, 4) == Registro && Proxima.Substring(10, 4) == CFOP[x].ToString())
                                    {

                                        for (int i = 0; i < Proxima.Length; i++)
                                        {
                                            // enquanto a linha nao terminar passa pro proximo caracter
                                            for (y = 0; y < Proxima.Length; y++)
                                            {
                                                //contador de barras 
                                                if (Proxima[y].ToString() == "|")
                                                {
                                                    contador += 1;
                                                }

                                                tamanhoString++;
                                                // na primeira passada coloca as aspas duplas 
                                                if (contador == 1 && y == 0)
                                                {

                                                    p_query += "";
                                                    y += 1;

                                                }
                                                if (contador == 6)
                                                {
                                                    p_query += "'";
                                                    contador++;
                                                }
                                                // quando encontrar o campo do registro do CFOP e do ICMS separa o valor 
                                                if (contador == 1 || contador == 3 || contador == 5)
                                                {
                                                    // se o caracter da linha for =  | troca por ,
                                                    if (Proxima[y].ToString() == "|")
                                                    {
                                                        p_query += "', '";
                                                    }
                                                    else {
                                                        // se nao pega o caracter e adiciona na query
                                                        p_query += Proxima.Substring(y, 1);
                                                    }

                                                }


                                            }


                                            tamanhoString += 1;

                                        }

                                    }
                                    // pegar cnpj 
                                    if (Proxima.Substring(1, 4) == inicio)
                                    {
                                        for (int tes = 0; tes < Proxima.Length; tes++)
                                        {
                                            if (Proxima[tes].ToString() == "|")
                                            {
                                                contador += 1;
                                            }

                                            if (contador == 7)
                                            {
                                                if (Proxima[tes].ToString() == "|")
                                                {

                                                }
                                                else {
                                                  //  p_query_CNPJ += Proxima.Substring(tes, 1);
                                                }
                                                // pega a data do arquivo 
                                                string DataArquivo = NomeArquivoPasta.Substring(28, 8);
                                            }
                                      
                                        }

                                    }

                                    

                                }
                                linha = ponteiro.ReadLine();

                            }
                            ponteiro.Close();
                            arquivo.Close();
                        

                        }
                    break;
            }
               
                    
                    }

        internal static FRM_ImportarSped create()
        {
            throw new NotImplementedException();
        }
    }
        }
