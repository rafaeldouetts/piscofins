using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ICMS_PIS_COFFINS.controler
{
    class Conexao
    {
        private String _StringConexao;
        private  SqlConnection _conexao; 

        

        public Conexao (String dadosConexao)
        {
            this._conexao = new SqlConnection();
            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao; 
        }
        public String StringConexao
        {
            get { return this._StringConexao; }
            set { this._StringConexao = value; }
        } 
        public SqlConnection ObjConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }

        }
        public void Conectar()
        {
            this._conexao.Open();
        }
        public void Desconectar()
        {
            this._conexao.Close();
        }
    }
}
