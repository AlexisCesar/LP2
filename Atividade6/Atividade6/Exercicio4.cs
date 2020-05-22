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
    public partial class Exercicio4 : Form
    {
        public Exercicio4()
        {
            InitializeComponent();
        }

        private void Exercicio4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double A, salarioBruto, gratificacao, producao;
            int B, C, D;

            A = int.Parse(txtSalario.Text);
            gratificacao = double.Parse(txtGratificacao.Text);
            producao = double.Parse(txtProducao.Text);

            B = producao >= 100 ? 1 : 0;
            C = producao >= 120 ? 1 : 0;
            D = producao >= 150 ? 1 : 0;

            salarioBruto = A + A * (0.05*B+0.1*C+0.1*D) + gratificacao;

            salarioBruto = producao >= 150 && gratificacao > 0 ? salarioBruto : salarioBruto > 7000 ? 7000 : salarioBruto;

            MessageBox.Show("Salário bruto: R$" + salarioBruto);

        }
    }
}
