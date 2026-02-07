using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _11T_N06_Etapa3
{
    public partial class frmAdicionar_Participante : Form
    {
        public Participante part { get; private set; } 
        public Eventos Evt { get; private set; }
        DateTime Data = DateTime.Today;

        int idade;
        bool valido;

       
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


            if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                
                return;
            }
                
            if (NUpDownIdade.Value < Evt.IdadeMin)
            {
                
                DialogResult result = MessageBox.Show("O valor da idade do Participante é inválido." + "\n\n Caso prima (Sim) o valor será automaticante definido como " + Evt.IdadeMin, "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }
                else if (result == DialogResult.Yes)
                {
                    NUpDownIdade.Value= Evt.IdadeMin;
                    part = new Participante(txtNome.Text, NUpDownIdade.Value, txtEmail.Text , Data);
                    btnConfirmar.DialogResult = DialogResult.OK;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
            part = new Participante(txtNome.Text, NUpDownIdade.Value, txtEmail.Text, Data);
            btnConfirmar.DialogResult = DialogResult.OK;
            this.DialogResult = DialogResult.OK;
            this.Close();




        }

        private void frmAdicionar_Participante_Load(object sender, EventArgs e)
        {

        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
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


            if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                errorProvider1.SetError(txtEmail, "Email Inválido.");
                throw new Exception("O campo Email é Inválido.");
            }

            if (NUpDownIdade.Value < Evt.IdadeMin)
            {
                errorProvider1.SetError(NUpDownIdade, "Idade Inválida.");
                throw new Exception("Erro Idade inválida terá que ser uma Idade igual ou superior ao limite do evento.");
            }







        }
    }
}
