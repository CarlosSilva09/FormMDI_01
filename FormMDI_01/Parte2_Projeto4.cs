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
    public partial class Parte2_Projeto4 : Form
    {
        public Parte2_Projeto4()
        {
            InitializeComponent();
        }

        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNota.Text, out double nota))
            {
                string avaliacao = Utilitarios.AvaliarNota(nota);
                MessageBox.Show($"Avaliação: {avaliacao}", "Resultado");
            }
            else
            {
                MessageBox.Show("Digite uma nota válida entre 0 e 10.", "Erro");
            }
        }
    }
}