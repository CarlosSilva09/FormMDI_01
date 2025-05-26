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
    public partial class Parte1_Projeto4 : Form
    {
        public Parte1_Projeto4()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                bool divisivel = Utilitarios.EhDivisivelPor3(numero);
                string mensagem = divisivel
                    ? "O número é divisível por 3."
                    : "O número NÃO é divisível por 3.";

                MessageBox.Show(mensagem, "Resultado");
            }
            else
            {
                MessageBox.Show("Digite um número inteiro válido.", "Erro");
            }
        }
    }
}