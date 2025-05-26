using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMDI_01
{
    public partial class Parte3_Projeto3 : Form
    {
        public Parte3_Projeto3()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string frase = txtFrase.Text;
            string letraStr = txtLetra.Text;

            if (string.IsNullOrWhiteSpace(frase) || string.IsNullOrWhiteSpace(letraStr))
            {
                MessageBox.Show("Digite a frase e a letra.");
                return;
            }

            char letra = letraStr[0];
            int contagem = Utilitarios.ContarLetra(frase, letra);

            MessageBox.Show($"A letra '{letra}' aparece {contagem} vezes na frase.", "Resultado");
        }
    }
}