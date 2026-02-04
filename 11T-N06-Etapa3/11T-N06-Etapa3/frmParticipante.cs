using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11T_N06_Etapa3
{
    public partial class frmParticipante : Form
    {
        private Eventos Evt;


        public frmParticipante(Eventos _evento)
        {
            InitializeComponent();
            Evt = _evento;

        }

        private void gbParticipante_Enter(object sender, EventArgs e)
        {

        }

        private void frmParticipante_Load(object sender, EventArgs e)
        {
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            NUpDownParticipante.Enabled = false;

            NUpDownParticipante.Value = Evt.CapacidadeMax;

            dgvDados.MultiSelect = false;

            dgvDados.RowHeadersVisible = false;

            dgvDados.ReadOnly = true;

            dgvDados.AllowUserToAddRows = false;

            dgvDados.AllowUserToDeleteRows = false;

            dgvDados.AllowUserToResizeRows = false;

            dgvDados.AllowUserToResizeColumns = false;

            dgvDados.DataSource = Evt.Part;
        }

        private void btnInscrever_Click(object sender, EventArgs e)
        {
            if (Evt.Part.Count >= Evt.capacidadeMax)
            {
                MessageBox.Show("Erro já antigiu a capacidade Máxima", "Participante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }





            frmAdicionar_Participante form = new frmAdicionar_Participante(Evt);


            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                
                Evt.Part.Add(form.part);


                BindingList<Eventos> evt = new BindingList<Eventos>();

                using (FileStream fs = new FileStream("eventos.json", FileMode.Open))
                {
                    evt = JsonSerializer.Deserialize<BindingList<Eventos>>(fs);

                }
                
                
                using (FileStream fs = new FileStream("eventos.json", FileMode.Create))
                {
                    JsonSerializer.Serialize(fs, evt,
                        new JsonSerializerOptions { WriteIndented = true });
                }



            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvDados.Rows.Count > 0)
            {
                Participante dados = GetAtualDataRown();
                int i = Evt.Part.IndexOf(dados);


                if (i < 0)
                {
                    MessageBox.Show("Participante não encontrado na lista de dados...", "teste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; //sai da função
                }


                string msg = "Remover o " + dados.Nome + "?";

                DialogResult result = MessageBox.Show(msg, "teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    Evt.Part.RemoveAt(i);
            }
            else
                MessageBox.Show("Não existem Participantes na lista de dados...", "teste", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (dgvDados.Rows.Count > 0 && dgvDados.SelectedRows.Count == 0)
                dgvDados.Rows[dgvDados.Rows.Count - 1].Selected = true;
        }
        private Participante GetAtualDataRown()
        {
            if (dgvDados.SelectedRows.Count > 0)
                // Aceder aos dados associados à linha selecionada
                //e converter esses dados para Empregado
                return (Participante)dgvDados.CurrentRow.DataBoundItem;
            else
                return null;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    };
}
