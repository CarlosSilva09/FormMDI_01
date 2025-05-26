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
    public partial class Parte1_Projeto5 : Form
    {
        public Parte1_Projeto5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime nascimento = dtpNascimento.Value;
            int idade = Utilitarios.CalcularIdade(nascimento);

            MessageBox.Show($"Idade: {idade} anos", "Resultado");
        }
    }
}
