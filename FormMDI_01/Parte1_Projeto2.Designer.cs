namespace FormMDI_01
{
    partial class Parte1_Projeto2
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
            txtInicio = new TextBox();
            label2 = new Label();
            txtFim = new TextBox();
            btnVerificar = new Button();
            lstPares = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 64);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero Inicial";
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(247, 82);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(122, 23);
            txtInicio.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 128);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Número Final:";
            // 
            // txtFim
            // 
            txtFim.Location = new Point(247, 146);
            txtFim.Name = "txtFim";
            txtFim.Size = new Size(122, 23);
            txtFim.TabIndex = 3;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(247, 186);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(122, 23);
            btnVerificar.TabIndex = 4;
            btnVerificar.Text = "Verificar Pares";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lstPares
            // 
            lstPares.FormattingEnabled = true;
            lstPares.ItemHeight = 15;
            lstPares.Location = new Point(250, 220);
            lstPares.Name = "lstPares";
            lstPares.Size = new Size(120, 94);
            lstPares.TabIndex = 5;
            // 
            // Parte1_Projeto2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 329);
            Controls.Add(lstPares);
            Controls.Add(btnVerificar);
            Controls.Add(txtFim);
            Controls.Add(label2);
            Controls.Add(txtInicio);
            Controls.Add(label1);
            Name = "Parte1_Projeto2";
            Text = "Parte1_Projeto2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInicio;
        private Label label2;
        private TextBox txtFim;
        private Button btnVerificar;
        private ListBox lstPares;
    }
}