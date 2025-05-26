namespace FormMDI_01
{
    partial class Parte1_Projeto5
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
            dtpNascimento = new DateTimePicker();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 79);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite sua data de nascimento";
            // 
            // dtpNascimento
            // 
            dtpNascimento.Location = new Point(76, 97);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(250, 23);
            dtpNascimento.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(76, 126);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(250, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular Idade";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Parte1_Projeto5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(btnCalcular);
            Controls.Add(dtpNascimento);
            Controls.Add(label1);
            Name = "Parte1_Projeto5";
            Text = "Parte1_Projeto5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpNascimento;
        private Button btnCalcular;
    }
}