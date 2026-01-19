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
    public partial class Adicionar_Evento : Form
    {


        public Eventos Evt { get; private set; }
        
        DateTime Data = DateTime.Now.Date;

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
            
            if (txtNome.Text == "" || txtNome.Text == null || txtNome.Text==" ") //breakpoint  e F11
            {
                MessageBox.Show("Erro Nome inválido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }
            if (dtpEvento.Value < Data)
            {
                MessageBox.Show("Erro Data inválida terá que ser uma data igual ou superior ao dia de hoje", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }
            if (NUpDownIdadeM.Value == 0 || NUpDownLimite.Value == 0)
            {
                DialogResult result = MessageBox.Show("O valor da Idade Mínima ou do Limite Participantes é inválido caso prima (Não) o valor será automaticante definido como 16", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
                if (result == DialogResult.Yes)
                {
                    return;
                }
                else if (result == DialogResult.No)
                {
                    Evt = new Eventos(txtNome.Text, dtpEvento.Value, NUpDownLimite.Value, NUpDownIdadeM.Value);
                    btnConfirmar.DialogResult = DialogResult.OK;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                
            }


             Evt = new Eventos(txtNome.Text, dtpEvento.Value, NUpDownLimite.Value, NUpDownIdadeM.Value);
             btnConfirmar.DialogResult = DialogResult.OK;

        }


        private void dtpEvento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
