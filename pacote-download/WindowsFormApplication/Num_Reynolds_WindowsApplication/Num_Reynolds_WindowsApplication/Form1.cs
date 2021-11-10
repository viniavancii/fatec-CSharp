using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Num_Reynolds_WindowsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vel, d, vis, dens, nr;

            vel = Convert.ToDouble(textBox1.Text);
            d = Convert.ToDouble(textBox2.Text);
            vis = Convert.ToDouble(textBox3.Text);
            dens = Convert.ToDouble(textBox4.Text);

            nr = (vel * d * vis) / dens;

            textBox5.Text = Convert.ToString(nr);

            if (nr >= 2000)
            {
                MessageBox.Show("Turbilhonado", "Numero de Reynolds maior ou igual a 2000");
            }
            else
            {
                MessageBox.Show("Laminado", "Numero de Reynolds menor que 2000");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
