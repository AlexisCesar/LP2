using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A, B, C;
            double first, second, third;
            if (Double.TryParse(txtA.Text, out A) && Double.TryParse(txtB.Text, out B) && Double.TryParse(txtC.Text, out C))
            {
                //A as first
                if (A > B && A > C)
                {
                    first = A;
                    if (B > C)
                    {
                        second = B;
                        third = C;
                    }
                    else
                    {
                        second = C;
                        third = B;
                    }
                }
                //B as first
                else if (B > A && B > C)
                {
                    first = B;
                    if (A > C)
                    {
                        second = A;
                        third = C;
                    }
                    else
                    {
                        second = C;
                        third = A;
                    }
                }
                //C as first if(C > B && C > A)
                else
                {
                    first = C;
                    if (A > B)
                    {
                        second = A;
                        third = B;
                    }
                    else
                    {
                        second = B;
                        third = A;
                    }
                }
                /*******************************/

                if (first >= (second + third))
                {
                    lblTipo.Text = ("NAO FORMA TRIANGULO");
                }
                else if (first == second && first == third)
                {
                    lblTipo.Text = ("TRIANGULO EQUILATERO");
                }
                else if (first == second || first == third || second == third)
                {
                    lblTipo.Text = ("TRIANGULO ISOSCELES");
                }
                else
                {
                    lblTipo.Text = ("TRIANGULO ESCALENO");
                }
                //limpaCampos();
            }
            else
            {
                MessageBox.Show("Dados inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpaCampos();
            }
        }

        private void limpaCampos()
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
        }
    }
}
