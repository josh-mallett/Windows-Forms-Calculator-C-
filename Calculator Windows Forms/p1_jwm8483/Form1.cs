using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1_jwm8483
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(30, 30, 30);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(66, 67, 102);
            button2.BackColor = Color.FromArgb(66, 67, 102);
            button3.BackColor = Color.FromArgb(66, 67, 102);
            button4.BackColor = Color.FromArgb(66, 67, 102);
            button5.BackColor = Color.FromArgb(66, 67, 102);
            button6.BackColor = Color.FromArgb(66, 67, 102);
            button7.BackColor = Color.FromArgb(66, 67, 102);
            button8.BackColor = Color.FromArgb(66, 67, 102);
            button9.BackColor = Color.FromArgb(66, 67, 102);
            button10.BackColor = Color.FromArgb(66, 67, 102);
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            label1.Left = (panel2.Width - label1.Width) / 2;
        }

        private string LastButtonClicked = "";
        private bool OperatorIsActive = false;
        private string ActiveOperator = "";
        private double value1 = 0;
        private double value2 = 0;
        private double NewValue = 0;
        

        private void Calculator(string ButtonName)
        {
            if (!OperatorIsActive)
            {
                switch (ButtonName)
                {
                    case "0":
                        AppendNumber("0");
                        break;
                    case "1":
                        AppendNumber("1");
                        break;
                    case "2":
                        AppendNumber("2");
                        break;
                    case "3":
                        AppendNumber("3");
                        break;
                    case "4":
                        AppendNumber("4");
                        break;
                    case "5":
                        AppendNumber("5");
                        break;
                    case "6":
                        AppendNumber("6");
                        break;
                    case "7":
                        AppendNumber("7");
                        break;
                    case "8":
                        AppendNumber("8");
                        break;
                    case "9":
                        AppendNumber("9");
                        break;
                    case ".":
                        AppendNumber(".");
                        break;
                }
            }

            else if (OperatorIsActive)
            {
                
            }
            
        }

        private void SetLastButtonClicked(string button)
        {
            this.LastButtonClicked = button;
        }

        private void AppendNumber(string button)
        {
            if (LastButtonClicked == "" || IsNumber())
            {
                label1.Text += button;
            }
        }

        private bool IsNumber()
        {
            switch (LastButtonClicked)
            {
                case "0":
                    return true;
                    break;
                case "1":
                    return true;
                    break;
                case "2":
                    return true;
                    break;
                case "3":
                    return true;
                    break;
                case "4":
                    return true;
                    break;
                case "5":
                    return true;
                    break;
                case "6":
                    return true;
                    break;
                case "7":
                    return true;
                    break;
                case "8":
                    return true;
                    break;
                case "9":
                    return true;
                    break;
            }
            return false;
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Calculator("1");
            SetLastButtonClicked("1");
            SendKeys.Send({"1dc"});
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Calculator("2");
            SetLastButtonClicked("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculator("3");
            SetLastButtonClicked("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculator("4");
            SetLastButtonClicked("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calculator("5");
            SetLastButtonClicked("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Calculator("6");
            SetLastButtonClicked("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Calculator("7");
            SetLastButtonClicked("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Calculator("8");
            SetLastButtonClicked("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Calculator("9");
            SetLastButtonClicked("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Calculator("0");
            SetLastButtonClicked("0");
        }

        private void button11_Click(object sender, EventArgs e) // ------------add button
        {
            // if last button clicked is a number, do things
            if (IsNumber())
            {
                SetLastButtonClicked("+");
                value1 = double.Parse(label1.Text);
            }

            if (!OperatorIsActive)
            {
                OperatorIsActive = true;
                ActiveOperator = "+";

            }
        }

        private void button12_Click(object sender, EventArgs e) // ------------subtract button
        {
            // if last button clicked is a number, do things
            if (IsNumber())
            {
                SetLastButtonClicked("-");
                value1 = double.Parse(label1.Text);
            }

            if (!OperatorIsActive)
            {
                OperatorIsActive = true;
                ActiveOperator = "+";
            }
        }

        private void button13_Click(object sender, EventArgs e) // ------------multiply button
        {
            // if last button clicked is a number, do things
            if (IsNumber())
            {
                SetLastButtonClicked("x");
                value1 = double.Parse(label1.Text);
            }

            if (!OperatorIsActive)
            {
                OperatorIsActive = true;
                ActiveOperator = "+";
            }
        }

        private void button14_Click(object sender, EventArgs e) // ------------divide button
        {
            // if last button clicked is a number, do things
            if (IsNumber())
            {
                SetLastButtonClicked("/");
                value1 = double.Parse(label1.Text);
            }

            if (!OperatorIsActive)
            {
                OperatorIsActive = true;
                ActiveOperator = "+";
            }
        }

        private void button15_Click(object sender, EventArgs e) // ------------equals button
        {
            // if last button clicked is a number, do things
            if (IsNumber())
            {
                SetLastButtonClicked("=");
            }

            if (OperatorIsActive)
            {
                switch (ActiveOperator)
                {
                    case "+":
                        NewValue = value1 + value2;
                        label1.Text = NewValue.ToString();
                        break;
                    case "-":
                        NewValue = value1 - value2;
                        label1.Text = NewValue.ToString();
                        break;
                    case "*":
                        NewValue = value1 * value2;
                        label1.Text = NewValue.ToString();
                        break;
                    case "/":
                        NewValue = value1 / value2;
                        label1.Text = NewValue.ToString();
                        break;
                }

                OperatorIsActive = false;
                ActiveOperator = "";

            }
        }
    }
}
