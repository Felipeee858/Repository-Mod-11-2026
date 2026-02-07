using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11T_N06_Etapa3
{
    public partial class Adicionar_Evento : Form
    {


        public Eventos Evt { get; private set; }
        
        DateTime Data = DateTime.Now.Date;
        private DialogResult result = DialogResult.Yes;
        
        public Adicionar_Evento(Eventos _evento)
        {
            InitializeComponent();
            Evt = _evento;


            dtpEvento.Value = Data;
            btnCancelar.DialogResult = DialogResult.Cancel;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Adicionar_Evento_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)

        {
            

            try
            {
                LerValores();

            }
            catch (Exception ex)
            {
                lbResultado.Text = "Erro inesperado: " + ex.Message;

            }

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                return;
            }

            if (dtpEvento.Value < Data)
            {
                return;
            }

                if (NUpDownIdadeM.Value == 0 || NUpDownLimite.Value == 0)
            {
                if (NUpDownIdadeM.Value == 0 && NUpDownLimite.Value == 0)
                {
                    result = MessageBox.Show("O valor da Idade Mínima e do Limite Participantes é inválido." +
                    "\n\nCaso prima (Sim) os valores serão automaticante definidos como 16", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else if (NUpDownIdadeM.Value == 0)
                {
                    result = MessageBox.Show("O valor da Idade Mínima é inválido." +
                    "\n\nCaso prima (Sim) os valor será automaticante definido como 16", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else if (NUpDownLimite.Value == 0)
                {
                    result = MessageBox.Show("O valor do Limite de Participantes é inválido." +
                    "\n\nCaso prima (Sim) os valor será automaticante definido como 16", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }

                if (result == DialogResult.No)
                {
                    return;
                }
                
            }
            if (result == DialogResult.Yes)
            {
                Evt = new Eventos(txtNome.Text, dtpEvento.Value, NUpDownLimite.Value, NUpDownIdadeM.Value);
                btnConfirmar.DialogResult = DialogResult.OK;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }



        }
        private void LerValores()
        {
            
            errorProvider1.Clear();
           
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                errorProvider1.SetError(txtNome, "Campo obrigatório.");
                throw new Exception("O campo Nome é obrigatório.");
                
                
            }

            if (dtpEvento.Value < Data)
            {
                errorProvider1.SetError(dtpEvento, "Data Inválida.");
                throw new Exception("Erro Data inválida terá que ser uma data igual ou superior ao dia de hoje.");
                
            }

            if (NUpDownIdadeM.Value == 0)
            {
                errorProvider1.SetError(NUpDownIdadeM, "Idade Inválida.");
                throw new Exception("Idade Inválida.");
                
            }

            if (NUpDownLimite.Value == 0)
            {
                errorProvider1.SetError(NUpDownLimite, "Limite Não Preenchido.");
                throw new Exception("Limite Inválido.");
                
            }
            
            
        }


        private void dtpEvento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
