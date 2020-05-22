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
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int cont = 0;

            for(i=0; i < txtFrase.Text.Length; i++)
            {
                if(Char.IsWhiteSpace(txtFrase.Text[i]))
                    cont++;
            }
            MessageBox.Show("Quantidade de espaços em branco: " + cont);
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int i;
            int cont = 0;

            for (i = 0; i < txtFrase.Text.Length; i++)
            {
                if (txtFrase.Text[i].Equals('r') | txtFrase.Text[i].Equals('R'))
                    cont++;
            }
            MessageBox.Show("Quantidade de R's: " + cont);
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            int i;
            int cont = 0;

            for (i = 1; i < txtFrase.Text.Length; i++)
            {
                if (txtFrase.Text[i] == txtFrase.Text[i-1])
                    cont++;
            }
            MessageBox.Show("Quantidade de pares: " + cont);
        }
    }
}
