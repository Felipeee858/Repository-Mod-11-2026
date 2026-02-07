using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11T_N06_Etapa3
{
    public partial class frmEstatistica : Form
    {
        //binding lists utilizadas para Source e adicionar os dados necessarios
        BindingList<Participante> resultado = new BindingList<Participante>();


        DateTime Data = DateTime.Today;

        public frmEstatistica()
        {
            InitializeComponent();



        }

        private void frmEstatistica_Load(object sender, EventArgs e)
        {
            dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvResultados.MultiSelect = false;

            dgvResultados.RowHeadersVisible = false;

            dgvResultados.ReadOnly = true;

            dgvResultados.AllowUserToAddRows = false;

            dgvResultados.AllowUserToDeleteRows = false;

            dgvResultados.AllowUserToResizeRows = false;

            dgvResultados.AllowUserToResizeColumns = false;


        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            resultado.Clear();
            dgvResultados.DataSource = resultado;

            BindingList<Eventos> eventos = new BindingList<Eventos>();

            if (File.Exists("eventos.json"))
            {
                using (FileStream fs = new FileStream("eventos.json", FileMode.Open))
                {
                    eventos = JsonSerializer.Deserialize<BindingList<Eventos>>(fs);
                }
            }


            foreach (Eventos evt in eventos)
            {
                foreach (Participante p in evt.Part)
                {
                    if (p.Idade >= 18)
                        resultado.Add(p);

                }
            }


        }

        private void btnHoje_Click(object sender, EventArgs e)
        {

            resultado.Clear();




            dgvResultados.DataSource = resultado;

            BindingList<Eventos> eventos = new BindingList<Eventos>();


            if (File.Exists("eventos.json"))
            {
                using (FileStream fs = new FileStream("eventos.json", FileMode.Open))
                {
                    eventos = JsonSerializer.Deserialize<BindingList<Eventos>>(fs);
                }
            }

            DateTime dataHoje = DateTime.Today;

            foreach (Eventos evt in eventos)
            {
                foreach (Participante p in evt.Part)
                {
                    if (p.Data_Adicionado == Data)
                        resultado.Add(p);

                }
            }

            using (FileStream fs = new FileStream("Participantes18.json", FileMode.Create))
            {
                JsonSerializer.Serialize(fs, resultado, new JsonSerializerOptions { WriteIndented = true });
            }


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
