using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11T_N06_Etapa3
{
    public partial class LerJSON : Form
    {
        public LerJSON()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnsim_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; 
            this.Close();
        }

        private void btnnao_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Certeza que deseja apagar o ficheiro JSON?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            if (result == DialogResult.Yes)
            {
                this.DialogResult= DialogResult.Yes;
                
            }
            this.Close();
        }
    }
}
