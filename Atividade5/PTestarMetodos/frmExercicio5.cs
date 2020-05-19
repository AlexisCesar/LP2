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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int n = rd.Next(Convert.ToInt32(txtN1.Text), Convert.ToInt32(txtN2.Text));
            MessageBox.Show("Número gerado: " + n);
        }
    }
}
