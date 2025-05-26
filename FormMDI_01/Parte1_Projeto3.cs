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
    public partial class Parte1_Projeto3 : Form
    {
        public Parte1_Projeto3()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double celsius))
            {
                if (rdbKelvin.Checked)
                {
                    double kelvin = Utilitarios.ConverterTemperatura(celsius, "K");
                    MessageBox.Show($"Resultado: {kelvin:F2} K", "Conversão");
                }
                else if (rdbFahrenheit.Checked)
                {
                    double fahrenheit = Utilitarios.ConverterTemperatura(celsius, "F");
                    MessageBox.Show($"Resultado: {fahrenheit:F2} °F", "Conversão");
                }
                else
                {
                    MessageBox.Show("Selecione uma opção de conversão.", "Aviso");
                }
            }
            else
            {
                MessageBox.Show("Digite uma temperatura válida.", "Erro");
            }
        }
    }
}
