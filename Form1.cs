using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Pythagorus_theorem_in_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double a) && a >= 0 &&
                double.TryParse(textBox2.Text, out double b) && b >= 0)
            {
                // Calculate the perimeter of the rectangle: P = 2 * (length + width)
                double c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));

                // Display the result
                textBox3.Text = c.ToString("F2");
            }
            else
            {
                // Display an error message if the input is invalid
                MessageBox.Show("Invalid input. Please enter non-negative numbers for a and b.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
