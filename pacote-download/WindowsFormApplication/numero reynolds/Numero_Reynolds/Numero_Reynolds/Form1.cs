using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numero_Reynolds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double massa, velocidade, viscosidade, diamentro, reynolds;

            massa = Convert.ToDouble(txtMassa.Text);
            velocidade = Convert.ToDouble(txtVelocidade.Text);
            viscosidade = Convert.ToDouble(txtViscosidade.Text);
            diamentro = Convert.ToDouble(txtDiametro.Text);

            reynolds = (massa * velocidade * diamentro) / viscosidade;

            txtReynolds.Text = Convert.ToString(reynolds);
            }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMassa.Text = "0";
            txtVelocidade.Text = "0";
            txtDiametro.Text = "0";
            txtViscosidade.Text = "0";
            txtReynolds.Text = "0";
        }
    }
}
