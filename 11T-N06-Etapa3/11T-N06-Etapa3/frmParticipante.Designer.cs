namespace _11T_N06_Etapa3
{
    partial class frmParticipante
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
            gbParticipante = new GroupBox();
            NUpDownParticipante = new NumericUpDown();
            lbLimite = new Label();
            dgvDados = new DataGridView();
            btnInscrever = new Button();
            btnRemover = new Button();
            btnVoltar = new Button();
            gbParticipante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUpDownParticipante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // gbParticipante
            // 
            gbParticipante.Controls.Add(NUpDownParticipante);
            gbParticipante.Controls.Add(lbLimite);
            gbParticipante.Controls.Add(dgvDados);
            gbParticipante.Controls.Add(btnInscrever);
            gbParticipante.Controls.Add(btnRemover);
            gbParticipante.Location = new Point(24, 33);
            gbParticipante.Name = "gbParticipante";
            gbParticipante.Size = new Size(757, 363);
            gbParticipante.TabIndex = 12;
            gbParticipante.TabStop = false;
            gbParticipante.Text = "Participante";
            gbParticipante.Enter += gbParticipante_Enter;
            // 
            // NUpDownParticipante
            // 
            NUpDownParticipante.Location = new Point(157, 329);
            NUpDownParticipante.Name = "NUpDownParticipante";
            NUpDownParticipante.ReadOnly = true;
            NUpDownParticipante.Size = new Size(65, 23);
            NUpDownParticipante.TabIndex = 8;
            // 
            // lbLimite
            // 
            lbLimite.AutoSize = true;
            lbLimite.Location = new Point(24, 331);
            lbLimite.Name = "lbLimite";
            lbLimite.Size = new Size(127, 15);
            lbLimite.TabIndex = 7;
            lbLimite.Text = "Limite de Participantes";
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(24, 58);
            dgvDados.Name = "dgvDados";
            dgvDados.Size = new Size(552, 249);
            dgvDados.TabIndex = 4;
            // 
            // btnInscrever
            // 
            btnInscrever.Location = new Point(609, 171);
            btnInscrever.Name = "btnInscrever";
            btnInscrever.Size = new Size(83, 48);
            btnInscrever.TabIndex = 6;
            btnInscrever.Text = "Inscrever Participante";
            btnInscrever.UseVisualStyleBackColor = true;
            btnInscrever.Click += btnInscrever_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(609, 225);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(83, 46);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover Inscrição";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(686, 373);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmParticipante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 406);
            Controls.Add(btnVoltar);
            Controls.Add(gbParticipante);
            Name = "frmParticipante";
            Text = "frmParticipante";
            Load += frmParticipante_Load;
            gbParticipante.ResumeLayout(false);
            gbParticipante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUpDownParticipante).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbParticipante;
        private DataGridView dgvDados;
        private Button btnInscrever;
        private Button btnRemover;
        private Button btnVoltar;
        private NumericUpDown NUpDownParticipante;
        private Label lbLimite;
    }
}