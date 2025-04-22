namespace Lista_1___Forms
{
    partial class FormAtividade2
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
            this.Label = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(182, 88);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(232, 30);
            this.Label.TabIndex = 0;
            this.Label.Text = "(   A   +   B   )   *   C";
            this.Label.Click += new System.EventHandler(this.Label_Click);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(200, 138);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(44, 20);
            this.A.TabIndex = 1;
            this.A.TextChanged += new System.EventHandler(this.A_TextChanged);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(273, 138);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(44, 20);
            this.B.TabIndex = 2;
            this.B.TextChanged += new System.EventHandler(this.B_TextChanged);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(370, 138);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(44, 20);
            this.C.TabIndex = 3;
            this.C.TextChanged += new System.EventHandler(this.C_TextChanged);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(264, 193);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 4;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // FormAtividade2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 315);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.Label);
            this.Name = "FormAtividade2";
            this.Text = "Atividade 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.Button Calcular;
    }
}