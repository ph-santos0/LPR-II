namespace Lista_1___Forms
{
    partial class FormAtividade7
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
            this.Raio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Raio
            // 
            this.Raio.Location = new System.Drawing.Point(154, 153);
            this.Raio.Name = "Raio";
            this.Raio.Size = new System.Drawing.Size(38, 20);
            this.Raio.TabIndex = 20;
            this.Raio.TextChanged += new System.EventHandler(this.Raio_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Raio:";
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(200, 256);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(88, 23);
            this.Calcular.TabIndex = 16;
            this.Calcular.Text = "Calcular Área";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(89, 321);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(15, 22);
            this.Resultado.TabIndex = 15;
            this.Resultado.Text = " ";
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Calculo da área da circunferência.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 152);
            this.label1.TabIndex = 13;
            this.label1.Text = "◯";
            // 
            // FormAtividade7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 414);
            this.Controls.Add(this.Raio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAtividade7";
            this.Text = "Atividade 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Raio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}