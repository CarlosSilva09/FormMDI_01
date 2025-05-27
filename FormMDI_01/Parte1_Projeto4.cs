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
    public partial class Parte1_Projeto4 : Form
    {
        // Construtor do formulário, inicializa os componentes visuais
        public Parte1_Projeto4()
        {
            InitializeComponent(); // Método que configura os controles do formulário
        }

        // Evento disparado ao clicar no botão "Verificar"
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Tenta converter o texto digitado na caixa de texto para um número inteiro
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                // Chama o método utilitário para verificar se o número é divisível por 3
                bool divisivel = Utilitarios.EhDivisivelPor3(numero);

                // Define a mensagem de acordo com o resultado da verificação
                string mensagem = divisivel
                    ? "O número é divisível por 3."
                    : "O número NÃO é divisível por 3.";

                // Exibe a mensagem em uma caixa de diálogo
                MessageBox.Show(mensagem, "Resultado");
            }
            else
            {
                // Exibe mensagem de erro caso o valor digitado não seja um número inteiro válido
                MessageBox.Show("Digite um número inteiro válido.", "Erro");
            }
        }
    }
}