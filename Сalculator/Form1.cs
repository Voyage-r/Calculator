using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Сalculator
{
    public partial class Main : Form
    {
        public bool flag;
        public string tempParametr;
        public string act;

        public Main()
        {
            InitializeComponent();
        }

        private void ButtonToClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonRollUp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            int tempNumber;
            bool isNum = int.TryParse(numButton.Text, out tempNumber);

            if (flag)
            {
                flag = false;
                TextBox.Text = "0";
            }

            if (TextBox.Text == "0" && isNum)
            {
                TextBox.Text = numButton.Text;
            }
            else if (!numButton.Text.Contains(",") || !numButton.Text.Contains("."))
            {
                TextBox.Text = TextBox.Text + numButton.Text;
            }
            else
            {
                TextBox.Text = TextBox.Text + numButton.Text;
            }
        }

        private void ClearEntrance_Click(object sender, EventArgs e)
        {
            TextBox.Text = "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                TextBox.Text = TextBox.Text.Substring(0, TextBox.TextLength - 1);
            }
            else
            {
                TextBox.Text = "0";
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void ButtonPercent_Click(object sender, EventArgs e)
        {
            Button buttonAct = (Button)sender;
            act = buttonAct.Text;
            tempParametr = TextBox.Text;
            flag = true;

        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            double firstNum, secondNum, result = 0;
            Double.TryParse(tempParametr, out firstNum);
            Double.TryParse(TextBox.Text, out secondNum);
            if (act == "+")
            {
                result = firstNum + secondNum;
            }
            if (act == "-")
            {
                result = firstNum - secondNum;
            }
            if (act == "*")
            {
                result = firstNum * secondNum;
            }
            if (act == "/")
            {
                result = firstNum / secondNum;
            }
            if (act == "%")
            {
                result = (firstNum / secondNum)*100;
            }
            TextBox.Text = result.ToString();
            flag = true;
        }

        Point lastPoint;

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ButtonWhiteOrBlack_Click(object sender, EventArgs e)
        {
            if (TopPanel.BackColor == Color.White)
            {
                TopPanel.BackColor = Color.FromArgb(39, 39, 39);
            }
            else
            {
                TopPanel.BackColor = Color.White;
            }
        }
    }
}
