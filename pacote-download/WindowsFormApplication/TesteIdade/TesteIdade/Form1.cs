using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TesteIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            int nasc, atual, idade;

            atual = Convert.ToInt16(txtAtual.Text);
            nasc = Convert.ToInt16(txtNasc.Text);

            idade = atual - nasc;

            txtIdade.Text = Convert.ToString(idade);

            if (idade >= 18)
            {
                lblMensagem.Text = "Pode dirigir";
                picfigura.Load(Application.StartupPath + "\\sim.jpg");
                lblMensagem.ForeColor = Color.Black;
                this.BackColor = Color.FromArgb(0, 255, 0);
            }
            else
            {
                lblMensagem.Text = "NÃO pode dirigir";
                picfigura.Load(Application.StartupPath + "\\nao.jpg");
                lblMensagem.ForeColor = Color.Black;
                this.BackColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtAtual.Text = "2019";
            txtIdade.Text = "0";
            txtNasc.Text = "0";
            lblMensagem.Text = "...";
            this.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
