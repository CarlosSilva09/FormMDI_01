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
    // Classe parcial do formulário Parte3_Projeto4
    public partial class Parte3_Projeto4 : Form
    {
        // Construtor do formulário, inicializa os componentes visuais
        public Parte3_Projeto4()
        {
            InitializeComponent(); // Método gerado pelo designer para configurar os controles do formulário
        }

        // Evento disparado ao clicar no botão "Verificar"
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Tenta converter o texto digitado em txtAno para um inteiro (ano)
            if (int.TryParse(txtAno.Text, out int ano))
            {
                // Chama método utilitário para verificar se o ano é bissexto
                bool bissexto = Utilitarios.EhAnoBissexto(ano);

                // Define a mensagem de acordo com o resultado
                string mensagem = bissexto ? "O ano é bissexto." : "O ano NÃO é bissexto.";

                // Exibe a mensagem em uma caixa de diálogo
                MessageBox.Show(mensagem, "Resultado");
            }
            else
            {
                // Exibe mensagem de erro caso o valor digitado não seja um ano válido
                MessageBox.Show("Digite um ano válido.", "Erro");
            }
        }
    }
}