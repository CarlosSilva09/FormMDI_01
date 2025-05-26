namespace FormMDI_01
{
    partial class Parte4_Projeto1
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
            btnAdicionar = new Button();
            lstNumeros = new ListBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 33);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite um número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(49, 51);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(120, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(49, 80);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(120, 23);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.ItemHeight = 15;
            lstNumeros.Location = new Point(49, 109);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(120, 94);
            lstNumeros.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(49, 209);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(120, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular Soma";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Parte4_Projeto1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 265);
            Controls.Add(btnCalcular);
            Controls.Add(lstNumeros);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Parte4_Projeto1";
            Text = "Parte4_Projeto1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnAdicionar;
        private ListBox lstNumeros;
        private Button btnCalcular;
    }
}