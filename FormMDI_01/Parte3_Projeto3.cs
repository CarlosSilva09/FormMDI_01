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
    // Classe parcial do formulário Parte3_Projeto3
    public partial class Parte3_Projeto3 : Form
    {
        // Construtor do formulário, inicializa os componentes visuais
        public Parte3_Projeto3()
        {
            InitializeComponent(); // Método gerado pelo designer para configurar os controles do formulário
        }

        // Evento disparado ao clicar no botão "Confirmar"
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Obtém o texto digitado na caixa de texto da frase
            string frase = txtFrase.Text;
            // Obtém o texto digitado na caixa de texto da letra
            string letraStr = txtLetra.Text;

            // Verifica se algum dos campos está vazio ou contém apenas espaços em branco
            if (string.IsNullOrWhiteSpace(frase) || string.IsNullOrWhiteSpace(letraStr))
            {
                // Exibe mensagem de alerta caso algum campo não tenha sido preenchido
                MessageBox.Show("Digite a frase e a letra.");
                return; // Sai do método sem executar o restante do código
            }

            // Pega o primeiro caractere digitado na caixa de texto da letra
            char letra = letraStr[0];
            // Chama o método utilitário para contar quantas vezes a letra aparece na frase
            int contagem = Utilitarios.ContarLetra(frase, letra);

            // Exibe o resultado em uma caixa de mensagem
            MessageBox.Show($"A letra '{letra}' aparece {contagem} vezes na frase.", "Resultado");
        }
    }
}