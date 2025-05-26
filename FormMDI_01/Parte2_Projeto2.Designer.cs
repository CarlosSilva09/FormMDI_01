namespace FormMDI_01
{
    partial class Parte2_Projeto2
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
            txtNumero1 = new TextBox();
            label2 = new Label();
            txtNumero2 = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 38);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Número 1";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(102, 56);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(139, 23);
            txtNumero1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 87);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Número 2";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(102, 105);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(139, 23);
            txtNumero2.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(102, 134);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(139, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular Diferença";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Parte2_Projeto2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 290);
            Controls.Add(btnCalcular);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Parte2_Projeto2";
            Text = "Parte2_Projeto2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero1;
        private Label label2;
        private TextBox txtNumero2;
        private Button btnCalcular;
    }
}