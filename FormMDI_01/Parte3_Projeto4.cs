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
    public partial class Parte3_Projeto4 : Form
    {
        public Parte3_Projeto4()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAno.Text, out int ano))
            {
                bool bissexto = Utilitarios.EhAnoBissexto(ano);
                string mensagem = bissexto ? "O ano é bissexto." : "O ano NÃO é bissexto.";
                MessageBox.Show(mensagem, "Resultado");
            }
            else
            {
                MessageBox.Show("Digite um ano válido.", "Erro");
            }
        }
    }
}