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
    public partial class Parte2_Projeto2 : Form
    {
        public Parte2_Projeto2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero1.Text, out int num1) && int.TryParse(txtNumero2.Text, out int num2))
            {
                int diferenca = Utilitarios.DiferencaMaiorMenor(num1, num2);
                MessageBox.Show($"A diferença do maior pelo menor é: {diferenca}", "Resultado");
            }
            else
            {
                MessageBox.Show("Digite dois números inteiros válidos.", "Erro");
            }
        }
    }
}