namespace Atividade6
{
    partial class Exercicio1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFrase = new System.Windows.Forms.RichTextBox();
            this.btnEspacos = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnPares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(12, 12);
            this.txtFrase.MaxLength = 100;
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(776, 235);
            this.txtFrase.TabIndex = 0;
            this.txtFrase.Text = "";
            // 
            // btnEspacos
            // 
            this.btnEspacos.Location = new System.Drawing.Point(12, 300);
            this.btnEspacos.Name = "btnEspacos";
            this.btnEspacos.Size = new System.Drawing.Size(133, 79);
            this.btnEspacos.TabIndex = 1;
            this.btnEspacos.Text = "Espaços em Branco";
            this.btnEspacos.UseVisualStyleBackColor = true;
            this.btnEspacos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(338, 300);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(133, 79);
            this.btnR.TabIndex = 2;
            this.btnR.Text = "Quantidade de \'R\'";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnPares
            // 
            this.btnPares.Location = new System.Drawing.Point(655, 300);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(133, 79);
            this.btnPares.TabIndex = 3;
            this.btnPares.Text = "Quantidade de Pares de Letras";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // Exercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnEspacos);
            this.Controls.Add(this.txtFrase);
            this.Name = "Exercicio1";
            this.Text = "Exercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtFrase;
        private System.Windows.Forms.Button btnEspacos;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnPares;
    }
}