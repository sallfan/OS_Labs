using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Лабораторная работа №1.1";
            this.Icon = global::Lab1.Properties.Resources.logo;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double num = (double) numericUpDownInput.Value;
            string output = string.Format("sin({0}): {1}\r\n\r\n", num, Math.Sin(num));
            output += string.Format("cos({0}): {1}\r\n\r\n", num, Math.Cos(num));
            output += string.Format("tan({0}): {1}\r\n\r\n", num, Math.Tan(num));
            output += string.Format("sqrt({0}): {1}\r\n\r\n", num, Math.Sqrt(num));
            output += string.Format("ln({0}): {1}\r\n\r\n", num, Math.Log(num));

            textBoxOutput.Text = output;
        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            textBoxGoneLeft.Text = "Пришёл";
            textBoxGoneLeft.BackColor = Color.LightBlue;
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            textBoxGoneLeft.Text = "Ушёл";
            textBoxGoneLeft.BackColor = Color.White;
        }

        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
            textBoxGoneRight.Text = "Пришёл";
            textBoxGoneRight.BackColor = Color.LightBlue;
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            textBoxGoneRight.Text = "Ушёл";
            textBoxGoneRight.BackColor = Color.White;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((!Char.IsDigit(number)) && (number != '.') && (number != '-') && (number != '\b'))
            {
                e.Handled = true;
            }
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}
