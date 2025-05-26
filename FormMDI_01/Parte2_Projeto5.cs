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
    public partial class Parte2_Projeto5 : Form
    {
        public Parte2_Projeto5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime data1 = dtpData1.Value.Date;
            DateTime data2 = dtpData2.Value.Date;

            int diferenca = Utilitarios.DiasEntreDatas(data1, data2);
            MessageBox.Show($"A diferença entre as datas é de {diferenca} dias.", "Resultado");
        }
    }
}