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
    // Classe parcial do formulário Parte1_Projeto3
    public partial class Parte1_Projeto3 : Form
    {
        // Construtor do formulário
        public Parte1_Projeto3()
        {
            InitializeComponent(); // Inicializa os componentes visuais do formulário
        }

        // Evento disparado ao clicar no botão de conversão
        private void btnConverter_Click(object sender, EventArgs e)
        {
            // Tenta converter o texto digitado em txtCelsius para double
            if (double.TryParse(txtCelsius.Text, out double celsius))
            {
                // Verifica se a opção Kelvin está selecionada
                if (rdbKelvin.Checked)
                {
                    // Converte de Celsius para Kelvin usando método utilitário
                    double kelvin = Utilitarios.ConverterTemperatura(celsius, "K");
                    // Exibe o resultado em uma caixa de mensagem
                    MessageBox.Show($"Resultado: {kelvin:F2} K", "Conversão");
                }
                // Verifica se a opção Fahrenheit está selecionada
                else if (rdbFahrenheit.Checked)
                {
                    // Converte de Celsius para Fahrenheit usando método utilitário
                    double fahrenheit = Utilitarios.ConverterTemperatura(celsius, "F");
                    // Exibe o resultado em uma caixa de mensagem
                    MessageBox.Show($"Resultado: {fahrenheit:F2} °F", "Conversão");
                }
                else
                {
                    // Caso nenhuma opção esteja selecionada, exibe aviso
                    MessageBox.Show("Selecione uma opção de conversão.", "Aviso");
                }
            }
            else
            {
                // Caso o valor digitado não seja válido, exibe erro
                MessageBox.Show("Digite uma temperatura válida.", "Erro");
            }
        }
    }
}
