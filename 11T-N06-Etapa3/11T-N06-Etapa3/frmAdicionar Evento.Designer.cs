namespace _11T_N06_Etapa3
{
    partial class Adicionar_Evento
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
            components = new System.ComponentModel.Container();
            txtNome = new TextBox();
            NUpDownIdadeM = new NumericUpDown();
            NUpDownLimite = new NumericUpDown();
            lbParticipantes = new Label();
            lbNome = new Label();
            dtpEvento = new DateTimePicker();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            lbData = new Label();
            lbIdade = new Label();
            errorProvider1 = new ErrorProvider(components);
            lbResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)NUpDownIdadeM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUpDownLimite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(161, 38);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(213, 23);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // NUpDownIdadeM
            // 
            NUpDownIdadeM.Location = new Point(161, 156);
            NUpDownIdadeM.Name = "NUpDownIdadeM";
            NUpDownIdadeM.Size = new Size(213, 23);
            NUpDownIdadeM.TabIndex = 8;
            // 
            // NUpDownLimite
            // 
            NUpDownLimite.Location = new Point(161, 215);
            NUpDownLimite.Name = "NUpDownLimite";
            NUpDownLimite.Size = new Size(213, 23);
            NUpDownLimite.TabIndex = 9;
            // 
            // lbParticipantes
            // 
            lbParticipantes.AutoSize = true;
            lbParticipantes.CausesValidation = false;
            lbParticipantes.Location = new Point(44, 217);
            lbParticipantes.Name = "lbParticipantes";
            lbParticipantes.Size = new Size(111, 15);
            lbParticipantes.TabIndex = 10;
            lbParticipantes.Text = "Limite Participantes";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.CausesValidation = false;
            lbNome.Location = new Point(44, 41);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 11;
            lbNome.Text = "Nome";
            // 
            // dtpEvento
            // 
            dtpEvento.Location = new Point(161, 90);
            dtpEvento.Name = "dtpEvento";
            dtpEvento.Size = new Size(213, 23);
            dtpEvento.TabIndex = 12;
            dtpEvento.ValueChanged += dtpEvento_ValueChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(436, 215);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 33);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(522, 215);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 33);
            btnConfirmar.TabIndex = 14;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Location = new Point(44, 90);
            lbData.Name = "lbData";
            lbData.Size = new Size(31, 15);
            lbData.TabIndex = 15;
            lbData.Text = "Data";
            // 
            // lbIdade
            // 
            lbIdade.AutoSize = true;
            lbIdade.Location = new Point(44, 158);
            lbIdade.Name = "lbIdade";
            lbIdade.Size = new Size(80, 15);
            lbIdade.TabIndex = 16;
            lbIdade.Text = "Idade Mínima";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lbResultado
            // 
            lbResultado.Location = new Point(436, 52);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(161, 147);
            lbResultado.TabIndex = 17;
            // 
            // Adicionar_Evento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 257);
            Controls.Add(lbResultado);
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
            Name = "Adicionar_Evento";
            Text = "frmAdicionar_Evento";
            Load += Adicionar_Evento_Load;
            ((System.ComponentModel.ISupportInitialize)NUpDownIdadeM).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUpDownLimite).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private Label label1;
        private TextBox txt;
        private Label label2;
        private NumericUpDown NUpDownIdadeM;
        private NumericUpDown NUpDownLimite;
        private Label lbParticipantes;
        private Label lbNome;
        private DateTimePicker dtpEvento;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Label lbData;
        private Label lbIdade;
        private ErrorProvider errorProvider1;
        private Label lbResultado;
    }
}