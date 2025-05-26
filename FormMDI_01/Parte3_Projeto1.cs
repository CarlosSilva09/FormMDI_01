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
    public partial class Parte3_Projeto1 : Form

    {
        private List<int> numeros = new List<int>();

        public Parte3_Projeto1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                if (numero >= 0 && numero <= 100)
                {
                    numeros.Add(numero);
                    lstNumeros.Items.Add(numero);
                    txtNumero.Clear();
                    txtNumero.Focus();
                }
                else
                {
                    MessageBox.Show("Digite um número entre 0 e 100.");
                }
            }
            else
            {
                MessageBox.Show("Digite um número válido.");
            }
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            var faixas = Utilitarios.AnalisarFaixas(numeros);
            MessageBox.Show(
                $"0 a 25: {faixas.faixa1} números\n" +
                $"26 a 50: {faixas.faixa2} números\n" +
                $"51 a 75: {faixas.faixa3} números\n" +
                $"76 a 100: {faixas.faixa4} números",
                "Análise de Faixas");
        }
    }
}