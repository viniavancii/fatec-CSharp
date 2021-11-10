using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Robsvaldo
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

        private void rdbfeminino_CheckedChanged(object sender, EventArgs e)
        {
            grupofem.Visible = true;
            grupomasc.Visible = false;
        }

        private void rdbmasculino_CheckedChanged(object sender, EventArgs e)
        {
            grupofem.Visible = false;
            grupomasc.Visible = true;
        }
    }
}
