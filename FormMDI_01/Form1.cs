namespace FormMDI_01
{
    public partial class Form1 : Form
    {
        // Construtor do formulário principal
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Ativa o modo MDI na janela principal
        }

        // Abre o formulário Parte1_Projeto1 como filho MDI
        private void parte1Projeto1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Parte1_Projeto1 tela = new Parte1_Projeto1();
            tela.MdiParent = this;
            tela.Show();
        }

        // Abre o formulário Parte1_Projeto2 como filho MDI
        private void parte1Projeto2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parte1_Projeto2 tela = new Parte1_Projeto2();
            tela.MdiParent = this;
            tela.Show();
        }

        // Abre o formulário Parte1_Projeto3 como filho MDI
        private void parte1Projeto3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parte1_Projeto3 tela = new Parte1_Projeto3();
            tela.MdiParent = this;
            tela.Show();
        }

        // Abre o formulário Parte1_Projeto4 como filho MDI
        private void parte1Projeto4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parte1_Projeto4 tela = new Parte1_Projeto4();
            tela.MdiParent = this;
            tela.Show();
        }

        // Abre o formulário Parte1_Projeto5 como filho MDI
        private void parte1Projeto5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parte1_Projeto5 tela = new Parte1_Projeto5();
            tela.MdiParent = this;
            tela.Show();
        }

        // Abre o formulário Parte2_Projeto1 como filho MDI
        private void parte2Projeto1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parte2_Projeto1 tela = new Parte2_Projeto1();
            tela.MdiParent = this;
            tela.Show();
        }

        // Abre o formulário Parte2_Projeto2 como filho MDI
        private void parte2Projeto2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parte2_Projeto2 tela = new Parte2_Projeto2();
            tela.MdiParent = this;
            tela.Show();
        }

        // Abre o formulário Parte2_Projeto3 como filho MDI
        private void parte2Projeto3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parte2_Projeto3 tela = new Parte2_Projeto3();
            tela.MdiParent = this;
            tela.Show();
        }

        // Abre o formulário Parte2_Projeto4 como filho MDI
        private void parte2Projeto4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parte2_Projeto4 tela = new Parte2_Projeto4();
            tela.MdiParent = this;
            tela.Show();
        }

        // Abre o formulário Parte2_Projeto5 como filho MDI
        private void parte2Projeto5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parte2_Projeto5 tela = new Parte2_Projeto5();
            tela.MdiParent = this;
            tela.Show();
        }

        // Abre o formulário Parte3_Projeto1 como filho MDI
        private void parte3Projeto1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parte3_Projeto1 tela = new Parte3_Projeto1();
            tela.MdiParent = this;
            tela.Show();
        }

        // Abre o formulário Parte3_Projeto2 como filho MDI
        private void parte3Projeto2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parte3_Projeto2 tela = new Parte3_Projeto2();
            tela.MdiParent = this;
            tela.Show();
        }

        // Abre o formulário Parte3_Projeto3 como filho MDI
        private void parte3Projeto3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parte3_Projeto3 tela = new Parte3_Projeto3();
            tela.MdiParent = this;
            tela.Show();
        }

        // Abre o formulário Parte3_Projeto4 como filho MDI
        private void parte3Projeto4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parte3_Projeto4 tela = new Parte3_Projeto4();
            tela.MdiParent = this;
            tela.Show();
        }

        // Abre o formulário Parte4_Projeto1 como filho MDI
        private void parte4Projeto1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parte4_Projeto1 tela = new Parte4_Projeto1();
            tela.MdiParent = this;
            tela.Show();
        }
    }
}
