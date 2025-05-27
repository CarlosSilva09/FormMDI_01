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
    // Define a classe do formulário principal do projeto
    public partial class Parte1_Projeto5 : Form
    {
        // Construtor do formulário, inicializa os componentes visuais
        public Parte1_Projeto5()
        {
            InitializeComponent(); // Método gerado pelo designer para configurar os controles do formulário
        }

        // Evento disparado ao clicar no botão "Calcular"
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtém a data de nascimento selecionada no controle DateTimePicker
            DateTime nascimento = dtpNascimento.Value;

            // Chama o método utilitário para calcular a idade a partir da data de nascimento
            int idade = Utilitarios.CalcularIdade(nascimento);

            // Exibe uma mensagem com a idade calculada em uma caixa de diálogo
            MessageBox.Show($"Idade: {idade} anos", "Resultado");
        }
    }
}
