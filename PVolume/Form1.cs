using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        double R, H, V;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRaio_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtRaio.Text, out R) && double.TryParse(txtAltura.Text, out H))
            {
                V = Math.PI * Math.Pow(R, 2) * H;
                txtVolume.Text = V.ToString("N2");
            }
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtRaio.Text, out R) && double.TryParse(txtAltura.Text, out H))
            {
                V = Math.PI * Math.Pow(R, 2) * H;
                txtVolume.Text = V.ToString("N2");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtRaio.Text = "";
            txtVolume.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
        }
    }
}
