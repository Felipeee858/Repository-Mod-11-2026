namespace _11T_N06_Etapa3
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEventos = new DataGridView();
            gbEventos = new GroupBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnSair = new Button();
            btnParticipantes = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            gbEventos.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEventos
            // 
            dgvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventos.Location = new Point(21, 22);
            dgvEventos.Name = "dgvEventos";
            dgvEventos.Size = new Size(664, 380);
            dgvEventos.TabIndex = 0;
            dgvEventos.CellDoubleClick += dgvEventos_CellDoubleClick;
            // 
            // gbEventos
            // 
            gbEventos.Controls.Add(dgvEventos);
            gbEventos.Location = new Point(39, 37);
            gbEventos.Name = "gbEventos";
            gbEventos.Size = new Size(706, 420);
            gbEventos.TabIndex = 1;
            gbEventos.TabStop = false;
            gbEventos.Text = "Lista de Eventos";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(795, 59);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(96, 44);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar Evento";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(795, 285);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(96, 44);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "Remover Evento";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(835, 497);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(99, 27);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnParticipantes
            // 
            btnParticipantes.Location = new Point(795, 395);
            btnParticipantes.Name = "btnParticipantes";
            btnParticipantes.Size = new Size(96, 44);
            btnParticipantes.TabIndex = 7;
            btnParticipantes.Text = "Participantes";
            btnParticipantes.UseVisualStyleBackColor = true;
            btnParticipantes.Click += btnParticipantes_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(795, 165);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(96, 44);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Ver/Editar Evento";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 527);
            Controls.Add(btnEditar);
            Controls.Add(btnParticipantes);
            Controls.Add(btnSair);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(gbEventos);
            Name = "frmPrincipal";
            Text = "Evento Principal";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            gbEventos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEventos;
        private GroupBox gbEventos;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnSair;
        private Button btnParticipantes;
        private Button btnEditar;
    }
}
