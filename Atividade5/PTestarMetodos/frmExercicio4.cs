using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTestarMetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNumerico_Click(object sender, EventArgs e)
        {
            int contador = 0;

            for(var x = 0; x<rtxtTexto.Text.Length; x++)
            {
                if (Char.IsNumber(rtxtTexto.Text[x]))
                    contador++;
            }

            MessageBox.Show("Há " + contador + " caracteres numéricos.");
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int x = 0;

            while(x < rtxtTexto.Text.Length)
            {
                if(Char.IsWhiteSpace(rtxtTexto.Text[x]))
                {
                    MessageBox.Show("Espaço em branco na posição: " + (x+1));
                    break;
                }
                x++;
            }
        }

        private void btnAlfabeticos_Click(object sender, EventArgs e)
        {
            int contador = 0;

            foreach(char ch in rtxtTexto.Text)
            {
                if (Char.IsLetter(ch))
                    contador++;
            }

            MessageBox.Show("Há " + contador + " caracteres alfabéticos.");
        }
    }
}
