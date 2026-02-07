namespace _11T_N06_Etapa3
{
    partial class frmEstatistica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbEventos = new GroupBox();
            dgvResultados = new DataGridView();
            btnPM = new Button();
            btnHoje = new Button();
            btnVoltar = new Button();
            gbEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // gbEventos
            // 
            gbEventos.Controls.Add(dgvResultados);
            gbEventos.Location = new Point(26, 25);
            gbEventos.Name = "gbEventos";
            gbEventos.Size = new Size(570, 400);
            gbEventos.TabIndex = 2;
            gbEventos.TabStop = false;
            gbEventos.Text = "Lista";
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(23, 22);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(520, 360);
            dgvResultados.TabIndex = 0;
            // 
            // btnPM
            // 
            btnPM.Location = new Point(63, 443);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(112, 44);
            btnPM.TabIndex = 3;
            btnPM.Text = "Participantes Maiores de 18";
            btnPM.UseVisualStyleBackColor = true;
            btnPM.Click += btnPM_Click;
            // 
            // btnHoje
            // 
            btnHoje.Location = new Point(446, 443);
            btnHoje.Name = "btnHoje";
            btnHoje.Size = new Size(112, 44);
            btnHoje.TabIndex = 4;
            btnHoje.Text = "Participantes Adicionados Hoje";
            btnHoje.UseVisualStyleBackColor = true;
            btnHoje.Click += btnHoje_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(578, 498);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 8;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmEstatistica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 533);
            Controls.Add(btnVoltar);
            Controls.Add(btnHoje);
            Controls.Add(btnPM);
            Controls.Add(gbEventos);
            Name = "frmEstatistica";
            Text = "frmEstatistica";
            Load += frmEstatistica_Load;
            gbEventos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbEventos;
        private Button btnPM;
        private DataGridView dgvResultados;
        private Button btnHoje;
        private Button btnVoltar;
    }
}