namespace Lista_1___Forms
{
    partial class FormAtividade6
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
            this.C = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira tres números para verificar qual é o maior:";
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(554, 120);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(48, 20);
            this.C.TabIndex = 13;
            this.C.TextChanged += new System.EventHandler(this.C_TextChanged);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(382, 120);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(48, 20);
            this.B.TabIndex = 12;
            this.B.TextChanged += new System.EventHandler(this.B_TextChanged);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(209, 120);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(48, 20);
            this.A.TabIndex = 11;
            this.A.TextChanged += new System.EventHandler(this.A_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "C = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "B = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "A = ";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(283, 256);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(15, 22);
            this.Resultado.TabIndex = 15;
            this.Resultado.Text = " ";
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(355, 184);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 14;
            this.Calcular.Text = "Verificar";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // FormAtividade6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormAtividade6";
            this.Text = "Atividade 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button Calcular;
    }
}