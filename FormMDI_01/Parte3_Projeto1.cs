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
    // Classe principal do formulário Parte3_Projeto1
    public partial class Parte3_Projeto1 : Form
    {
        // Lista para armazenar os números inseridos pelo usuário
        private List<int> numeros = new List<int>();

        // Construtor do formulário, inicializa os componentes visuais
        public Parte3_Projeto1()
        {
            InitializeComponent();
        }

        // Evento acionado ao clicar no botão "Adicionar"
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Tenta converter o texto digitado em um número inteiro
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                // Verifica se o número está entre 0 e 100
                if (numero >= 0 && numero <= 100)
                {
                    // Adiciona o número à lista interna
                    numeros.Add(numero);
                    // Adiciona o número à lista visual (ListBox)
                    lstNumeros.Items.Add(numero);
                    // Limpa o campo de texto para nova entrada
                    txtNumero.Clear();
                    // Coloca o foco novamente no campo de texto
                    txtNumero.Focus();
                }
                else
                {
                    // Exibe mensagem se o número estiver fora do intervalo permitido
                    MessageBox.Show("Digite um número entre 0 e 100.");
                }
            }
            else
            {
                // Exibe mensagem se o valor digitado não for um número válido
                MessageBox.Show("Digite um número válido.");
            }
        }

        // Evento acionado ao clicar no botão "Conferir"
        private void btnConferir_Click(object sender, EventArgs e)
        {
            // Chama método utilitário para analisar as faixas dos números inseridos
            var faixas = Utilitarios.AnalisarFaixas(numeros);
            // Exibe o resultado da análise em uma MessageBox
            MessageBox.Show(
                $"0 a 25: {faixas.faixa1} números\n" +
                $"26 a 50: {faixas.faixa2} números\n" +
                $"51 a 75: {faixas.faixa3} números\n" +
                $"76 a 100: {faixas.faixa4} números",
                "Análise de Faixas");
        }
    }
}