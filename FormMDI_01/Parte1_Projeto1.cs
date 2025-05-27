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
    // Classe principal do formulário Parte1_Projeto1, herda de Form
    public partial class Parte1_Projeto1 : Form
    {
        // Construtor do formulário
        public Parte1_Projeto1()
        {
            InitializeComponent(); // Inicializa os componentes visuais do formulário
            this.StartPosition = FormStartPosition.CenterScreen; // Define a posição inicial do formulário no centro da tela
        }

        // Evento disparado ao clicar no botão btnConverter
        private void btnConverter_Click(object sender, EventArgs e)
        {
            // Tenta converter o texto digitado em txtSegundos para um inteiro
            if (int.TryParse(txtSegundos.Text, out int segundos))
            {
                // Chama o método Utilitarios.ConverterSegundos para converter os segundos em formato de tempo legível
                string resultado = Utilitarios.ConverterSegundos(segundos);

                // Exibe o resultado convertido no label lblResultado
                lblResultado.Text = "Resultado: " + resultado;

                // Exibe também o resultado em uma MessageBox para o usuário
                MessageBox.Show($"Tempo convertido:\n{resultado}", "Conversão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Caso a conversão falhe, exibe uma mensagem de aviso ao usuário
                MessageBox.Show("Por favor, digite um número inteiro válido em segundos.",
                                "Entrada inválida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}
