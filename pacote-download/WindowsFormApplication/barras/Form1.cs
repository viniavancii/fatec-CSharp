using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace barras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (txtCodBarras.Text.Length == 13)
            {
                string codigo, digito;
                int i, somapar = 0, somaimpar = 0, total, digitocalc, num;
                double proxima;

                codigo = txtCodBarras.Text.Substring(0, 12);
                digito = txtCodBarras.Text.Substring(12, 1);



                for (i = 0; i <= 11; i++)
                {
                    num = Convert.ToInt16(codigo.Substring(i, 1));
                    if (i % 2 == 0)
                    {
                        somapar = somapar + num;
                    }
                    else
                    {
                        somaimpar = somaimpar + num;
                    }
                }

                total = somapar + somaimpar * 3;
                proxima = Math.Ceiling(total / 10.0) * 10;
                digitocalc = Convert.ToInt16(proxima - total);
                txtDigito.Text = digitocalc.ToString();

                if (txtDigito.Text == digito)
                {
                    lblResultado.Text = "Digito Correto";
                }

                else
                {
                    lblResultado.Text = "Digito incorreto";
                }

            }
            else
            {
                MessageBox.Show("Digite 13 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCodBarras.Text = "0";
            txtDigito.Text = "0";
            lblResultado.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
