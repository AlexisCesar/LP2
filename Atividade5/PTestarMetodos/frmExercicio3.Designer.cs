namespace PTestarMetodos
{
    partial class frmExercicio3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInverte = new System.Windows.Forms.Button();
            this.txtReplace = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Palavra 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Palavra 1";
            // 
            // txtInverte
            // 
            this.txtInverte.Location = new System.Drawing.Point(241, 169);
            this.txtInverte.Name = "txtInverte";
            this.txtInverte.Size = new System.Drawing.Size(75, 47);
            this.txtInverte.TabIndex = 11;
            this.txtInverte.Text = "Inverte (Replace)";
            this.txtInverte.UseVisualStyleBackColor = true;
            this.txtInverte.Click += new System.EventHandler(this.txtInverte_Click);
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(148, 169);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(75, 47);
            this.txtReplace.TabIndex = 10;
            this.txtReplace.Text = "Remove Ocorrências (Replace)";
            this.txtReplace.UseVisualStyleBackColor = true;
            this.txtReplace.Click += new System.EventHandler(this.txtReplace_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(48, 169);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 47);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove Ocorrências";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnIguais_Click);
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(216, 59);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra2.TabIndex = 8;
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(48, 59);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra1.TabIndex = 7;
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 272);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInverte);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtInverte;
        private System.Windows.Forms.Button txtReplace;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
    }
}