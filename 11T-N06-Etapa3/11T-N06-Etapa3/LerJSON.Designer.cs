namespace _11T_N06_Etapa3
{
    partial class LerJSON
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
            label1 = new Label();
            btnnao = new Button();
            btnsim = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Modern No. 20", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(486, 49);
            label1.TabIndex = 1;
            label1.Text = "Deseja ler o ficheiro JSON ?\r\n\r\n";
            label1.Click += label1_Click;
            // 
            // btnnao
            // 
            btnnao.Location = new Point(267, 198);
            btnnao.Name = "btnnao";
            btnnao.Size = new Size(205, 113);
            btnnao.TabIndex = 2;
            btnnao.Text = "NÃO";
            btnnao.UseVisualStyleBackColor = true;
            btnnao.Click += btnnao_Click;
            // 
            // btnsim
            // 
            btnsim.Location = new Point(33, 198);
            btnsim.Name = "btnsim";
            btnsim.Size = new Size(205, 113);
            btnsim.TabIndex = 3;
            btnsim.Text = "SIM";
            btnsim.UseVisualStyleBackColor = true;
            btnsim.Click += btnsim_Click;
            // 
            // LerJSON
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 323);
            Controls.Add(btnsim);
            Controls.Add(btnnao);
            Controls.Add(label1);
            Name = "LerJSON";
            Text = "LerJSON";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button btnnao;
        private Button btnsim;
    }
}