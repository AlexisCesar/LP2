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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnIguais_Click(object sender, EventArgs e)
        {
            int pos = 0;
            txtPalavra1.Text = txtPalavra1.Text.ToUpper();
            txtPalavra2.Text = txtPalavra2.Text.ToUpper();

            pos = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            while(pos >= 0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, pos) + txtPalavra2.Text.Substring(pos + txtPalavra1.Text.Length, txtPalavra2.Text.Length - pos - txtPalavra1.Text.Length);

                pos = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void txtReplace_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void txtInverte_Click(object sender, EventArgs e)
        {
            string txt = txtPalavra1.Text;
            char[] arr = txt.ToCharArray();
            Array.Reverse(arr);

            txt = "";
            foreach (char ch in arr)
                txt += ch;
            txtPalavra2.Text = txt;
        }
    }
}
