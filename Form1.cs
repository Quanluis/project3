using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)

        {
            //Variables

            double value;


            //Input

            value = double.Parse(textBox1.Text);


            //Output

            label4.Text = value.ToString("");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
