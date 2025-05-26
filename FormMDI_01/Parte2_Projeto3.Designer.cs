namespace FormMDI_01
{
    partial class Parte2_Projeto3
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
            txtAltura = new TextBox();
            label2 = new Label();
            btnCalcular = new Button();
            txtPeso = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 39);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Peso (kg)";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(155, 119);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 101);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 0;
            label2.Text = "Altura (m)";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(155, 148);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular IMC";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(155, 57);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 1;
            // 
            // Parte2_Projeto3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 266);
            Controls.Add(btnCalcular);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Parte2_Projeto3";
            Text = "Parte2_Projeto3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAltura;
        private Label label2;
        private Button btnCalcular;
        private TextBox txtPeso;
    }
}