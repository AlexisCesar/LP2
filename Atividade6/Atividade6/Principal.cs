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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            Exercicio1 frm = new Exercicio1();
            //frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            Exercicio2 frm = new Exercicio2();
            //frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            Exercicio3 frm = new Exercicio3();
            //frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            Exercicio4 frm = new Exercicio4();
            //frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
