namespace WinForm04
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
            this.cb_pagamento = new System.Windows.Forms.ComboBox();
            this.lb_pagamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_res = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_parcela = new System.Windows.Forms.TextBox();
            this.lb_parcela = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_valor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_pagamento
            // 
            this.cb_pagamento.FormattingEnabled = true;
            this.cb_pagamento.Location = new System.Drawing.Point(18, 120);
            this.cb_pagamento.Name = "cb_pagamento";
            this.cb_pagamento.Size = new System.Drawing.Size(145, 24);
            this.cb_pagamento.TabIndex = 0;
            this.cb_pagamento.SelectedIndexChanged += new System.EventHandler(this.cb_pagamento_SelectedIndexChanged);
            // 
            // lb_pagamento
            // 
            this.lb_pagamento.AutoSize = true;
            this.lb_pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pagamento.Location = new System.Drawing.Point(14, 95);
            this.lb_pagamento.Name = "lb_pagamento";
            this.lb_pagamento.Size = new System.Drawing.Size(191, 22);
            this.lb_pagamento.TabIndex = 1;
            this.lb_pagamento.Text = "Formas de Pagamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "O método de Pagamento foi:\r\n";
            // 
            // lb_res
            // 
            this.lb_res.AutoSize = true;
            this.lb_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_res.Location = new System.Drawing.Point(290, 48);
            this.lb_res.Name = "lb_res";
            this.lb_res.Size = new System.Drawing.Size(17, 20);
            this.lb_res.TabIndex = 3;
            this.lb_res.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite o Valor:";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(16, 49);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(145, 22);
            this.txt_valor.TabIndex = 6;
            // 
            // txt_parcela
            // 
            this.txt_parcela.Location = new System.Drawing.Point(329, 122);
            this.txt_parcela.Name = "txt_parcela";
            this.txt_parcela.Size = new System.Drawing.Size(168, 22);
            this.txt_parcela.TabIndex = 8;
            this.txt_parcela.Visible = false;
            this.txt_parcela.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_parcela
            // 
            this.lb_parcela.AutoSize = true;
            this.lb_parcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_parcela.Location = new System.Drawing.Point(329, 95);
            this.lb_parcela.Name = "lb_parcela";
            this.lb_parcela.Size = new System.Drawing.Size(168, 22);
            this.lb_parcela.TabIndex = 7;
            this.lb_parcela.Text = "Quantas Parcelas ?";
            this.lb_parcela.Visible = false;
            this.lb_parcela.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(18, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Valor a pagar:";
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor.Location = new System.Drawing.Point(173, 220);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(56, 25);
            this.lb_valor.TabIndex = 11;
            this.lb_valor.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 307);
            this.Controls.Add(this.lb_valor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_parcela);
            this.Controls.Add(this.lb_parcela);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_res);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_pagamento);
            this.Controls.Add(this.cb_pagamento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_pagamento;
        private System.Windows.Forms.Label lb_pagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_res;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_parcela;
        private System.Windows.Forms.Label lb_parcela;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_valor;
    }
}

