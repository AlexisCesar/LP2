using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            double H, N;
            int i;
           if(Double.TryParse(txtNum.Text, out N))
            {
                H = 1;
                for(i=2; i<=N; i++)
                {
                    H += (1.0 / i);
                }

                MessageBox.Show("Numero gerado: " + H);
            }
           else
            {
                MessageBox.Show("Digite um número válido.");
            }

        }
    }
}
