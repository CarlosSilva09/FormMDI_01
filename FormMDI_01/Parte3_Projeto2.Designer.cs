namespace FormMDI_01
{
    partial class Parte3_Projeto2
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
            txtArray1 = new TextBox();
            btnAddArray1 = new Button();
            lstArray1 = new ListBox();
            label2 = new Label();
            txtArray2 = new TextBox();
            btnAddArray2 = new Button();
            lstArray2 = new ListBox();
            btnConferir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 95);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Número para Array 1";
            // 
            // txtArray1
            // 
            txtArray1.Location = new Point(60, 113);
            txtArray1.Name = "txtArray1";
            txtArray1.Size = new Size(120, 23);
            txtArray1.TabIndex = 1;
            // 
            // btnAddArray1
            // 
            btnAddArray1.Location = new Point(48, 142);
            btnAddArray1.Name = "btnAddArray1";
            btnAddArray1.Size = new Size(141, 23);
            btnAddArray1.TabIndex = 2;
            btnAddArray1.Text = "Adicionar ao Array 1";
            btnAddArray1.UseVisualStyleBackColor = true;
            btnAddArray1.Click += btnAddArray1_Click;
            // 
            // lstArray1
            // 
            lstArray1.FormattingEnabled = true;
            lstArray1.ItemHeight = 15;
            lstArray1.Location = new Point(60, 171);
            lstArray1.Name = "lstArray1";
            lstArray1.Size = new Size(120, 94);
            lstArray1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 95);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 0;
            label2.Text = "Número para Array 2";
            // 
            // txtArray2
            // 
            txtArray2.Location = new Point(280, 113);
            txtArray2.Name = "txtArray2";
            txtArray2.Size = new Size(120, 23);
            txtArray2.TabIndex = 1;
            // 
            // btnAddArray2
            // 
            btnAddArray2.Location = new Point(270, 142);
            btnAddArray2.Name = "btnAddArray2";
            btnAddArray2.Size = new Size(140, 23);
            btnAddArray2.TabIndex = 2;
            btnAddArray2.Text = "Adicionar ao Array 2";
            btnAddArray2.UseVisualStyleBackColor = true;
            btnAddArray2.Click += btnAddArray2_Click;
            // 
            // lstArray2
            // 
            lstArray2.FormattingEnabled = true;
            lstArray2.ItemHeight = 15;
            lstArray2.Location = new Point(280, 171);
            lstArray2.Name = "lstArray2";
            lstArray2.Size = new Size(120, 94);
            lstArray2.TabIndex = 3;
            // 
            // btnConferir
            // 
            btnConferir.Location = new Point(48, 271);
            btnConferir.Name = "btnConferir";
            btnConferir.Size = new Size(362, 23);
            btnConferir.TabIndex = 4;
            btnConferir.Text = "Conferir Repetidos";
            btnConferir.UseVisualStyleBackColor = true;
            btnConferir.Click += btnConferir_Click;
            // 
            // Parte3_Projeto2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 450);
            Controls.Add(btnConferir);
            Controls.Add(lstArray2);
            Controls.Add(btnAddArray2);
            Controls.Add(lstArray1);
            Controls.Add(txtArray2);
            Controls.Add(btnAddArray1);
            Controls.Add(label2);
            Controls.Add(txtArray1);
            Controls.Add(label1);
            Name = "Parte3_Projeto2";
            Text = "Parte3_Projeto2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtArray1;
        private Button btnAddArray1;
        private ListBox lstArray1;
        private Label label2;
        private TextBox txtArray2;
        private Button btnAddArray2;
        private ListBox lstArray2;
        private Button btnConferir;
    }
}