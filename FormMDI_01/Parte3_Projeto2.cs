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
        private List<int> array1 = new List<int>();
        private List<int> array2 = new List<int>();
        public Parte3_Projeto2()
        {
            InitializeComponent();
        }

        private void btnAddArray1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtArray1.Text, out int numero))
            {
                array1.Add(numero);
                lstArray1.Items.Add(numero);
                txtArray1.Clear();
                txtArray1.Focus();
            }
            else
            {
                MessageBox.Show("Digite um número válido para o Array 1.");
            }
        }

        private void btnAddArray2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtArray2.Text, out int numero))
            {
                array2.Add(numero);
                lstArray2.Items.Add(numero);
                txtArray2.Clear();
                txtArray2.Focus();
            }
            else
            {
                MessageBox.Show("Digite um número válido para o Array 2.");
            }
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            List<int> repetidos = Utilitarios.NumerosRepetidos(array1, array2);

            if (repetidos.Count > 0)
            {
                MessageBox.Show("Números repetidos:\n" + string.Join(", ", repetidos), "Resultado");
            }
            else
            {
                MessageBox.Show("Nenhum número se repete entre os arrays.", "Resultado");
            }
        }
    }
}