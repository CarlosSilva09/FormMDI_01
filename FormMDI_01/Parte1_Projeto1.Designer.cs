namespace FormMDI_01
{
    partial class Parte1_Projeto1
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
            txtSegundos = new TextBox();
            btnConverter = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtSegundos
            // 
            txtSegundos.Location = new Point(70, 82);
            txtSegundos.Name = "txtSegundos";
            txtSegundos.Size = new Size(146, 23);
            txtSegundos.TabIndex = 0;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(70, 111);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(146, 23);
            btnConverter.TabIndex = 1;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(70, 64);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado";
            // 
            // Parte1_Projeto1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 226);
            Controls.Add(lblResultado);
            Controls.Add(btnConverter);
            Controls.Add(txtSegundos);
            Name = "Parte1_Projeto1";
            Text = "Parte1_Projeto1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSegundos;
        private Button btnConverter;
        private Label lblResultado;
    }
}