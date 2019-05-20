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
    public partial class FRM_GerarRelatorio : Form
    {
        public FRM_GerarRelatorio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_GerarRelatorio_Load(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // pegando valor do Combo box e deixando campos visiveis ou nao 
            switch (CHK_Mes.Checked)
            {
                case (true):
                    TXT_Final.Show();
                    LBL_Ate.Show();
                    break;
                case (false):
                    TXT_Final.Hide();
                    LBL_Ate.Hide();
                    break;
            }
            
            /*  if (CHK_Mes.Checked = true)
            {
                TXT_Final.Show();
                LBL_Ate.Show();
            }
            else {
 }
 */
        }

       }
    }

