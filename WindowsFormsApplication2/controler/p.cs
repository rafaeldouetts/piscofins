using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.controler
{
    class p
    {
        static string  _codigo = "";
        static string _nomefantasia = "";
        static string _razaosocial = "";
            static string  _cnpj = "";
            static string _inscricaoestadual = "";
            static string _inscricaomunicipal = "";
        static string _endereco = "";
        static string _numero = "";
        static string _cnae = "";
        static string _email = "";
        static string _bairro = "";
        static string _cidade = "";
        static string _site = "";
        static string _estado = "";
        static string _cep = "";
        static string _nfe = "";
        static string _tipolucro = "";
        static int  _cfop = 0;
        static int i, x = 0; 




        public static string Codigo {
            get { return _codigo; }
            set { _codigo = value;}
            }
    
    public static string NomeFantasia
    {
        get { return _nomefantasia; }
        set { _nomefantasia = value; }
    }
    public static string RazaoSocial
    {
        get { return _razaosocial; }
        set { _razaosocial = value; }
    }
    public static string CNPJ
    {
        get { return _cnpj; }
        set { _cnpj = value; }
    }
    public static string InscricaoEstadual
    {
        get { return _inscricaoestadual; }
        set { _inscricaoestadual = value; }
    }
    public static string InscricaoMunicipal
    {
        get { return _inscricaomunicipal; }
        set { _inscricaomunicipal = value; }
    }
    public static string Endereco
    {
        get { return _endereco; }
        set { _endereco = value; }
    }
    public static string Numero
    {
        get { return _numero; }
        set { _numero = value; }
    }
    public static string Cnae
    {
        get { return _cnae; }
        set { _cnae = value; }
    }
    public static string Email
        {
            get { return _email; }
            set { _email = value; }
        }
            public static string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        } 
            public static string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        public static string Site
        {
            get { return _site; }
            set { _site = value; }
        }
          public static string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
          public static string Cep
    {
        get { return _cep; }
        set { _cep = value; }

    }
        public static string Nfe
        {
            get { return _nfe; }
            set { _nfe = value; }

        }
        
        public static string TipoLucro
        {
            get { return _tipolucro; }
            set { _tipolucro = value; }

        }
        public static int contador
        {
            get { return i; }
            set { i = value; }
        }
        public static int ListaCfop
        {

            get { return _cfop; } 
            set { _cfop = value; }
                    
                    }
        }



    }

