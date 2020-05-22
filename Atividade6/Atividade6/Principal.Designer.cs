namespace Atividade6
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnE1 = new System.Windows.Forms.Button();
            this.btnE2 = new System.Windows.Forms.Button();
            this.btnE3 = new System.Windows.Forms.Button();
            this.btnE4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnE1
            // 
            this.btnE1.Location = new System.Drawing.Point(12, 54);
            this.btnE1.Name = "btnE1";
            this.btnE1.Size = new System.Drawing.Size(121, 55);
            this.btnE1.TabIndex = 0;
            this.btnE1.Text = "Exercicio 1";
            this.btnE1.UseVisualStyleBackColor = true;
            this.btnE1.Click += new System.EventHandler(this.btnE1_Click);
            // 
            // btnE2
            // 
            this.btnE2.Location = new System.Drawing.Point(139, 54);
            this.btnE2.Name = "btnE2";
            this.btnE2.Size = new System.Drawing.Size(121, 55);
            this.btnE2.TabIndex = 1;
            this.btnE2.Text = "Exercicio 2";
            this.btnE2.UseVisualStyleBackColor = true;
            this.btnE2.Click += new System.EventHandler(this.btnE2_Click);
            // 
            // btnE3
            // 
            this.btnE3.Location = new System.Drawing.Point(266, 54);
            this.btnE3.Name = "btnE3";
            this.btnE3.Size = new System.Drawing.Size(121, 55);
            this.btnE3.TabIndex = 3;
            this.btnE3.Text = "Exercicio 3";
            this.btnE3.UseVisualStyleBackColor = true;
            this.btnE3.Click += new System.EventHandler(this.btnE3_Click);
            // 
            // btnE4
            // 
            this.btnE4.Location = new System.Drawing.Point(393, 54);
            this.btnE4.Name = "btnE4";
            this.btnE4.Size = new System.Drawing.Size(121, 55);
            this.btnE4.TabIndex = 2;
            this.btnE4.Text = "Exercicio 4";
            this.btnE4.UseVisualStyleBackColor = true;
            this.btnE4.Click += new System.EventHandler(this.btnE4_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 162);
            this.Controls.Add(this.btnE3);
            this.Controls.Add(this.btnE4);
            this.Controls.Add(this.btnE2);
            this.Controls.Add(this.btnE1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnE1;
        private System.Windows.Forms.Button btnE2;
        private System.Windows.Forms.Button btnE3;
        private System.Windows.Forms.Button btnE4;
    }
}

