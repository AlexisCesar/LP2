using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade7
{
    public partial class FormE7 : Form
    {
        public FormE7()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            Int64 RA, N;
            int i, contador;
            ArrayList nomes = new ArrayList();
            string nome;

            //PEGA RA
            while(true)
                if(Int64.TryParse(Interaction.InputBox("INSIRA SEU RA"), out RA))
                {
                    break;
                }

            //ULTIMO DIGITO
            N = RA % 10;
            if (N == 0)
                N = 10;

            for(i=0; i<N; i++)
            {
                nome = Interaction.InputBox("INSIRA O " + (i+1) +"° NOME:");
                nomes.Add(nome);
            }

            foreach(string x in nomes)
            {
                contador = 0;
                foreach (char c in x)
                    if (!Char.IsWhiteSpace(c))
                        contador++;
                txtNomes.Text = txtNomes.Text + "\n" + "O nome " + x + " tem " + contador + " caracteres";
            }
        }
    }
}
