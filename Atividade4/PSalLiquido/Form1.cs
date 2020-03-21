using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalLiquido
{
    public partial class Form1 : Form
    {

        private double aliqINSS, aliqIRPF, salFamilia, salBruto, salLiq,
                       descINSS, descIRPF;
        private int nFilhos;
        private string nomeFunc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificaDesc_Click(object sender, EventArgs e)
        {
            if ( 
                (txtNomeFunc.Text != null && txtNomeFunc.Text != "") &&
                Double.TryParse(txtSalBruto.Text, out salBruto) &&
                int.TryParse(txtNumFilhos.Text, out nFilhos)
               )
            {
                if(chkCasado.Checked)
                {
                    if(rbFem.Checked)
                    {
                        lblDados.Text = "Os descontos do salário da Sra. " + txtNomeFunc.Text
                        + "\nQue é casada"
                        + "\nE tem " + nFilhos + " filho(s) são:";
                    }
                    else
                    {
                        lblDados.Text = "Os descontos do salário do Sr. " + txtNomeFunc.Text
                        + "\nQue é casado"
                        + "\nE tem " + nFilhos + " filho(s) são:";
                    }
                }
                else
                {
                    if (rbFem.Checked)
                    {
                        lblDados.Text = "Os descontos do salário da Sra. " + txtNomeFunc.Text
                        + "\nQue é solteira"
                        + "\nE tem " + nFilhos + " filho(s) são:";
                    }
                    else
                    {
                        lblDados.Text = "Os descontos do salário do Sr. " + txtNomeFunc.Text
                        + "\nQue é solteiro"
                        + "\nE tem " + nFilhos + " filho(s) são:";
                    }
                }
                //ALIQUOTA INSS:
                if (salBruto <= 800.47)
                    aliqINSS = 7.65D;
                else if (salBruto <= 1050)
                    aliqINSS = 8.65D;
                else if (salBruto <= 1400.77)
                    aliqINSS = 9.00D;
                else if (salBruto <= 2801.54)
                    aliqINSS = 11.00D;
                else
                    aliqINSS = 0D;

                if(aliqINSS == 0)
                {
                    txtAliqINSS.Text = "TETO";
                    descINSS = 308.17;
                    txtDescINSS.Text = descINSS.ToString("N2");
                }
                else
                {
                    descINSS = (aliqINSS / 100) * salBruto;
                    txtAliqINSS.Text = aliqINSS + "%";
                    txtDescINSS.Text = descINSS.ToString("N2");
                }

                //ALIQUOTA IRPF:
                if (salBruto <= 1257.12)
                {
                    txtAliqIRPF.Text = "ISENTO";
                    txtDescIRPF.Text = "0.00";
                    descIRPF = 0;
                }
                else if (salBruto <= 2512.08)
                {
                    aliqIRPF = 15;
                    txtAliqIRPF.Text = aliqIRPF + "%";
                    descIRPF = salBruto * (aliqIRPF / 100);
                    txtDescIRPF.Text = descIRPF.ToString("N2");
                }
                else
                {
                    aliqIRPF = 27.5;
                    txtAliqIRPF.Text = aliqIRPF + "%";
                    descIRPF = salBruto * (aliqIRPF / 100);
                    txtDescIRPF.Text = descIRPF.ToString("N2");
                }

                //SALARIO FAMILIA:
                if(salBruto <= 435.52)
                {
                    salFamilia = 22.33 * nFilhos;
                    txtSalFamilia.Text = salFamilia.ToString("N2");
                }
                else if(salBruto <= 654.61)
                {
                    salFamilia = 15.74 * nFilhos;
                    txtSalFamilia.Text = salFamilia.ToString("N2");
                }
                else
                {
                    salFamilia = 0;
                    txtSalFamilia.Text = salFamilia.ToString("N2");
                }

                //SALARIO LIQUIDO:
                salLiq = salBruto - descINSS - descIRPF + salFamilia;
                txtSalLiquido.Text = salLiq.ToString("N2");
            }
            else
            {
                MessageBox.Show("Não foi possível ler todos os dados.\nPor favor verifique-os.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
