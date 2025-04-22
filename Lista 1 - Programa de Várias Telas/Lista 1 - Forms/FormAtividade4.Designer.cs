namespace Lista_1___Forms
{
    partial class FormAtividade4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Base = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 152);
            this.label1.TabIndex = 0;
            this.label1.Text = "▭";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insira as dimensões do retangulo: ";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(107, 337);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(15, 22);
            this.Resultado.TabIndex = 7;
            this.Resultado.Text = " ";
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(178, 277);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(88, 23);
            this.Calcular.TabIndex = 8;
            this.Calcular.Text = "Calcular Área";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Base:";
            // 
            // Base
            // 
            this.Base.Location = new System.Drawing.Point(243, 215);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(38, 20);
            this.Base.TabIndex = 10;
            this.Base.TextChanged += new System.EventHandler(this.Base_TextChanged);
            // 
            // Altura
            // 
            this.Altura.Location = new System.Drawing.Point(141, 153);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(38, 20);
            this.Altura.TabIndex = 12;
            this.Altura.TextChanged += new System.EventHandler(this.Altura_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Altura:";
            // 
            // FormAtividade4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 429);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Base);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAtividade4";
            this.Text = "Atividade 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Base;
        private System.Windows.Forms.TextBox Altura;
        private System.Windows.Forms.Label label4;
    }
}