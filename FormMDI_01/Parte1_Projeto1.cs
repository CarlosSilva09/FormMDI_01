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
    public partial class Parte1_Projeto1 : Form
    {
        public Parte1_Projeto1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSegundos.Text, out int segundos))
            {
                string resultado = Utilitarios.ConverterSegundos(segundos);
                lblResultado.Text = "Resultado: " + resultado;

                // Mostrando também em MessageBox, se quiser
                MessageBox.Show($"Tempo convertido:\n{resultado}", "Conversão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, digite um número inteiro válido em segundos.",
                                "Entrada inválida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}
