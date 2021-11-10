using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.SkyBlue;

        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen; 
        }

        private void rosaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.HotPink;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            cli.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
