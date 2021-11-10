using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Letreiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            lblrelogio.Text = DateTime.Now.TimeOfDay.ToString();

        }

        private void lblnome_Click(object sender, EventArgs e)
        {

        }

        private void letreiro_Tick(object sender, EventArgs e)
        {
            lblnome.Left = lblnome.Left - 20;

            if (lblnome.Left <= -lblnome.Width)
            {
                lblnome.Left = this.Width;
            }
        }
    }
}
