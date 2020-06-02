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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            //Form frm1 = Application.OpenForms["frmE1"];
            //if (frm1 != null)
            //    frm1.Close();
            //frmE1 frm = new frmE1();
            //frm.Show();

            int[] vetor = new int[20];
            int x = 0;
            string auxiliar = "";
            string valor = "";

            for(x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite o dado", "Entrada de dados ("+ (x+1) +"° valor)");

                if (int.TryParse(valor, out vetor[x]))
                    auxiliar = vetor[x].ToString() + "\n" + auxiliar;
                else
                {
                    MessageBox.Show("Número inválido!");
                    x--;
                }
            }

            MessageBox.Show(auxiliar);

        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            int x = 0;
            string auxiliar = "";
            string valor = "";

            for (x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite o dado", "Entrada de dados (" + (x + 1) + "° valor)");

                if (!int.TryParse(valor, out vetor[x])) {
                    MessageBox.Show("Número inválido!");
                    x--;
                }

            }

            Array.Reverse(vetor);

            foreach (int n in vetor)
                auxiliar += n + "\n";

            MessageBox.Show(auxiliar);
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            double[] vetor = new double[10];
            double[] vetorPreco = new double[10];
            int x, y;
            double faturamento = 0;
            string auxiliar = "";
            string valor = "";

            for (x = 0; x < 10; x++)
            {
                valor = Interaction.InputBox("Quantidade vendida", "Mercadoria (" + (x + 1) + ")");
                if (!double.TryParse(valor, out vetor[x]))
                {
                    MessageBox.Show("Número inválido!");
                    x--;
                    continue;
                }
                valor = Interaction.InputBox("Valor da mercadoria", "Mercadoria (" + (x + 1) + ")");
                while (!double.TryParse(valor, out vetorPreco[x]))
                {
                    MessageBox.Show("Número inválido!");
                    valor = Interaction.InputBox("Valor da mercadoria", "Mercadoria (" + (x + 1) + ")");
                }

            }

            for(x = 0; x < 10; x++)
            {
                faturamento += vetor[x] * vetorPreco[x];
            }

            MessageBox.Show("Faturamento mensal: " + faturamento.ToString());
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            string[] Alunos = {"Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo",
                "Jose", "Nelma", "Tobby"};

            int i, total = 0;
            int n = Alunos.Length;

            for (i = 0; i < n - 1; i++)
                total += Alunos[i].Length;
            MessageBox.Show(total.ToString());
        }

        private void btnE5_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList();
            alunos.Add("Ana"); 
            alunos.Add("André"); 
            alunos.Add("Débora"); 
            alunos.Add("Fátima"); 
            alunos.Add("João"); 
            alunos.Add("Janete"); 
            alunos.Add("Otávio"); 
            alunos.Add("Marcelo"); 
            alunos.Add("Pedro"); 
            alunos.Add("Thais");

            alunos.Remove("Otávio");
            string nomes = "";
            foreach (string nome in alunos)
                nomes += nome + "\n";
            MessageBox.Show(nomes);
            
        }

        private void btnE6_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];
            int i, j;
            string nota, impressao = "";
            double media = 0;

            //PEGA AS NOTAS
            for(i=0; i<notas.GetLength(0); i++)
            {
                for(j=0; j<notas.GetLength(1); j++)
                {
                    nota = Interaction.InputBox("INSIRA A NOTA", "ALUNO: " + (i+1) + ". NOTA ("+ (j+1) +"/3): ");
                    if (!double.TryParse(nota, out notas[i, j]))
                    {
                        MessageBox.Show("Número inválido!");
                        j--;
                        continue;
                    }
                }
            }

            //PRINTA MÉDIAS DE CADA ALUNO
            for(i=0; i<notas.GetLength(0); i++)
            {
                media = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;
                impressao += "Aluno " + (i + 1) + ": média: " + media.ToString("N2") + "\n";
            }

            MessageBox.Show(impressao);
        }

        private void btnE7_Click(object sender, EventArgs e)
        {
            FormE7 frm = new FormE7();
            frm.Show();
        }
    }
}
