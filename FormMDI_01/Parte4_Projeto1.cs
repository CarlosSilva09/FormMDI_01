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
    // Classe principal do formulário Parte4_Projeto1
    public partial class Parte4_Projeto1 : Form
    {
        // Construtor do formulário, inicializa os componentes visuais
        public Parte4_Projeto1()
        {
            InitializeComponent();
        }

        // Lista para armazenar os números inteiros inseridos pelo usuário
        private List<int> vetor = new List<int>();

        // Evento acionado ao clicar no botão "Adicionar"
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Verifica se já foram adicionados 8 números ao vetor
            if (vetor.Count >= 8)
            {
                MessageBox.Show("O vetor já possui 8 números.");
                return;
            }

            // Tenta converter o texto digitado em um número inteiro
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                // Adiciona o número à lista
                vetor.Add(numero);
                // Adiciona o número à lista visual (ListBox)
                lstNumeros.Items.Add(numero);
                // Limpa o campo de texto
                txtNumero.Clear();
                // Coloca o foco novamente no campo de texto para facilitar a próxima entrada
                txtNumero.Focus();
            }
            else
            {
                // Exibe mensagem de erro caso o valor digitado não seja um número inteiro válido
                MessageBox.Show("Digite um número inteiro válido.");
            }
        }

        // Evento acionado ao clicar no botão "Calcular"
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verifica se o vetor possui exatamente 8 números antes de calcular
            if (vetor.Count < 8)
            {
                MessageBox.Show("Adicione exatamente 8 números antes de calcular.");
                return;
            }

            // Chama o método utilitário para calcular a soma multiplicada pelo índice
            int resultado = Utilitarios.SomaMultiplicadaPorIndice(vetor.ToArray());
            // Exibe o resultado em uma caixa de mensagem
            MessageBox.Show($"Resultado da soma multiplicada pela posição: {resultado}", "Resultado");
        }
    }
}