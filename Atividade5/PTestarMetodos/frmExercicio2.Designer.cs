namespace PTestarMetodos
{
    partial class frmExercicio2
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
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnIguais = new System.Windows.Forms.Button();
            this.txtInserir = new System.Windows.Forms.Button();
            this.txtAsteriscos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(45, 92);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra1.TabIndex = 0;
            this.txtPalavra1.TextChanged += new System.EventHandler(this.txtPalavra1_TextChanged);
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(213, 92);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra2.TabIndex = 1;
            // 
            // btnIguais
            // 
            this.btnIguais.Location = new System.Drawing.Point(45, 202);
            this.btnIguais.Name = "btnIguais";
            this.btnIguais.Size = new System.Drawing.Size(75, 35);
            this.btnIguais.TabIndex = 2;
            this.btnIguais.Text = "Testar Iguais";
            this.btnIguais.UseVisualStyleBackColor = true;
            this.btnIguais.Click += new System.EventHandler(this.btnIguais_Click);
            // 
            // txtInserir
            // 
            this.txtInserir.Location = new System.Drawing.Point(145, 202);
            this.txtInserir.Name = "txtInserir";
            this.txtInserir.Size = new System.Drawing.Size(75, 35);
            this.txtInserir.TabIndex = 3;
            this.txtInserir.Text = "Texto1 no Texto2";
            this.txtInserir.UseVisualStyleBackColor = true;
            this.txtInserir.Click += new System.EventHandler(this.txtInserir_Click);
            // 
            // txtAsteriscos
            // 
            this.txtAsteriscos.Location = new System.Drawing.Point(238, 202);
            this.txtAsteriscos.Name = "txtAsteriscos";
            this.txtAsteriscos.Size = new System.Drawing.Size(75, 35);
            this.txtAsteriscos.TabIndex = 4;
            this.txtAsteriscos.Text = "Inserir astericos";
            this.txtAsteriscos.UseVisualStyleBackColor = true;
            this.txtAsteriscos.Click += new System.EventHandler(this.txtAsteriscos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Palavra 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Palavra 2";
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 276);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAsteriscos);
            this.Controls.Add(this.txtInserir);
            this.Controls.Add(this.btnIguais);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnIguais;
        private System.Windows.Forms.Button txtInserir;
        private System.Windows.Forms.Button txtAsteriscos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}