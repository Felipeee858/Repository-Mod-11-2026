using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.Json;

namespace _11T_N06_Etapa3
{
    
    public partial class frmPrincipal : Form
    {
        public static BindingList<Eventos> eventos = new BindingList<Eventos>();
         
        

        bool carregar = false;



        public frmPrincipal()
        {
            
            InitializeComponent();
            LerJSON form = new LerJSON();

            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                carregar = true;
                
            }
            if (result == DialogResult.Yes)
            {
                File.Delete("eventos.json");
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            dgvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvEventos.MultiSelect = false;

            dgvEventos.RowHeadersVisible = false;

            dgvEventos.ReadOnly = true;

            dgvEventos.AllowUserToAddRows = false;

            dgvEventos.AllowUserToDeleteRows = false;

            dgvEventos.AllowUserToResizeRows = false;

            dgvEventos.AllowUserToResizeColumns = false;

            dgvEventos.DataSource = eventos;

            if (carregar == true)
                CarregarJson();


        }
        private void CarregarJson()
        {
            
                if (!File.Exists("eventos.json"))
                {
                    return;
                }
                try
                {
                    using (FileStream fs = new FileStream("eventos.json", FileMode.Open))
                    {
                        eventos  = JsonSerializer.Deserialize<BindingList<Eventos>>(fs);
                        
                            dgvEventos.AutoGenerateColumns = true;
                            dgvEventos.DataSource = eventos;
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar ficheiro JSON: " + ex.Message);
                }
            
        }

        

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            
            Adicionar_Evento form = new Adicionar_Evento(null);

            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                Eventos novoEvento = form.Evt;
                eventos.Add(novoEvento);
                try
                {
                  
                    
                    
                    BindingList<Eventos> evt  = new BindingList<Eventos>();
                    //evt

                    //Se o ficheiro já existe, ler dados anteriores
                    if (File.Exists("eventos.json"))
                    {
                        using (FileStream fs = new FileStream("eventos.json", FileMode.Open))
                        {
                            evt = JsonSerializer.Deserialize<BindingList<Eventos>>(fs);
                            
                        }
                    }
                    evt.Add(novoEvento);


                    //Guardar lista atualizada
                    using (FileStream fs = new FileStream("eventos.json", FileMode.Create))
                    {
                        JsonSerializer.Serialize(fs, evt, new JsonSerializerOptions { WriteIndented = true });
                    }

                    MessageBox.Show("Novo evento adicionado com sucesso", "Eventos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);


                }
               
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvEventos.Rows.Count > 0)
            {
                Eventos dados = GetAtualDataRown();
                int i = eventos.IndexOf(dados);


                if (i < 0)
                {
                    MessageBox.Show("Evento não encontrado na lista de dados...", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; //sai da função
                }


                string msg = "Remover o Evento " + dados.Nome + "?";

                DialogResult result = MessageBox.Show(msg, "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    eventos.RemoveAt(i);
                    using (FileStream fs = new FileStream("eventos.json", FileMode.Create))
                    {
                        JsonSerializer.Serialize(fs, eventos, new JsonSerializerOptions { WriteIndented = true });
                    }
            }
            else
                MessageBox.Show("Não existem eventos na lista de dados...", "teste", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (dgvEventos.Rows.Count > 0 && dgvEventos.SelectedRows.Count == 0)
                dgvEventos.Rows[dgvEventos.Rows.Count - 1].Selected = true;
        }




        private Eventos GetAtualDataRown()
        {
            if (dgvEventos.SelectedRows.Count > 0)
                // Aceder aos dados associados à linha selecionada

                return (Eventos)dgvEventos.CurrentRow.DataBoundItem;
            else
                return null;

        }



        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            if (dgvEventos.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum evento na lista de dados...", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Eventos dados = (Eventos)dgvEventos.CurrentRow.DataBoundItem;

            if (dados != null)
            {

                frmParticipante frm = new frmParticipante((Eventos)dgvEventos.CurrentRow.DataBoundItem);
                frm.ShowDialog();

            }




        }




        private void dgvEventos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btnParticipantes.PerformClick();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEventos.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum evento na lista de dados...", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Eventos dados = GetAtualDataRown();
            if (dados != null)
            {

                frmEditarEvento frm = new frmEditarEvento(dados);
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    dgvEventos.Refresh();

                }
                using (FileStream fs = new FileStream("eventos.json", FileMode.Create))
                {
                    JsonSerializer.Serialize(fs, eventos, new JsonSerializerOptions { WriteIndented = true });
                }
            }
                

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLerJ_Click(object sender, EventArgs e)
        {

        }

        
        
    }
}
