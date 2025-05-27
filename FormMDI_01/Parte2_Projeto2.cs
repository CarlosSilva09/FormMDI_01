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
    // Define a classe do formulário Parte2_Projeto2, que herda de Form
    public partial class Parte2_Projeto2 : Form
    {
        // Construtor do formulário, inicializa os componentes visuais
        public Parte2_Projeto2()
        {
            InitializeComponent(); // Método que configura os controles do formulário
        }

        // Evento disparado ao clicar no botão btnCalcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Tenta converter o texto dos campos txtNumero1 e txtNumero2 para inteiros
            if (int.TryParse(txtNumero1.Text, out int num1) && int.TryParse(txtNumero2.Text, out int num2))
            {
                // Chama o método DiferencaMaiorMenor da classe Utilitarios para calcular a diferença entre o maior e o menor número
                int diferenca = Utilitarios.DiferencaMaiorMenor(num1, num2);
                // Exibe o resultado em uma caixa de mensagem
                MessageBox.Show($"A diferença do maior pelo menor é: {diferenca}", "Resultado");
            }
            else
            {
                // Exibe mensagem de erro caso os valores digitados não sejam inteiros válidos
                MessageBox.Show("Digite dois números inteiros válidos.", "Erro");
            }
        }
    }
}