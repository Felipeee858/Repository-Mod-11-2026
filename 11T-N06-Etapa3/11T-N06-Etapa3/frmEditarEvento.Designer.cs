namespace _11T_N06_Etapa3
{
    partial class frmEditarEvento
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
            lbIdade = new Label();
            lbData = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            dtpEvento = new DateTimePicker();
            lbNome = new Label();
            lbParticipantes = new Label();
            NUpDownLimite = new NumericUpDown();
            NUpDownIdadeM = new NumericUpDown();
            txtNome = new TextBox();
            cbEditar = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)NUpDownLimite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUpDownIdadeM).BeginInit();
            SuspendLayout();
            // 
            // lbIdade
            // 
            lbIdade.AutoSize = true;
            lbIdade.Location = new Point(44, 160);
            lbIdade.Name = "lbIdade";
            lbIdade.Size = new Size(80, 15);
            lbIdade.TabIndex = 26;
            lbIdade.Text = "Idade Mínima";
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Location = new Point(44, 92);
            lbData.Name = "lbData";
            lbData.Size = new Size(31, 15);
            lbData.TabIndex = 25;
            lbData.Text = "Data";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(522, 217);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 33);
            btnConfirmar.TabIndex = 24;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(436, 217);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 33);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtpEvento
            // 
            dtpEvento.Location = new Point(161, 92);
            dtpEvento.Name = "dtpEvento";
            dtpEvento.Size = new Size(213, 23);
            dtpEvento.TabIndex = 22;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.CausesValidation = false;
            lbNome.Location = new Point(44, 43);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 21;
            lbNome.Text = "Nome";
            // 
            // lbParticipantes
            // 
            lbParticipantes.AutoSize = true;
            lbParticipantes.CausesValidation = false;
            lbParticipantes.Location = new Point(44, 219);
            lbParticipantes.Name = "lbParticipantes";
            lbParticipantes.Size = new Size(111, 15);
            lbParticipantes.TabIndex = 20;
            lbParticipantes.Text = "Limite Participantes";
            // 
            // NUpDownLimite
            // 
            NUpDownLimite.Location = new Point(161, 217);
            NUpDownLimite.Name = "NUpDownLimite";
            NUpDownLimite.Size = new Size(213, 23);
            NUpDownLimite.TabIndex = 19;
            // 
            // NUpDownIdadeM
            // 
            NUpDownIdadeM.Location = new Point(161, 158);
            NUpDownIdadeM.Name = "NUpDownIdadeM";
            NUpDownIdadeM.Size = new Size(213, 23);
            NUpDownIdadeM.TabIndex = 18;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(161, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(213, 23);
            txtNome.TabIndex = 17;
            // 
            // cbEditar
            // 
            cbEditar.AutoSize = true;
            cbEditar.Location = new Point(531, 39);
            cbEditar.Name = "cbEditar";
            cbEditar.Size = new Size(56, 19);
            cbEditar.TabIndex = 27;
            cbEditar.Text = "Editar";
            cbEditar.UseVisualStyleBackColor = true;
            cbEditar.CheckedChanged += cbEditar_CheckedChanged;
            // 
            // frmEditarEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 287);
            Controls.Add(cbEditar);
            Controls.Add(lbIdade);
            Controls.Add(lbData);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(dtpEvento);
            Controls.Add(lbNome);
            Controls.Add(lbParticipantes);
            Controls.Add(NUpDownLimite);
            Controls.Add(NUpDownIdadeM);
            Controls.Add(txtNome);
            Name = "frmEditarEvento";
            Text = "frmEditarEvento";
            Load += frmEditarEvento_Load;
            ((System.ComponentModel.ISupportInitialize)NUpDownLimite).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUpDownIdadeM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbIdade;
        private Label lbData;
        private Button btnConfirmar;
        private Button btnCancelar;
        private DateTimePicker dtpEvento;
        private Label lbNome;
        private Label lbParticipantes;
        private NumericUpDown NUpDownLimite;
        private NumericUpDown NUpDownIdadeM;
        private TextBox txtNome;
        private CheckBox cbEditar;
    }
}