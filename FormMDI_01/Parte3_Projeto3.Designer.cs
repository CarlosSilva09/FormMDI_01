namespace FormMDI_01
{
    partial class Parte3_Projeto3
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
            txtFrase = new TextBox();
            label2 = new Label();
            txtLetra = new TextBox();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 47);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite uma frase";
            // 
            // txtFrase
            // 
            txtFrase.Location = new Point(78, 65);
            txtFrase.Multiline = true;
            txtFrase.Name = "txtFrase";
            txtFrase.Size = new Size(117, 23);
            txtFrase.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 100);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Digite uma letra";
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(78, 118);
            txtLetra.MaxLength = 1;
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(117, 23);
            txtLetra.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(78, 147);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(117, 23);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // Parte3_Projeto3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 244);
            Controls.Add(btnConfirmar);
            Controls.Add(txtLetra);
            Controls.Add(label2);
            Controls.Add(txtFrase);
            Controls.Add(label1);
            Name = "Parte3_Projeto3";
            Text = "Parte3_Projeto3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFrase;
        private Label label2;
        private TextBox txtLetra;
        private Button btnConfirmar;
    }
}