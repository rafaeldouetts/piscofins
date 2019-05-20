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
    public partial class Principal : Form
    {
        public Principal()
        {
           
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
          
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void gerarRelatorioToolStripMenuItem_Click(object sender, EventArgs e)
        { // verifica se ja foi aberto 
            if (Application.OpenForms.OfType<FRM_GerarRelatorio>().Count() > 0)
            {
                MessageBox.Show("Gerar Relatorio já está aberto!");
            }
            else {
                // chama form gerar relatorio
                FRM_GerarRelatorio novaform = new FRM_GerarRelatorio();
                novaform.Show();
            }
          
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ao clicar em sair fecha a aplicacao
               this.Close();
        }

        private void cadastroLicenciadoToolStripMenuItem_Click(object sender, EventArgs e)
        { // verifica se algum form ja foi aberto
            if (Application.OpenForms.OfType<FRM_Cadastro>().Count() > 0)
            {
                MessageBox.Show("cadastro já está aberto!");
            }
            else {
                // chama cadatro de clientes 
                FRM_Cadastro novaform = new FRM_Cadastro();
                novaform.Show();
            }
            }

       
        private void importarSPEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // verifica se ja possui algum form aberto
            if (Application.OpenForms.OfType<FRM_ImportarSped>().Count() > 0)
            {
                MessageBox.Show("Importar SPED já está aberto!");
            }
            else {
                // chama form importar SPED
                FRM_ImportarSped novaform = new FRM_ImportarSped();
                novaform.Show();
            }
        }

        private void importaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
           DialogResult resultado = MessageBox.Show("Deseja encerrar o sitema ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            switch (resultado)
            {
                case DialogResult.Yes:
                    e.Cancel = false;
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    break;
            } 
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
