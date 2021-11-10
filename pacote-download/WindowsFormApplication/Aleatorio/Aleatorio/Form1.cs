using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aleatorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void nemcavaloguenta_Tick(object sender, EventArgs e)
        {
            Random sorteio = new Random();
            int num1 = sorteio.Next(20, 81);
            int num2 = sorteio.Next(20, 81);
            int num3 = sorteio.Next(20, 81);

            pic1.Left = pic1.Left + num1;
            pic2.Left = pic1.Left + num2;
            pic3.Left = pic1.Left + num3;

            if (pic1.Left + pic1.Width >= btchegada.Left ||
                pic2.Left + pic2.Width >= btchegada.Left ||
                pic3.Left + pic3.Width >= btchegada.Left)
            {
                nemcavaloguenta.Enabled = false;
            }
        }

        private void btjogar_Click(object sender, EventArgs e)
        {
            nemcavaloguenta.Enabled  = true;
        }
    }
}
