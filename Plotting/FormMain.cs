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
            "tan",
            "cot",
            "arcsin",
            "arccos",
            "arctan",
            "arccot",
            $"x{(char)8319}",
            "a^x",
            "log"
        };

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxFunctions.Items.AddRange(Functions);
            
        }

        private void comboBoxFunctions_SelectedValueChanged(object sender, EventArgs e)
        {
            var index = comboBoxFunctions.SelectedIndex;
            if (index <= 7)
            {
                labelFunction.Text = $"a + {Functions[index]}(b * x + c) + d";                
            }
            else if (index == 8)
                labelFunction.Text = $"a * x{(char)8319} + b";
            else if (index == 9)
                labelFunction.Text = $"a^((k * x) + b) + c";
            else
                labelFunction.Text = $"a * log((k * x + b), n) + c";
        }
    }
}
