namespace CALKULATOR
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Plus = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Tg = new System.Windows.Forms.Button();
            this.Arcsin = new System.Windows.Forms.Button();
            this.Arccos = new System.Windows.Forms.Button();
            this.Arctg = new System.Windows.Forms.Button();
            this.Ln = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.Kvadrat = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(256, 92);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(75, 23);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.TwoButtonClick);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(256, 121);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(75, 23);
            this.Div.TabIndex = 1;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.TwoButtonClick);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(333, 92);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(75, 23);
            this.Minus.TabIndex = 2;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.TwoButtonClick);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(333, 121);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(75, 23);
            this.Multiply.TabIndex = 3;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.TwoButtonClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(252, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(104, 20);
            this.textBox3.TabIndex = 6;
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(12, 198);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(75, 23);
            this.Sin.TabIndex = 7;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(93, 198);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(75, 23);
            this.Cos.TabIndex = 8;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // Tg
            // 
            this.Tg.Location = new System.Drawing.Point(12, 227);
            this.Tg.Name = "Tg";
            this.Tg.Size = new System.Drawing.Size(75, 23);
            this.Tg.TabIndex = 9;
            this.Tg.Text = "Tg";
            this.Tg.UseVisualStyleBackColor = true;
            this.Tg.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // Arcsin
            // 
            this.Arcsin.Location = new System.Drawing.Point(175, 198);
            this.Arcsin.Name = "Arcsin";
            this.Arcsin.Size = new System.Drawing.Size(75, 23);
            this.Arcsin.TabIndex = 10;
            this.Arcsin.Text = "Arcsin";
            this.Arcsin.UseVisualStyleBackColor = true;
            this.Arcsin.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // Arccos
            // 
            this.Arccos.Location = new System.Drawing.Point(175, 226);
            this.Arccos.Name = "Arccos";
            this.Arccos.Size = new System.Drawing.Size(75, 23);
            this.Arccos.TabIndex = 11;
            this.Arccos.Text = "Arccos";
            this.Arccos.UseVisualStyleBackColor = true;
            this.Arccos.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // Arctg
            // 
            this.Arctg.Location = new System.Drawing.Point(93, 226);
            this.Arctg.Name = "Arctg";
            this.Arctg.Size = new System.Drawing.Size(75, 23);
            this.Arctg.TabIndex = 12;
            this.Arctg.Text = "Arctg";
            this.Arctg.UseVisualStyleBackColor = true;
            this.Arctg.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // Ln
            // 
            this.Ln.Location = new System.Drawing.Point(93, 169);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(75, 23);
            this.Ln.TabIndex = 15;
            this.Ln.Text = "Ln";
            this.Ln.UseVisualStyleBackColor = true;
            this.Ln.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(12, 169);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(75, 23);
            this.Log.TabIndex = 13;
            this.Log.Text = "Log";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // Kvadrat
            // 
            this.Kvadrat.Location = new System.Drawing.Point(256, 226);
            this.Kvadrat.Name = "Kvadrat";
            this.Kvadrat.Size = new System.Drawing.Size(75, 23);
            this.Kvadrat.TabIndex = 16;
            this.Kvadrat.Text = "x^2";
            this.Kvadrat.UseVisualStyleBackColor = true;
            this.Kvadrat.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // e
            // 
            this.e.Location = new System.Drawing.Point(256, 198);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(75, 23);
            this.e.TabIndex = 17;
            this.e.Text = "e^x";
            this.e.UseVisualStyleBackColor = true;
            this.e.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 261);
            this.Controls.Add(this.e);
            this.Controls.Add(this.Kvadrat);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Arctg);
            this.Controls.Add(this.Arccos);
            this.Controls.Add(this.Arcsin);
            this.Controls.Add(this.Tg);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Plus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.OneButtonClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Tg;
        private System.Windows.Forms.Button Arcsin;
        private System.Windows.Forms.Button Arccos;
        private System.Windows.Forms.Button Arctg;
        private System.Windows.Forms.Button Ln;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button Kvadrat;
        private System.Windows.Forms.Button e;
    }
}

