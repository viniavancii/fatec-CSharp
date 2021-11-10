using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace matematica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btraiz_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Math.Sqrt(144).ToString());
            MessageBox.Show(Math.Sqrt(64).ToString());
            MessageBox.Show(Math.Sqrt(400).ToString());
        }

        private void potencia_Click(object sender, EventArgs e)
        {
            //this.Text = "teste";
            MessageBox.Show(Math.Pow(2, 10).ToString());
            MessageBox.Show(Math.Pow(3, 4).ToString());
            MessageBox.Show(Math.Pow(5, 3).ToString());
        }

        private void ceiling_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Math.Ceiling(2.6791).ToString());
            MessageBox.Show(Math.Ceiling(2.0000001).ToString());
        }

        private void floor_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Math.Floor(2.6798).ToString());
            MessageBox.Show(Math.Floor(2.9999999).ToString());
        }

        private void round_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Math.Round(2.4879, 2).ToString());
            MessageBox.Show(Math.Round(2.4839, 2).ToString());
            MessageBox.Show(Math.Round(2.4879, 0).ToString());
            MessageBox.Show(Math.Round(2.4839, 0).ToString());
        }

        private void btmodulo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Math.Abs(2).ToString());
            MessageBox.Show(Math.Abs(+2).ToString());
            MessageBox.Show(Math.Abs(-2).ToString());
            MessageBox.Show(Math.Abs(0).ToString());
        }

        private void btsinal_Click(object sender, EventArgs e)
        {

            MessageBox.Show(Math.Sign(2).ToString());
            MessageBox.Show(Math.Sign(+2).ToString());
            MessageBox.Show(Math.Sign(-2).ToString());
            MessageBox.Show(Math.Sign(0).ToString());
        }

        private void btarea_Click(object sender, EventArgs e)
        {
            double raio, area;
            raio = Convert.ToDouble(txtraio.Text);
            area = Math.PI * Math.Pow(raio, 2);
            lblresul.Text = area.ToString();
        }

        private void bttamanho_Click(object sender, EventArgs e)
        {
            MessageBox.Show("qualquer coisa".Length.ToString());
        }

        private void btsubstring_Click(object sender, EventArgs e)
        {
            MessageBox.Show("computador".Substring(3, 4));
            MessageBox.Show("ta na");
            MessageBox.Show("comportamento".Substring(3, 5));
        }

        private void btreplace_Click(object sender, EventArgs e)
        {
            MessageBox.Show("banana".Replace("n","t"));
            MessageBox.Show("Ivan Carlos Pavão".Replace("Carlos",  "Charles"));
        }

        private void btinsert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ivan Carlos Pavão".Insert(4, "ildo"));
        }

        private void btremove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Protagonista".Remove(4,4));
        }
    }
}
