using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // verificando login
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
