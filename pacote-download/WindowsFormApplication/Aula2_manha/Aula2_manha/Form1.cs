using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aula2_manha
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btok_Click(object sender, EventArgs e)
        {
            double vel, tempo, dist;

            dist = Convert.ToDouble(txtdistancia.Text);
            tempo = Convert.ToDouble(txttempo.Text);

            vel = dist / tempo;

            txtvelocidade.Text = Convert.ToString(vel);
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            txtvelocidade.Text = "0";
            txtdistancia.Text = "0";
            txttempo.Text = "0";
        }
    }
}
