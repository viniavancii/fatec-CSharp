using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExTrapezio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double maior, menor, altura, area1, area2;

            maior = Convert.ToDouble(txtMaior.Text);
            menor = Convert.ToDouble(txtMenor.Text);
            altura = Convert.ToDouble(txtAltura.Text);

            area1 = (maior + menor) * altura;
            area2 = area1 / 2;

            txtArea.Text = Convert.ToString(area2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMaior.Text = "0";
            txtMenor.Text = "0";
            txtAltura.Text = "0";
            txtArea.Text = "0";
        }
    }
}
