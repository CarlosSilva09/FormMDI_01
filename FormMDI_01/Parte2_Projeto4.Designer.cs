namespace FormMDI_01
{
    partial class Parte2_Projeto4
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
            txtNota = new TextBox();
            btnAvaliar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 29);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite a nota (0 a 10)";
            // 
            // txtNota
            // 
            txtNota.Location = new Point(80, 48);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(116, 23);
            txtNota.TabIndex = 1;
            // 
            // btnAvaliar
            // 
            btnAvaliar.Location = new Point(80, 77);
            btnAvaliar.Name = "btnAvaliar";
            btnAvaliar.Size = new Size(116, 23);
            btnAvaliar.TabIndex = 2;
            btnAvaliar.Text = "Avaliar";
            btnAvaliar.UseVisualStyleBackColor = true;
            btnAvaliar.Click += btnAvaliar_Click;
            // 
            // Parte2_Projeto4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 158);
            Controls.Add(btnAvaliar);
            Controls.Add(txtNota);
            Controls.Add(label1);
            Name = "Parte2_Projeto4";
            Text = "Parte2_Projeto4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNota;
        private Button btnAvaliar;
    }
}