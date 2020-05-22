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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int i;
            char[] vetorFrase;
            char[] vetorInverso;
            string txt = "";
            string txtInverso = "";

            for(i=0; i<txtFrase.Text.Length; i++)
            {
                if (!Char.IsWhiteSpace(txtFrase.Text[i]))
                {
                    txt += Char.ToUpper(txtFrase.Text[i]);
                }
            }
            vetorFrase = txt.ToCharArray();
            vetorInverso = txt.ToCharArray();
            Array.Reverse(vetorInverso);
            txt = "";

            foreach (char c in vetorInverso)
                txtInverso += c;
            foreach (char c in vetorFrase)
                txt += c;

            if (txt.Equals(txtInverso))
                MessageBox.Show("Palavra digitada: " + txt + "\n\nInverso: " + txtInverso + "\n\nÉ palíndromo.");
            else
                MessageBox.Show("Palavra digitada: " + txt + "\n\nInverso: " + txtInverso + "\n\nNão é palíndromo.");
        }
    }
}
