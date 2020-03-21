namespace PSalLiquido
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumFilhos = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerificaDesc = new System.Windows.Forms.Button();
            this.lblDados = new System.Windows.Forms.Label();
            this.txtAliqINSS = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAliqIRPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalFamilia = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalLiquido = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.chkCasado = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome funcionário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(108, 17);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(100, 20);
            this.txtNomeFunc.TabIndex = 1;
            this.txtNomeFunc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtSalBruto
            // 
            this.txtSalBruto.Location = new System.Drawing.Point(108, 43);
            this.txtSalBruto.Mask = "00000.00";
            this.txtSalBruto.Name = "txtSalBruto";
            this.txtSalBruto.Size = new System.Drawing.Size(100, 20);
            this.txtSalBruto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salário bruto";
            // 
            // txtNumFilhos
            // 
            this.txtNumFilhos.Location = new System.Drawing.Point(108, 69);
            this.txtNumFilhos.Mask = "000";
            this.txtNumFilhos.Name = "txtNumFilhos";
            this.txtNumFilhos.Size = new System.Drawing.Size(100, 20);
            this.txtNumFilhos.TabIndex = 5;
            this.txtNumFilhos.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número de filhos";
            // 
            // btnVerificaDesc
            // 
            this.btnVerificaDesc.Location = new System.Drawing.Point(88, 132);
            this.btnVerificaDesc.Name = "btnVerificaDesc";
            this.btnVerificaDesc.Size = new System.Drawing.Size(146, 28);
            this.btnVerificaDesc.TabIndex = 6;
            this.btnVerificaDesc.Text = "Verifica Desconto";
            this.btnVerificaDesc.UseVisualStyleBackColor = true;
            this.btnVerificaDesc.Click += new System.EventHandler(this.btnVerificaDesc_Click);
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(12, 189);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(0, 13);
            this.lblDados.TabIndex = 7;
            // 
            // txtAliqINSS
            // 
            this.txtAliqINSS.Enabled = false;
            this.txtAliqINSS.Location = new System.Drawing.Point(108, 242);
            this.txtAliqINSS.Name = "txtAliqINSS";
            this.txtAliqINSS.Size = new System.Drawing.Size(100, 20);
            this.txtAliqINSS.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Aliquota INSS";
            // 
            // txtAliqIRPF
            // 
            this.txtAliqIRPF.Enabled = false;
            this.txtAliqIRPF.Location = new System.Drawing.Point(108, 268);
            this.txtAliqIRPF.Name = "txtAliqIRPF";
            this.txtAliqIRPF.Size = new System.Drawing.Size(100, 20);
            this.txtAliqIRPF.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Aliquota IRPF";
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Enabled = false;
            this.txtSalFamilia.Location = new System.Drawing.Point(108, 330);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.Size = new System.Drawing.Size(100, 20);
            this.txtSalFamilia.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Salário Familia";
            // 
            // txtSalLiquido
            // 
            this.txtSalLiquido.Enabled = false;
            this.txtSalLiquido.Location = new System.Drawing.Point(108, 356);
            this.txtSalLiquido.Name = "txtSalLiquido";
            this.txtSalLiquido.Size = new System.Drawing.Size(100, 20);
            this.txtSalLiquido.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Salário Liquido";
            // 
            // txtDescINSS
            // 
            this.txtDescINSS.Enabled = false;
            this.txtDescINSS.Location = new System.Drawing.Point(334, 242);
            this.txtDescINSS.Name = "txtDescINSS";
            this.txtDescINSS.Size = new System.Drawing.Size(100, 20);
            this.txtDescINSS.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Desconto INSS";
            // 
            // txtDescIRPF
            // 
            this.txtDescIRPF.Enabled = false;
            this.txtDescIRPF.Location = new System.Drawing.Point(334, 268);
            this.txtDescIRPF.Name = "txtDescIRPF";
            this.txtDescIRPF.Size = new System.Drawing.Size(100, 20);
            this.txtDescIRPF.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Desconto IRPF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMasc);
            this.groupBox1.Controls.Add(this.rbFem);
            this.groupBox1.Location = new System.Drawing.Point(274, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 77);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Location = new System.Drawing.Point(6, 42);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(34, 17);
            this.rbMasc.TabIndex = 1;
            this.rbMasc.Text = "M";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Checked = true;
            this.rbFem.Location = new System.Drawing.Point(6, 19);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(31, 17);
            this.rbFem.TabIndex = 0;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "F";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // chkCasado
            // 
            this.chkCasado.AutoSize = true;
            this.chkCasado.Location = new System.Drawing.Point(274, 95);
            this.chkCasado.Name = "chkCasado";
            this.chkCasado.Size = new System.Drawing.Size(62, 17);
            this.chkCasado.TabIndex = 21;
            this.chkCasado.Text = "Casado";
            this.chkCasado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 400);
            this.Controls.Add(this.chkCasado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDescIRPF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDescINSS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSalLiquido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSalFamilia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAliqIRPF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAliqINSS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.btnVerificaDesc);
            this.Controls.Add(this.txtNumFilhos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalBruto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtNomeFunc;
        private System.Windows.Forms.MaskedTextBox txtSalBruto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtNumFilhos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerificaDesc;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.MaskedTextBox txtAliqINSS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtAliqIRPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtSalFamilia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtSalLiquido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtDescINSS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtDescIRPF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.CheckBox chkCasado;
    }
}

