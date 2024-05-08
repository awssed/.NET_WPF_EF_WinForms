using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace _1Lab_TextCalculator_
{
    public partial class CheckFloor : Form
    {
        Calculator calculator = new Calculator();
        public CheckFloor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SquareRoot_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(Display.Text) && Display.Text[0]!='-' && !calculator.OpFlag)
            {
                for (int i = 0; i < Display.Text.Length; i++)
                {
                    if (Display.Text[i] == '.')
                    {
                        Display.Text = Display.Text.Replace('.', ',');
                    }
                }
                calculator.SquareRoot(ref Display);
            }
        }
        private void CubeRoot_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Display.Text)&& !calculator.OpFlag)
            {
                for (int i = 0; i < Display.Text.Length; i++)
                {
                    if (Display.Text[i] == '.')
                    {
                        Display.Text = Display.Text.Replace('.', ',');
                    }
                }
                calculator.CubeRoot(ref Display);
            }
        }
        private void buttonMemory_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(Display.Text) && !calculator.OpFlag)
            {
                calculator.MemFlag = true;
                calculator.MemoryValue=double.Parse(Display.Text);
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Display.Text += "0";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Display.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Display.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Display.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Display.Text += "9";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Display.Text= string.Empty;
            calculator.DotFlag = false;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Display.Text))
            {
                if (Display.Text[Display.Text.Length - 1] != '+' &&
               Display.Text[Display.Text.Length - 1] != '-' &&
               Display.Text[Display.Text.Length - 1] != '*' &&
               Display.Text[Display.Text.Length - 1] != '/')
                {
                    calculator.DotFlag = true;
                    Display.Text += ".";
                }
            }
            
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (calculator.MemFlag && Display.Text.Length==0)
            {
                Display.Text=calculator.MemoryValue.ToString();
                return;
            }
            if (calculator.MemFlag && (Display.Text[Display.Text.Length - 1] =='+'||
                Display.Text[Display.Text.Length - 1] == '-' ||
                Display.Text[Display.Text.Length - 1] == '*' ||
                Display.Text[Display.Text.Length - 1] == '/' ||
                Display.Text[Display.Text.Length - 1] == '%'))
            {
                Display.Text += calculator.MemoryValue.ToString();
            }
        }

        private void PowerValue_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void buttonSin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Display.Text) && !calculator.OpFlag)
            {
                for (int i = 0; i < Display.Text.Length; i++)
                {
                    if (Display.Text[i] == '.')
                    {
                        Display.Text = Display.Text.Replace('.', ',');
                    }
                }
                calculator.CalcSin(ref Display);
                
            }
        }
        private void buttonCos_Click(object sender, EventArgs e)
        {
            if(!String .IsNullOrEmpty(Display.Text) && !calculator.OpFlag)
            {
                for (int i = 0; i < Display.Text.Length; i++)
                {
                    if (Display.Text[i] == '.')
                    {
                        Display.Text = Display.Text.Replace('.', ',');
                    }
                }
                calculator.CalcCos(ref Display);
            }
        }

        private void buttonTg_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Display.Text) && !calculator.OpFlag)
            {
                for (int i = 0; i < Display.Text.Length; i++)
                {
                    if (Display.Text[i] == '.')
                    {
                        Display.Text = Display.Text.Replace('.', ',');
                    }
                }
                calculator.CalcTan(ref Display);
            }
        }

        private void buttonCtg_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Display.Text) && !calculator.OpFlag)
            {
                for (int i = 0; i < Display.Text.Length; i++)
                {
                    if (Display.Text[i] == '.')
                    {
                        Display.Text = Display.Text.Replace('.', ',');
                    }
                }
                calculator.CalcCtan(ref Display);
            }
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(Display.Text) && !String.IsNullOrEmpty(PowerValue.Text) && !calculator.OpFlag && !calculator.OpFlag)
            {
                for (int i = 0; i < Display.Text.Length; i++)
                {
                    if (Display.Text[i] == '.')
                    {
                        Display.Text = Display.Text.Replace('.', ',');
                    }
                }
                calculator.Power(double.Parse(Display.Text),double.Parse(PowerValue.Text),ref Display);
            }
        }

        private void buttonMinusPlus_Click(object sender, EventArgs e)
        {
            if (!calculator.OpFlag)
            {
                if (!String.IsNullOrEmpty(Display.Text))
                {
                    if (Display.Text[0] != '-')
                    {
                        Display.Text = '-' + Display.Text;
                    }
                    else
                    {
                        Display.Text = Display.Text.Remove(0, 1);
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Display.Text))
            {
                Display.Text += '-';
                return;
            }
            if (!String.IsNullOrEmpty(Display.Text))
            {
                if (Display.Text[Display.Text.Length - 1] != '+' &&
                    Display.Text[Display.Text.Length-1] != '-' &&
                    Display.Text[Display.Text.Length - 1] != '*' &&
                    Display.Text[Display.Text.Length - 1] != '/')
                {
                    calculator.OpFlag = true;
                    Display.Text += "-";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Display.Text))
            {
                if (Display.Text[Display.Text.Length - 1] != '+' &&
                Display.Text[Display.Text.Length - 1] != '-' &&
                Display.Text[Display.Text.Length - 1] != '*' &&
                Display.Text[Display.Text.Length - 1] != '/')
                {
                    calculator.OpFlag = true;
                    Display.Text += "/";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
                
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Display.Text))
            {
                if (Display.Text[Display.Text.Length - 1] != '+' &&
                Display.Text[Display.Text.Length - 1] != '-' &&
                Display.Text[Display.Text.Length - 1] != '*' &&
                Display.Text[Display.Text.Length - 1] != '/')
                {
                    calculator.OpFlag = true;
                    Display.Text += "+";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Display.Text))
            {
                if (Display.Text[Display.Text.Length - 1] != '+' &&
                Display.Text[Display.Text.Length - 1] != '-' &&
                Display.Text[Display.Text.Length - 1] != '*' &&
                Display.Text[Display.Text.Length - 1] != '/')
                {
                    calculator.OpFlag = true;
                    Display.Text += "*";
                }
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if(calculator.OpFlag)
            { for(int i = 0;i<Display.Text.Length;i++)
                {
                    if (Display.Text[i]==',')
                    {
                        Display.Text = Display.Text.Replace(',', '.');
                    }
                }
                calculator.Equal(ref Display);
                calculator.OpFlag = false;
                for (int i = 0; i < Display.Text.Length; i++)
                {
                    if (Display.Text[i] == ',')
                    {
                        Display.Text = Display.Text.Replace(',', '.');
                    }
                }
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Display.Text))
            {
                if (Display.Text[Display.Text.Length - 1] != '+' &&
                Display.Text[Display.Text.Length - 1] != '-' &&
                Display.Text[Display.Text.Length - 1] != '*' &&
                Display.Text[Display.Text.Length - 1] != '/')
                {
                    calculator.OpFlag = true;
                    Display.Text += "%";
                }
            }
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            calculator.FloorFlag = !calculator.FloorFlag;
        }
    }
}
