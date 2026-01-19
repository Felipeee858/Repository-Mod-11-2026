using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _11T_N06_Etapa3
{
    public partial class frmEditarEvento : Form
    {
        public Eventos Evt { get; private set; }

        DateTime Data = DateTime.Now.Date;
        public frmEditarEvento(Eventos evt)
        {
            InitializeComponent();
            Evt = evt;

        }

        private void frmEditarEvento_Load(object sender, EventArgs e)
        {
            txtNome.ReadOnly = true;
            dtpEvento.Enabled = false;
            NUpDownIdadeM.Enabled = false;
            NUpDownLimite.Enabled = false;

            txtNome.Text = Evt.Nome;
            dtpEvento.Value = Evt.Data;
            NUpDownIdadeM.Value = Evt.IdadeMin;
            NUpDownLimite.Value = Evt.CapacidadeMax;


        }


        private void cbEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEditar.Checked)
            {
                txtNome.ReadOnly = false;
                dtpEvento.Enabled = true;
                NUpDownIdadeM.Enabled = true;
                NUpDownLimite.Enabled = true;
            }
            else
            {
                txtNome.ReadOnly = true;
                dtpEvento.Enabled = false;
                NUpDownIdadeM.Enabled = false;
                NUpDownLimite.Enabled = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtNome.Text == null || txtNome.Text == " ") //breakpoint  e F11
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

                    Evt.Nome = txtNome.Text;
                    Evt.Data = dtpEvento.Value;
                    Evt.IdadeMin = NUpDownIdadeM.Value;
                    Evt.CapacidadeMax = NUpDownLimite.Value;

                    btnConfirmar.DialogResult = DialogResult.OK;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }


            Evt.Nome = txtNome.Text;
            Evt.Data = dtpEvento.Value;
            Evt.IdadeMin = NUpDownIdadeM.Value;
            Evt.CapacidadeMax = NUpDownLimite.Value;
            btnConfirmar.DialogResult = DialogResult.OK;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
