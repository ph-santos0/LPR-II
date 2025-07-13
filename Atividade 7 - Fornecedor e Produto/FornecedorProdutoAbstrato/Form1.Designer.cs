namespace Abstrata
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F);
            label1.Location = new Point(48, 33);
            label1.Name = "label1";
            label1.Size = new Size(102, 17);
            label1.TabIndex = 0;
            label1.Text = "Insira um nome: ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 9F);
            textBox1.Location = new Point(48, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 22);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 9F);
            button1.Location = new Point(49, 91);
            button1.Name = "button1";
            button1.Size = new Size(102, 42);
            button1.TabIndex = 2;
            button1.Text = "Cadastrar Fornecedor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 9F);
            button2.Location = new Point(168, 91);
            button2.Name = "button2";
            button2.Size = new Size(103, 42);
            button2.TabIndex = 3;
            button2.Text = "Cadastrar Cliente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 9F);
            button3.Location = new Point(48, 143);
            button3.Name = "button3";
            button3.Size = new Size(103, 51);
            button3.TabIndex = 4;
            button3.Text = "Recuperar último";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Century Gothic", 9F);
            button4.Location = new Point(168, 143);
            button4.Name = "button4";
            button4.Size = new Size(103, 51);
            button4.TabIndex = 5;
            button4.Text = "Registrar Venda";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 233);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Fornecedor Produto";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
