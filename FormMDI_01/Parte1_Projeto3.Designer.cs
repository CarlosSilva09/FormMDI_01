namespace FormMDI_01
{
    partial class Parte1_Projeto3
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
            txtCelsius = new TextBox();
            groupBox1 = new GroupBox();
            rdbFahrenheit = new RadioButton();
            rdbKelvin = new RadioButton();
            btnConverter = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 63);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 0;
            label1.Text = "Temperatura em Celsius";
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(77, 81);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(133, 23);
            txtCelsius.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbFahrenheit);
            groupBox1.Controls.Add(rdbKelvin);
            groupBox1.Location = new Point(44, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Converter para";
            // 
            // rdbFahrenheit
            // 
            rdbFahrenheit.AutoSize = true;
            rdbFahrenheit.Location = new Point(15, 49);
            rdbFahrenheit.Name = "rdbFahrenheit";
            rdbFahrenheit.Size = new Size(81, 19);
            rdbFahrenheit.TabIndex = 1;
            rdbFahrenheit.TabStop = true;
            rdbFahrenheit.Text = "Fahrenheit";
            rdbFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rdbKelvin
            // 
            rdbKelvin.AutoSize = true;
            rdbKelvin.Location = new Point(15, 24);
            rdbKelvin.Name = "rdbKelvin";
            rdbKelvin.Size = new Size(57, 19);
            rdbKelvin.TabIndex = 0;
            rdbKelvin.TabStop = true;
            rdbKelvin.Text = "Kelvin";
            rdbKelvin.UseVisualStyleBackColor = true;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(44, 216);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(200, 23);
            btnConverter.TabIndex = 4;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // Parte1_Projeto3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 378);
            Controls.Add(btnConverter);
            Controls.Add(groupBox1);
            Controls.Add(txtCelsius);
            Controls.Add(label1);
            Name = "Parte1_Projeto3";
            Text = "Parte1_Projeto3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCelsius;
        private GroupBox groupBox1;
        private RadioButton rdbFahrenheit;
        private RadioButton rdbKelvin;
        private Button btnConverter;
    }
}