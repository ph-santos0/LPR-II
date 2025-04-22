namespace Atividade_2___Forms
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
            this.LabelPrimeiraNota = new System.Windows.Forms.Label();
            this.LabelSegundaNota = new System.Windows.Forms.Label();
            this.LabelTerceiraNota = new System.Windows.Forms.Label();
            this.PrimeiraNota = new System.Windows.Forms.TextBox();
            this.SegundaNota = new System.Windows.Forms.TextBox();
            this.TerceiraNota = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelPrimeiraNota
            // 
            this.LabelPrimeiraNota.AutoSize = true;
            this.LabelPrimeiraNota.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrimeiraNota.Location = new System.Drawing.Point(53, 53);
            this.LabelPrimeiraNota.Name = "LabelPrimeiraNota";
            this.LabelPrimeiraNota.Size = new System.Drawing.Size(212, 22);
            this.LabelPrimeiraNota.TabIndex = 0;
            this.LabelPrimeiraNota.Text = "Digite a primeira nota:";
            // 
            // LabelSegundaNota
            // 
            this.LabelSegundaNota.AutoSize = true;
            this.LabelSegundaNota.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSegundaNota.Location = new System.Drawing.Point(53, 88);
            this.LabelSegundaNota.Name = "LabelSegundaNota";
            this.LabelSegundaNota.Size = new System.Drawing.Size(221, 22);
            this.LabelSegundaNota.TabIndex = 1;
            this.LabelSegundaNota.Text = "Digite a segunda nota:";
            // 
            // LabelTerceiraNota
            // 
            this.LabelTerceiraNota.AutoSize = true;
            this.LabelTerceiraNota.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTerceiraNota.Location = new System.Drawing.Point(53, 123);
            this.LabelTerceiraNota.Name = "LabelTerceiraNota";
            this.LabelTerceiraNota.Size = new System.Drawing.Size(210, 22);
            this.LabelTerceiraNota.TabIndex = 2;
            this.LabelTerceiraNota.Text = "Digite a terceira nota:";
            // 
            // PrimeiraNota
            // 
            this.PrimeiraNota.Location = new System.Drawing.Point(281, 57);
            this.PrimeiraNota.Name = "PrimeiraNota";
            this.PrimeiraNota.Size = new System.Drawing.Size(64, 20);
            this.PrimeiraNota.TabIndex = 3;
            this.PrimeiraNota.TextChanged += new System.EventHandler(this.PrimeiraNota_TextChanged);
            // 
            // SegundaNota
            // 
            this.SegundaNota.Location = new System.Drawing.Point(281, 92);
            this.SegundaNota.Name = "SegundaNota";
            this.SegundaNota.Size = new System.Drawing.Size(64, 20);
            this.SegundaNota.TabIndex = 4;
            this.SegundaNota.TextChanged += new System.EventHandler(this.SegundaNota_TextChanged);
            // 
            // TerceiraNota
            // 
            this.TerceiraNota.Location = new System.Drawing.Point(281, 127);
            this.TerceiraNota.Name = "TerceiraNota";
            this.TerceiraNota.Size = new System.Drawing.Size(64, 20);
            this.TerceiraNota.TabIndex = 5;
            this.TerceiraNota.TextChanged += new System.EventHandler(this.TerceiraNota_TextChanged);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(147, 172);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(106, 23);
            this.Calcular.TabIndex = 6;
            this.Calcular.Text = "Calcular Média";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Média: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.TerceiraNota);
            this.Controls.Add(this.SegundaNota);
            this.Controls.Add(this.PrimeiraNota);
            this.Controls.Add(this.LabelTerceiraNota);
            this.Controls.Add(this.LabelSegundaNota);
            this.Controls.Add(this.LabelPrimeiraNota);
            this.Name = "Form1";
            this.Text = "Média de Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPrimeiraNota;
        private System.Windows.Forms.Label LabelSegundaNota;
        private System.Windows.Forms.Label LabelTerceiraNota;
        private System.Windows.Forms.TextBox PrimeiraNota;
        private System.Windows.Forms.TextBox SegundaNota;
        private System.Windows.Forms.TextBox TerceiraNota;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label1;
    }
}

