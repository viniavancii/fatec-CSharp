using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exCone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btcalcular_Click(object sender, EventArgs e)
        {
            double raio, altura, volume1, volume2;

            raio = Convert.ToDouble(txtraio.Text);
            altura = Convert.ToDouble(txtaltura.Text);

            volume1 = 3.14 * (raio * raio) * altura;
            volume2 = volume1 / 3;

            txtvolume.Text = Convert.ToString(volume2);
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            txtaltura.Text = "0";
            txtraio.Text = "0";
            txtvolume.Text = "0";
        }
    }
}
