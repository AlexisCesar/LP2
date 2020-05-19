namespace PTestarMetodos
{
    partial class frmExercicio4
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
            this.rtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnNumerico = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnAlfabeticos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.Location = new System.Drawing.Point(12, 12);
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.Size = new System.Drawing.Size(542, 236);
            this.rtxtTexto.TabIndex = 0;
            this.rtxtTexto.Text = "";
            // 
            // btnNumerico
            // 
            this.btnNumerico.Location = new System.Drawing.Point(12, 294);
            this.btnNumerico.Name = "btnNumerico";
            this.btnNumerico.Size = new System.Drawing.Size(153, 57);
            this.btnNumerico.TabIndex = 1;
            this.btnNumerico.Text = "Caractéres Numéricos";
            this.btnNumerico.UseVisualStyleBackColor = true;
            this.btnNumerico.Click += new System.EventHandler(this.btnNumerico_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(206, 294);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(153, 57);
            this.btnBranco.TabIndex = 2;
            this.btnBranco.Text = "Espaço em Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnAlfabeticos
            // 
            this.btnAlfabeticos.Location = new System.Drawing.Point(401, 294);
            this.btnAlfabeticos.Name = "btnAlfabeticos";
            this.btnAlfabeticos.Size = new System.Drawing.Size(153, 57);
            this.btnAlfabeticos.TabIndex = 3;
            this.btnAlfabeticos.Text = "Caracteres Alfabéticos";
            this.btnAlfabeticos.UseVisualStyleBackColor = true;
            this.btnAlfabeticos.Click += new System.EventHandler(this.btnAlfabeticos_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 394);
            this.Controls.Add(this.btnAlfabeticos);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNumerico);
            this.Controls.Add(this.rtxtTexto);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtTexto;
        private System.Windows.Forms.Button btnNumerico;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnAlfabeticos;
    }
}