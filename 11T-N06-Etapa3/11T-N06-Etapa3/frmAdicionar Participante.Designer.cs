namespace _11T_N06_Etapa3
{
    partial class frmAdicionar_Participante
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
            btnConfirmar = new Button();
            btnCancelar = new Button();
            lbNome = new Label();
            txtNome = new TextBox();
            lbEmail = new Label();
            txtEmail = new TextBox();
            lbIdade = new Label();
            NUpDownIdade = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NUpDownIdade).BeginInit();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(522, 226);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 33);
            btnConfirmar.TabIndex = 24;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(436, 226);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 33);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.CausesValidation = false;
            lbNome.Location = new Point(44, 52);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 21;
            lbNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(161, 49);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(213, 23);
            txtNome.TabIndex = 17;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(44, 172);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 27;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(161, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 23);
            txtEmail.TabIndex = 28;
            // 
            // lbIdade
            // 
            lbIdade.AutoSize = true;
            lbIdade.CausesValidation = false;
            lbIdade.Location = new Point(44, 109);
            lbIdade.Name = "lbIdade";
            lbIdade.Size = new Size(36, 15);
            lbIdade.TabIndex = 29;
            lbIdade.Text = "Idade";
            // 
            // NUpDownIdade
            // 
            NUpDownIdade.Location = new Point(161, 109);
            NUpDownIdade.Name = "NUpDownIdade";
            NUpDownIdade.Size = new Size(213, 23);
            NUpDownIdade.TabIndex = 30;
            // 
            // frmAdicionar_Participante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 269);
            Controls.Add(NUpDownIdade);
            Controls.Add(lbIdade);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(lbNome);
            Controls.Add(txtNome);
            Name = "frmAdicionar_Participante";
            Text = "frmAdicionar_Participante";
            Load += frmAdicionar_Participante_Load;
            ((System.ComponentModel.ISupportInitialize)NUpDownIdade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //private Label lbIdade;
        //private Label lbIdade;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label lbNome;
        private Label lbParticipantes;
        private NumericUpDown NUpDownLimite;
        private NumericUpDown NUpDownIdade;
        private TextBox txtNome;
        private Label lbEmail;
        private TextBox txtEmail;
        private Label lbIdade;
        // private NumericUpDown NUpDownIdade;
    }
}