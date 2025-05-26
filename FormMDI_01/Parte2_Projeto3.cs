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
    public partial class Parte2_Projeto3 : Form
    {
        public Parte2_Projeto3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPeso.Text, out double peso) && double.TryParse(txtAltura.Text, out double altura))
            {
                if (altura <= 0)
                {
                    MessageBox.Show("A altura deve ser maior que zero.", "Erro");
                    return;
                }

                double imc = Utilitarios.CalcularIMC(peso, altura);
                MessageBox.Show($"Seu IMC é: {imc:F2}", "Resultado");
            }
            else
            {
                MessageBox.Show("Digite valores válidos para peso e altura.", "Erro");
            }
        }
    }
}