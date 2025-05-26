namespace FormMDI_01
{
    partial class Parte1_Projeto4
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
            txtNumero = new TextBox();
            btnVerificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 54);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite um número inteiro";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(103, 75);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(137, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(103, 104);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(137, 23);
            btnVerificar.TabIndex = 2;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // Parte1_Projeto4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 313);
            Controls.Add(btnVerificar);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Parte1_Projeto4";
            Text = "Parte1_Projeto4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnVerificar;
    }
}