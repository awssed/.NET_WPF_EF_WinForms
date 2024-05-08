using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace _1Lab_TextCalculator_
{
    interface ICalculator
    {
        double CalcSin(ref TextBox display);
        double CalcCos(ref TextBox display);
        double CalcTan(ref TextBox display);
        double CalcCtan(ref TextBox display);
        double Power(double x, double y, ref TextBox display);
        double SquareRoot(ref TextBox display);
        double CubeRoot(ref TextBox display);
        void Equal(ref TextBox display);
        double MemoryValue { get; set; }
    }
    public class Calculator:ICalculator
    {
        private bool dotFlag = false;
        private bool memFlag = false;
        private bool opFlag = false;
        private bool floorFlag = false;
        private double memoryValue;
        public bool FloorFlag
        {
            get { return floorFlag; }
            set { floorFlag = value; }
        }
        public bool OpFlag
        {
            get { return opFlag; }
            set { opFlag = value; }
        }
        public bool DotFlag
        {
            get { return dotFlag; }
            set { dotFlag = value; }
        }
        public bool MemFlag
        {
            get { return memFlag; }
            set { memFlag = value; }
        }
        public double MemoryValue
        {
            get { return memoryValue; }
            set { memoryValue = value; }
        }
        public double CalcSin(ref TextBox display)
        {
            double x = double.Parse(display.Text);
            display.Text = Math.Sin(x).ToString();
            return Math.Sin(x);
        }
        public double CalcCos(ref TextBox display)
        {
            double x = double.Parse(display.Text);
            display.Text = Math.Cos(x).ToString();
            return Math.Cos(x);
        }
        public double CalcTan(ref TextBox display)
        {
            double x = double.Parse(display.Text);
            display.Text = Math.Tan(x).ToString();
            return Math.Tan(x);
        }
        public double CalcCtan(ref TextBox display)
        {
            if (display.Text[0]=='0')
            {
                display.Text = "0";
                return 0;
            }
            double x = double.Parse(display.Text);
            display.Text = (1/ Math.Tan(x)).ToString();
            return (1 / Math.Tan(x));
        }
        public double Power(double x, double y, ref TextBox display)
        {
            display.Text = Math.Pow(x, y).ToString();
            return Math.Pow(x, y);
        }
        public double SquareRoot(ref TextBox display)
        {
            double x= double.Parse(display.Text);
            display.Text=Math.Sqrt(x).ToString();
            return Math.Sqrt(x);
        }
        public double CubeRoot(ref TextBox display)
        {
            bool minusFlag=false;
            if (display.Text[0] == '-')
            {
                minusFlag = true;
                display.Text=display.Text.Remove(0, 1);
            }
            double x = double.Parse(display.Text);
            if (minusFlag)
            {
                display.Text ='-'+ Math.Pow(x, 1.0 / 3.0).ToString();
                return -Math.Pow(x, 1.0 / 3.0);
            }
            display.Text=Math.Pow(x,1.0/3.0).ToString();
            return Math.Pow(x, 1.0 / 3.0);
        }
        public void Equal(ref TextBox display)
        {
            if (this.OpFlag)
            {
                Expression expr = new Expression(display.Text);
                if (this.FloorFlag)
                {
                    double x = Math.Floor(Convert.ToDouble(expr.Evaluate()));
                    display.Text = x.ToString();
                }
                else
                {
                    display.Text = expr.Evaluate().ToString();
                }
            }
        }
    }
}
