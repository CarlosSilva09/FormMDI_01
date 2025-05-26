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
    public partial class Parte2_Projeto1 : Form
    {
        public Parte2_Projeto1()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                double resultado = Utilitarios.DobroOuMetade(numero);

                string tipo = numero % 2 == 0 ? "dobro" : "metade";
                MessageBox.Show($"O número é {(numero % 2 == 0 ? "par" : "ímpar")}, então o {tipo} é: {resultado}", "Resultado");
            }
            else
            {
                MessageBox.Show("Digite um número inteiro válido.", "Erro");
            }
        }
    }
}