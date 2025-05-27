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
    // Classe principal do formulário Parte1_Projeto2
    public partial class Parte1_Projeto2 : Form
    {
        // Construtor do formulário, inicializa os componentes visuais
        public Parte1_Projeto2()
        {
            InitializeComponent(); // Método gerado pelo designer para configurar os controles do formulário
        }

        // Evento disparado ao clicar no botão btnVerificar
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            lstPares.Items.Clear(); // Limpa a lista de pares antes de adicionar novos valores

            // Tenta converter os textos das caixas de texto para inteiros
            if (int.TryParse(txtInicio.Text, out int inicio) && int.TryParse(txtFim.Text, out int fim))
            {
                // Verifica se o valor inicial é maior que o final
                if (inicio > fim)
                {
                    MessageBox.Show("O número inicial deve ser menor que o número final."); // Exibe mensagem de erro
                    return; // Sai do método
                }

                // Percorre todos os números do valor inicial até o final
                for (int i = inicio; i <= fim; i++)
                {
                    // Verifica se o número é par
                    if (i % 2 == 0)
                    {
                        lstPares.Items.Add(i); // Adiciona o número par à lista
                    }
                }
            }
            else
            {
                // Exibe mensagem de erro caso os valores não sejam inteiros válidos
                MessageBox.Show("Por favor, digite valores válidos.");
            }
        }
    }
}