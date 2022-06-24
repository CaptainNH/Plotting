using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Plotting
{

    public partial class FormMain : Form
    {
        private double x0, xk, h, a, b, c, n, k1, k2;
        private double x, y;

        private string[] Functions =
        {
            "sin",
            "cos",
            "tg",
            "ctg",
            "arcsin",
            "arccos",
            "arctg",
            "arcctg",
            $"x{(char)8319}",
            $"log{(char)8336} b"
        };
        private char small_1 = (char)8321;
        private char small_2 = (char)8322;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxFunctions.Items.AddRange(Functions);
            labelk1.Text = $"k{small_1} = ";
            labelk2.Text = $"k{small_2} = ";
        }

        private void DisableElements()
        {
            foreach (var control in Controls)
            {
                if(control.GetType() == typeof(TextBox))
                {
                    (control as TextBox).Enabled = false;
                    (control as TextBox).Text = "";
                }
            }
        }        

        private void SetFunction(int index)
        {
            if (index <= 7)
            {
                labelFunction.Text = $"k{small_1} * {Functions[index]}(k{small_2} * x + a) + b";
                textBoxk1.Enabled = true;
                textBoxk1.Text = "1";
                textBoxk2.Enabled = true;
                textBoxk2.Text = "1";
                textBoxA.Enabled = true;
                textBoxA.Text = "0";
                textBoxB.Enabled = true;
                textBoxB.Text = "0";

            }
            else if (index == 8)
            {
                labelFunction.Text = $"k{small_1} * x{(char)8319} + a";
                textBoxk1.Enabled = true;
                textBoxk1.Text = "1";
                textBoxA.Enabled = true;
                textBoxA.Text = "0";
                textBoxN.Enabled = true;
                textBoxN.Text = "2";
            }
            else
            {
                labelFunction.Text = $"k{small_1} * log{(char)8336}(k{small_2} * x + b) + c";
                textBoxk1.Enabled = true;
                textBoxk1.Text = "1";
                textBoxk2.Enabled = true;
                textBoxk2.Text = "1";
                textBoxA.Enabled = true;
                textBoxA.Text = "2";
                textBoxB.Enabled = true;
                textBoxB.Text = "0";
                textBoxC.Enabled = true;
                textBoxC.Text = "0";
            }
        }

        private void SetCoefficients(int index)
        {
            try
            {

                k1 = Convert.ToDouble(textBoxk1.Text);
                a = Convert.ToDouble(textBoxA.Text);
                if (index <= 7)
                {
                    k2 = Convert.ToDouble(textBoxk2.Text);
                    b = Convert.ToDouble(textBoxB.Text);
                }
                else if (index == 8)
                {
                    n = Convert.ToDouble(textBoxN.Text);
                }
                else
                {
                    if (a <= 0 || a == 1)
                        throw new Exception("Основание логарифма должно быть больше 0 и не равным 1.");
                    k2 = Convert.ToDouble(textBoxk2.Text);
                    b = Convert.ToDouble(textBoxB.Text);
                    c = Convert.ToDouble(textBoxC.Text);
                }
            }
            catch(Exception ex)
            {
                if (ex.Message == "Основание логарифма должно быть больше 0 и не равным 1.")
                    MessageBox.Show(ex.Message);
                else
                    MessageBox.Show("Введите целое число или десятичную дробь.");
            }
        }
            
        private void comboBoxFunctions_SelectedValueChanged(object sender, EventArgs e)
        {
            DisableElements();
            var index = comboBoxFunctions.SelectedIndex;
            SetFunction(index);
            textBoxFrom.Enabled = true;
            textBoxTo.Enabled = true;
        }

        private double SelectFunction(int index)
        {
            double y = 0;
            switch (index)
            {
                case 0:
                    y = k1 * Math.Sin(k2 * x + a) + b;
                    break;
                case 1:
                    y = k1 * Math.Cos(k2 * x + a) + b;
                    break;
                case 2:
                    y = k1 * Math.Tan(k2 * x + a) + b;
                    break;
                case 3:
                    if(Math.Abs(k2 * x + a) > 1e-4)
                        y = k1 * (Math.Cos(k2 * x + a) / Math.Sin(k2 * x + a)) + b;
                    break;
                case 4:
                    y = k1 * Math.Asin(k2 * x + a) + b;
                    break;
                case 5:
                    y = k1 * Math.Acos(k2 * x + a) + b;
                    break;
                case 6:
                    y = k1 * Math.Atan(k2 * x + a) + b;
                    break;
                case 7:
                    y = k1 * (Math.PI / 2 - Math.Atan(k2 * x + a)) + b;
                    break;
                case 8:
                    if (n < 0 && Math.Abs(x) < 1e-4)
                        break;
                    y = k1 * Math.Pow(x, n) + a;
                    break;
                case 9:
                    y = k1 * Math.Log(k2 * x + b, a) + c;
                    break;
            }
            return y;
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            chartGraph.Series[0].Points.Clear();
            try
            {
                x0 = Convert.ToDouble(textBoxFrom.Text);
                xk = Convert.ToDouble(textBoxTo.Text);
            }
            catch
            {
                textBoxFrom.Text = "-10";
                textBoxTo.Text = "10";
                x0 = -10;
                xk = 10;
            }
            chartGraph.ChartAreas[0].AxisX.Minimum = x0;
            chartGraph.ChartAreas[0].AxisX.Maximum = xk;
            chartGraph.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
            h = 0.05;
            x = x0;

            var functionIndex = comboBoxFunctions.SelectedIndex;
            SetCoefficients(functionIndex);
            
            while(x <= xk)
            {
                y = SelectFunction(functionIndex); 
                chartGraph.Series[0].Points.AddXY(x, y);
                x += h;
            }
        }
    }
}
