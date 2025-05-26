namespace FormMDI_01
{
    partial class Parte2_Projeto5
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
            label2 = new Label();
            dtpData1 = new DateTimePicker();
            dtpData2 = new DateTimePicker();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 80);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Data 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 80);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Data 2";
            // 
            // dtpData1
            // 
            dtpData1.Location = new Point(198, 98);
            dtpData1.Name = "dtpData1";
            dtpData1.RightToLeft = RightToLeft.No;
            dtpData1.Size = new Size(80, 23);
            dtpData1.TabIndex = 1;
            // 
            // dtpData2
            // 
            dtpData2.Location = new Point(309, 98);
            dtpData2.Name = "dtpData2";
            dtpData2.RightToLeft = RightToLeft.No;
            dtpData2.Size = new Size(80, 23);
            dtpData2.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(198, 129);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(191, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular Diferença";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Parte2_Projeto5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 285);
            Controls.Add(btnCalcular);
            Controls.Add(dtpData2);
            Controls.Add(dtpData1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Parte2_Projeto5";
            Text = "Parte2_Projeto5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpData1;
        private DateTimePicker dtpData2;
        private Button btnCalcular;
    }
}