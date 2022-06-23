using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plotting
{

    public partial class FormMain : Form
    {
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
            textBoxk1.Enabled = false;
            textBoxk2.Enabled = false;
            textBoxA.Enabled = false;
            textBoxB.Enabled = false;
            textBoxC.Enabled = false;
        }

        private void SetFunction(int index)
        {
            if (index <= 7)
            {
                labelFunction.Text = $"k{small_1} * {Functions[index]}(k{small_2} * x + a) + b";
                textBoxk1.Enabled = true;
                textBoxk2.Enabled = true;
                textBoxA.Enabled = true;
                textBoxB.Enabled = true;

            }
            else if (index == 8)
            {
                labelFunction.Text = $"k{small_1} * x{(char)8319} + a";
                textBoxk1.Enabled = true;
                textBoxA.Enabled = true;
                textBoxN.Enabled = true;
            }
            else
            {
                labelFunction.Text = $"k{small_1} * log{(char)8336}(k{small_2} * x + b) + c";
                textBoxk1.Enabled = true;
                textBoxk2.Enabled = true;
                textBoxA.Enabled = true;
                textBoxB.Enabled = true;
                textBoxC.Enabled = true;
            }
        }

        private void comboBoxFunctions_SelectedValueChanged(object sender, EventArgs e)
        {
            DisableElements();
            var index = comboBoxFunctions.SelectedIndex;
            SetFunction(index);
        }
    }
}
