namespace Lab1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1a = new System.Windows.Forms.GroupBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBox1b = new System.Windows.Forms.GroupBox();
            this.textBoxGoneRight = new System.Windows.Forms.TextBox();
            this.textBoxGoneLeft = new System.Windows.Forms.TextBox();
            this.buttonTask2 = new System.Windows.Forms.Button();
            this.numericUpDownInput = new System.Windows.Forms.NumericUpDown();
            this.groupBox1a.SuspendLayout();
            this.groupBox1b.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1a
            // 
            this.groupBox1a.Controls.Add(this.numericUpDownInput);
            this.groupBox1a.Controls.Add(this.textBoxOutput);
            this.groupBox1a.Controls.Add(this.buttonCalculate);
            this.groupBox1a.Location = new System.Drawing.Point(12, 12);
            this.groupBox1a.Name = "groupBox1a";
            this.groupBox1a.Size = new System.Drawing.Size(607, 254);
            this.groupBox1a.TabIndex = 0;
            this.groupBox1a.TabStop = false;
            this.groupBox1a.Text = "Задание 1.a";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.AcceptsTab = true;
            this.textBoxOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxOutput.Location = new System.Drawing.Point(298, 50);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(227, 120);
            this.textBoxOutput.TabIndex = 2;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(89, 94);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(165, 76);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Вычислить";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1b
            // 
            this.groupBox1b.Controls.Add(this.textBoxGoneRight);
            this.groupBox1b.Controls.Add(this.textBoxGoneLeft);
            this.groupBox1b.Location = new System.Drawing.Point(12, 272);
            this.groupBox1b.Name = "groupBox1b";
            this.groupBox1b.Size = new System.Drawing.Size(607, 288);
            this.groupBox1b.TabIndex = 1;
            this.groupBox1b.TabStop = false;
            this.groupBox1b.Text = "Задание 1.б";
            // 
            // textBoxGoneRight
            // 
            this.textBoxGoneRight.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxGoneRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGoneRight.Location = new System.Drawing.Point(340, 118);
            this.textBoxGoneRight.Multiline = true;
            this.textBoxGoneRight.Name = "textBoxGoneRight";
            this.textBoxGoneRight.ReadOnly = true;
            this.textBoxGoneRight.Size = new System.Drawing.Size(244, 69);
            this.textBoxGoneRight.TabIndex = 0;
            this.textBoxGoneRight.Text = "Ушёл";
            this.textBoxGoneRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxGoneRight.MouseEnter += new System.EventHandler(this.textBox4_MouseEnter);
            this.textBoxGoneRight.MouseLeave += new System.EventHandler(this.textBox4_MouseLeave);
            // 
            // textBoxGoneLeft
            // 
            this.textBoxGoneLeft.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxGoneLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGoneLeft.Location = new System.Drawing.Point(24, 118);
            this.textBoxGoneLeft.Multiline = true;
            this.textBoxGoneLeft.Name = "textBoxGoneLeft";
            this.textBoxGoneLeft.ReadOnly = true;
            this.textBoxGoneLeft.Size = new System.Drawing.Size(244, 69);
            this.textBoxGoneLeft.TabIndex = 0;
            this.textBoxGoneLeft.Text = "Ушёл";
            this.textBoxGoneLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxGoneLeft.MouseEnter += new System.EventHandler(this.textBox3_MouseEnter);
            this.textBoxGoneLeft.MouseLeave += new System.EventHandler(this.textBox3_MouseLeave);
            // 
            // buttonTask2
            // 
            this.buttonTask2.Location = new System.Drawing.Point(483, 568);
            this.buttonTask2.Name = "buttonTask2";
            this.buttonTask2.Size = new System.Drawing.Size(136, 29);
            this.buttonTask2.TabIndex = 2;
            this.buttonTask2.Text = "Задание 2";
            this.buttonTask2.UseVisualStyleBackColor = true;
            this.buttonTask2.Click += new System.EventHandler(this.buttonTask2_Click);
            // 
            // numericUpDownInput
            // 
            this.numericUpDownInput.Location = new System.Drawing.Point(89, 51);
            this.numericUpDownInput.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownInput.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDownInput.Name = "numericUpDownInput";
            this.numericUpDownInput.Size = new System.Drawing.Size(165, 22);
            this.numericUpDownInput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(632, 603);
            this.Controls.Add(this.buttonTask2);
            this.Controls.Add(this.groupBox1b);
            this.Controls.Add(this.groupBox1a);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Операционные системы. Лабораторная работа 1.1";
            this.groupBox1a.ResumeLayout(false);
            this.groupBox1a.PerformLayout();
            this.groupBox1b.ResumeLayout(false);
            this.groupBox1b.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1a;
        private System.Windows.Forms.GroupBox groupBox1b;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxGoneLeft;
        private System.Windows.Forms.TextBox textBoxGoneRight;
        private System.Windows.Forms.Button buttonTask2;
        private System.Windows.Forms.NumericUpDown numericUpDownInput;
    }
}

