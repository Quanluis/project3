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
            try
            {

                //Variables

                double value;
                double convertedValue;
                string fromInput;
                string toInput;


                //Input

                value = double.Parse(textBox1.Text);


                if(listBox1.SelectedIndex != -1)
                {
                    if (listBox2.SelectedIndex != -1)
                    {
                        toInput = listBox2.SelectedItem.ToString();
                    }
                        fromInput = listBox1.SelectedItem.ToString();

                        if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0)
                        {

                            label4.Text = value.ToString("");
                        }
                        if(listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1)
                        {
                            convertedValue = value / 12;
                            label4.Text = convertedValue.ToString("");
                        }
                        if(listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 2)
                        {
                            convertedValue =  value / 36;
                        label4.Text = convertedValue.ToString("");
                        }
                        if(listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0)
                        {
                            convertedValue = value * 12 ;
                            label4.Text = convertedValue.ToString("");
                        }
                        if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1)
                        {
                            label4.Text = value.ToString("");
                        }
                        if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 2)
                        {
                            convertedValue = value / 3;
                            label4.Text = convertedValue.ToString("");
                        }
                }          
                else
                {
                    MessageBox.Show("Select both 'From / To' Conversion Value");
                }


                //Output

                

            }
            catch
            {
                MessageBox.Show("Input only accepts numbers");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
