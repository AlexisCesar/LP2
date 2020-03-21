using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPeso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
                double altura, peso, ideal;
                if(Double.TryParse(txtAltura.Text, out altura) && Double.TryParse(txtPeso.Text, out peso))
                {
                    if (rbMasc.Checked)
                        ideal = (72.7 * altura) - 58;
                    else
                        ideal = (62.1 * altura) - 44.7;

                lblPesoIdeal.Text = ideal.ToString();
                ideal = Double.Parse(lblPesoIdeal.Text);
                    if(peso > ideal)
                    lblResultado.Text = "Vá comer salada. AGORA!";
                    else if(peso == ideal)
                    lblResultado.Text = "Tá com o peso ideal!";
                    else
                    lblResultado.Text = "Pizzas! Coma pizzas!";

            }
                else
                {
                    MessageBox.Show("Verifique os dados inseridos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
