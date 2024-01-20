using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double btnNumber = 0;
        private string btnOperation;
        private bool IsPressed = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddNumber(btn.Text);
        }
        private void AddNumber(string text)
        {
            if(IsPressed)
            {
                Txt.Text = text;
                IsPressed = false;
            }
            else
            {
                Txt.Text += text;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddNumber(btn.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddNumber(btn.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddNumber(btn.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddNumber(btn.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddNumber(btn.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddNumber(btn.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddNumber(btn.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddNumber(btn.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddNumber(btn.Text);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ClearCalculator();
        }
        
        private void PerformOperation()
        {
            double TxtNumber = double.Parse(Txt.Text);
            if (btnOperation == "+")
            {
                Txt.Text = (btnNumber += TxtNumber).ToString();
            }
            else if (btnOperation == "-")
            {
                Txt.Text = (btnNumber -= TxtNumber).ToString();
            }
            else if (btnOperation == "*")
            {
                Txt.Text = (btnNumber *= TxtNumber).ToString();
            }
            else if (btnOperation == "/")
            {
                if (btnNumber != 0)
                {
                    Txt.Text = (btnNumber /= TxtNumber).ToString();
                }
                else
                    MessageBox.Show("0 ga bolish amalini bajarib bolmaydi");
            }

            Txt.Text = btnNumber.ToString();
            IsPressed = true;
            btnOperation = "";

        }
        private void ClearCalculator()
        {
            Txt.Text = "0";
            btnNumber = 0;
            btnOperation = "";
            IsPressed = true;
        }
        private void btnplus_Click(object sender, EventArgs e)
        {
            btnOperation = "+";
        }

        private void btnkopaytir_Click(object sender, EventArgs e)
        {
            btnOperation = "*";  
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            btnOperation = "-";
        }

        private void btnboluv_Click(object sender, EventArgs e)
        {
            btnOperation = "/";
        }

        private void btnteng_Click(object sender, EventArgs e)
        {
            PerformOperation();
            Txt.Text = btnNumber.ToString();
        }
    }
}
