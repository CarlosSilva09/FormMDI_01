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
    public partial class Parte1_Projeto2 : Form
    {
        public Parte1_Projeto2()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            lstPares.Items.Clear();

            if (int.TryParse(txtInicio.Text, out int inicio) && int.TryParse(txtFim.Text, out int fim))
            {
                if (inicio > fim)
                {
                    MessageBox.Show("O número inicial deve ser menor que o número final.");
                    return;
                }

                for (int i = inicio; i <= fim; i++)
                {
                    if (i % 2 == 0)
                    {
                        lstPares.Items.Add(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite valores válidos.");
            }
        }
    }
}