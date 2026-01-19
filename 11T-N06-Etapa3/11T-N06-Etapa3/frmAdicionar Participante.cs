using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11T_N06_Etapa3
{
    public partial class frmAdicionar_Participante : Form
    {
        public Participante part { get; private set; } 
        public Eventos Evt { get; private set; }

        int idade;

       
        public frmAdicionar_Participante(Eventos evento)
        {
            InitializeComponent();
            
            Evt = evento;

            int idade = (int)Evt.IdadeMin;
            
            btnCancelar.DialogResult = DialogResult.Cancel;
            
            

        }

        private void lbIdade_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtNome.Text == null || txtNome.Text == " ")
            {
                MessageBox.Show("Erro Nome inválido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }

            
            {
}
            if (NUpDownIdade.Value < Evt.IdadeMin)
            {
                
                DialogResult result = MessageBox.Show("O valor da idade do Participante é inválido caso prima (Não) o valor será automaticante definido como " + Evt.IdadeMin, "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    return;
                }
                else if (result == DialogResult.No)
                {
                    NUpDownIdade.Value= Evt.IdadeMin;
                    part = new Participante(txtNome.Text, NUpDownIdade.Value, txtEmail.Text);
                    btnConfirmar.DialogResult = DialogResult.OK;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
                part = new Participante(txtNome.Text, NUpDownIdade.Value, txtEmail.Text);
                btnConfirmar.DialogResult = DialogResult.OK;
        }

        private void frmAdicionar_Participante_Load(object sender, EventArgs e)
        {

        }
    }
}
