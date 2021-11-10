using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Area_Trapezio_WindowsFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r, i, v;

            r = Convert.ToDouble(textBox1.Text);
            i = Convert.ToDouble(textBox2.Text);

            v = r / i;

            textBox3.Text = Convert.ToString(v);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
