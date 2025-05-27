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
    // Classe principal do formulário Parte2_Projeto5, que herda de Form
    public partial class Parte2_Projeto5 : Form
    {
        // Construtor do formulário, inicializa os componentes visuais
        public Parte2_Projeto5()
        {
            InitializeComponent(); // Método que configura os controles do formulário
        }

        // Evento disparado ao clicar no botão btnCalcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtém a data selecionada no controle dtpData1, ignorando a hora
            DateTime data1 = dtpData1.Value.Date;
            // Obtém a data selecionada no controle dtpData2, ignorando a hora
            DateTime data2 = dtpData2.Value.Date;

            // Chama o método utilitário para calcular a diferença em dias entre as duas datas
            int diferenca = Utilitarios.DiasEntreDatas(data1, data2);
            // Exibe o resultado em uma caixa de mensagem para o usuário
            MessageBox.Show($"A diferença entre as datas é de {diferenca} dias.", "Resultado");
        }
    }
}