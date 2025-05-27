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
    // Define a classe do formulário principal para o projeto
    public partial class Parte2_Projeto3 : Form
    {
        // Construtor do formulário, inicializa os componentes visuais
        public Parte2_Projeto3()
        {
            InitializeComponent(); // Método que configura os controles do formulário
        }

        // Evento disparado ao clicar no botão "Calcular"
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Tenta converter os textos dos campos de peso e altura para double
            if (double.TryParse(txtPeso.Text, out double peso) && double.TryParse(txtAltura.Text, out double altura))
            {
                // Verifica se a altura é válida (maior que zero)
                if (altura <= 0)
                {
                    MessageBox.Show("A altura deve ser maior que zero.", "Erro"); // Exibe mensagem de erro
                    return; // Sai do método
                }

                // Chama método utilitário para calcular o IMC
                double imc = Utilitarios.CalcularIMC(peso, altura);
                // Exibe o resultado do IMC formatado com duas casas decimais
                MessageBox.Show($"Seu IMC é: {imc:F2}", "Resultado");
            }
            else
            {
                // Exibe mensagem de erro caso os valores não sejam válidos
                MessageBox.Show("Digite valores válidos para peso e altura.", "Erro");
            }
        }
    }
}