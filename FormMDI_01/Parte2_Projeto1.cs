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
    // Define a classe do formulário principal
    public partial class Parte2_Projeto1 : Form
    {
        // Construtor do formulário, inicializa os componentes visuais
        public Parte2_Projeto1()
        {
            InitializeComponent(); // Inicializa os controles do formulário
        }

        // Evento disparado ao clicar no botão "Calcular"
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Tenta converter o texto digitado na caixa de texto para um número inteiro
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                // Chama o método utilitário para calcular o dobro ou a metade do número
                double resultado = Utilitarios.DobroOuMetade(numero);

                // Define se o número é par ou ímpar e qual operação foi realizada
                string tipo = numero % 2 == 0 ? "dobro" : "metade";

                // Exibe o resultado em uma caixa de mensagem
                MessageBox.Show(
                    $"O número é {(numero % 2 == 0 ? "par" : "ímpar")}, então o {tipo} é: {resultado}",
                    "Resultado"
                );
            }
            else
            {
                // Exibe mensagem de erro caso o valor digitado não seja um número inteiro válido
                MessageBox.Show("Digite um número inteiro válido.", "Erro");
            }
        }
    }
}