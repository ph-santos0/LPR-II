namespace Atividade_1___Forms
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
            this.InsiraValorA = new System.Windows.Forms.Label();
            this.ValorA = new System.Windows.Forms.TextBox();
            this.ValorB = new System.Windows.Forms.TextBox();
            this.InsiraValorB = new System.Windows.Forms.Label();
            this.Soma = new System.Windows.Forms.Button();
            this.Subtracao = new System.Windows.Forms.Button();
            this.Multiplicacao = new System.Windows.Forms.Button();
            this.Divisao = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InsiraValorA
            // 
            this.InsiraValorA.AutoSize = true;
            this.InsiraValorA.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsiraValorA.Location = new System.Drawing.Point(31, 32);
            this.InsiraValorA.Name = "InsiraValorA";
            this.InsiraValorA.Size = new System.Drawing.Size(231, 22);
            this.InsiraValorA.TabIndex = 0;
            this.InsiraValorA.Text = "Insira o primeiro número:";
            this.InsiraValorA.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ValorA
            // 
            this.ValorA.Location = new System.Drawing.Point(279, 36);
            this.ValorA.Name = "ValorA";
            this.ValorA.Size = new System.Drawing.Size(41, 20);
            this.ValorA.TabIndex = 1;
            this.ValorA.TextChanged += new System.EventHandler(this.ValorA_TextChanged);
            // 
            // ValorB
            // 
            this.ValorB.Location = new System.Drawing.Point(279, 67);
            this.ValorB.Name = "ValorB";
            this.ValorB.Size = new System.Drawing.Size(41, 20);
            this.ValorB.TabIndex = 3;
            this.ValorB.TextChanged += new System.EventHandler(this.ValorB_TextChanged);
            // 
            // InsiraValorB
            // 
            this.InsiraValorB.AutoSize = true;
            this.InsiraValorB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsiraValorB.Location = new System.Drawing.Point(31, 63);
            this.InsiraValorB.Name = "InsiraValorB";
            this.InsiraValorB.Size = new System.Drawing.Size(240, 22);
            this.InsiraValorB.TabIndex = 2;
            this.InsiraValorB.Text = "Insira o segundo número:";
            this.InsiraValorB.Click += new System.EventHandler(this.InsiraValorB_Click);
            // 
            // Soma
            // 
            this.Soma.Location = new System.Drawing.Point(35, 108);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(83, 23);
            this.Soma.TabIndex = 4;
            this.Soma.Text = "Soma";
            this.Soma.UseVisualStyleBackColor = true;
            this.Soma.Click += new System.EventHandler(this.Soma_Click);
            // 
            // Subtracao
            // 
            this.Subtracao.Location = new System.Drawing.Point(35, 137);
            this.Subtracao.Name = "Subtracao";
            this.Subtracao.Size = new System.Drawing.Size(83, 23);
            this.Subtracao.TabIndex = 5;
            this.Subtracao.Text = "Subtração";
            this.Subtracao.UseVisualStyleBackColor = true;
            this.Subtracao.Click += new System.EventHandler(this.Subtracao_Click);
            // 
            // Multiplicacao
            // 
            this.Multiplicacao.Location = new System.Drawing.Point(35, 166);
            this.Multiplicacao.Name = "Multiplicacao";
            this.Multiplicacao.Size = new System.Drawing.Size(83, 23);
            this.Multiplicacao.TabIndex = 6;
            this.Multiplicacao.Text = "Multiplicação";
            this.Multiplicacao.UseVisualStyleBackColor = true;
            this.Multiplicacao.Click += new System.EventHandler(this.Multiplicacao_Click);
            // 
            // Divisao
            // 
            this.Divisao.Location = new System.Drawing.Point(35, 195);
            this.Divisao.Name = "Divisao";
            this.Divisao.Size = new System.Drawing.Size(83, 23);
            this.Divisao.TabIndex = 7;
            this.Divisao.Text = "Divisão";
            this.Divisao.UseVisualStyleBackColor = true;
            this.Divisao.Click += new System.EventHandler(this.Divisao_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(145, 137);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(117, 24);
            this.Resultado.TabIndex = 8;
            this.Resultado.Text = "Resultado:";
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 256);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Divisao);
            this.Controls.Add(this.Multiplicacao);
            this.Controls.Add(this.Subtracao);
            this.Controls.Add(this.Soma);
            this.Controls.Add(this.ValorB);
            this.Controls.Add(this.InsiraValorB);
            this.Controls.Add(this.ValorA);
            this.Controls.Add(this.InsiraValorA);
            this.Name = "Form1";
            this.Text = "Operações Básicas de Matemática";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InsiraValorA;
        private System.Windows.Forms.TextBox ValorA;
        private System.Windows.Forms.TextBox ValorB;
        private System.Windows.Forms.Label InsiraValorB;
        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button Subtracao;
        private System.Windows.Forms.Button Multiplicacao;
        private System.Windows.Forms.Button Divisao;
        private System.Windows.Forms.Label Resultado;
    }
}

