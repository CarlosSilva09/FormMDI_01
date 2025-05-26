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
    public partial class Parte4_Projeto1 : Form
    {
        public Parte4_Projeto1()
        {
            InitializeComponent();
        }
        private List<int> vetor = new List<int>();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (vetor.Count >= 8)
            {
                MessageBox.Show("O vetor já possui 8 números.");
                return;
            }

            if (int.TryParse(txtNumero.Text, out int numero))
            {
                vetor.Add(numero);
                lstNumeros.Items.Add(numero);
                txtNumero.Clear();
                txtNumero.Focus();
            }
            else
            {
                MessageBox.Show("Digite um número inteiro válido.");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (vetor.Count < 8)
            {
                MessageBox.Show("Adicione exatamente 8 números antes de calcular.");
                return;
            }

            int resultado = Utilitarios.SomaMultiplicadaPorIndice(vetor.ToArray());
            MessageBox.Show($"Resultado da soma multiplicada pela posição: {resultado}", "Resultado");
        }
    }
}