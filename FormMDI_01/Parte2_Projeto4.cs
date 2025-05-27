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
    // Classe parcial do formulário Parte2_Projeto4
    public partial class Parte2_Projeto4 : Form
    {
        // Construtor do formulário, inicializa os componentes visuais
        public Parte2_Projeto4()
        {
            InitializeComponent(); // Método gerado pelo designer para configurar os controles do formulário
        }

        // Evento disparado ao clicar no botão btnAvaliar
        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            // Tenta converter o texto digitado em txtNota para um valor double
            if (double.TryParse(txtNota.Text, out double nota))
            {
                // Chama o método AvaliarNota da classe Utilitarios para obter a avaliação da nota
                string avaliacao = Utilitarios.AvaliarNota(nota);
                // Exibe o resultado da avaliação em uma MessageBox
                MessageBox.Show($"Avaliação: {avaliacao}", "Resultado");
            }
            else
            {
                // Exibe uma mensagem de erro caso o valor digitado não seja um número válido entre 0 e 10
                MessageBox.Show("Digite uma nota válida entre 0 e 10.", "Erro");
            }
        }
    }
}