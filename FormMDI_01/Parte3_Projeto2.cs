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
    public partial class Parte3_Projeto2 : Form
    {
        // Lista para armazenar os números do Array 1
        private List<int> array1 = new List<int>();
        // Lista para armazenar os números do Array 2
        private List<int> array2 = new List<int>();

        // Construtor do formulário
        public Parte3_Projeto2()
        {
            InitializeComponent(); // Inicializa os componentes visuais do formulário
        }

        // Evento acionado ao clicar no botão de adicionar ao Array 1
        private void btnAddArray1_Click(object sender, EventArgs e)
        {
            // Tenta converter o texto digitado em número inteiro
            if (int.TryParse(txtArray1.Text, out int numero))
            {
                array1.Add(numero); // Adiciona o número à lista array1
                lstArray1.Items.Add(numero); // Adiciona o número à ListBox visual
                txtArray1.Clear(); // Limpa o campo de texto
                txtArray1.Focus(); // Coloca o foco novamente no campo de texto
            }
            else
            {
                // Exibe mensagem de erro caso o valor não seja um número válido
                MessageBox.Show("Digite um número válido para o Array 1.");
            }
        }

        // Evento acionado ao clicar no botão de adicionar ao Array 2
        private void btnAddArray2_Click(object sender, EventArgs e)
        {
            // Tenta converter o texto digitado em número inteiro
            if (int.TryParse(txtArray2.Text, out int numero))
            {
                array2.Add(numero); // Adiciona o número à lista array2
                lstArray2.Items.Add(numero); // Adiciona o número à ListBox visual
                txtArray2.Clear(); // Limpa o campo de texto
                txtArray2.Focus(); // Coloca o foco novamente no campo de texto
            }
            else
            {
                // Exibe mensagem de erro caso o valor não seja um número válido
                MessageBox.Show("Digite um número válido para o Array 2.");
            }
        }

        // Evento acionado ao clicar no botão de conferir números repetidos
        private void btnConferir_Click(object sender, EventArgs e)
        {
            // Chama método utilitário para obter os números repetidos entre os dois arrays
            List<int> repetidos = Utilitarios.NumerosRepetidos(array1, array2);

            // Se houver números repetidos, exibe-os em uma mensagem
            if (repetidos.Count > 0)
            {
                MessageBox.Show("Números repetidos:\n" + string.Join(", ", repetidos), "Resultado");
            }
            else
            {
                // Caso contrário, informa que não há números repetidos
                MessageBox.Show("Nenhum número se repete entre os arrays.", "Resultado");
            }
        }
    }
}