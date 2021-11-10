using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PassaPassaLista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVai_Click(object sender, EventArgs e)
        {
            if (lista1.SelectedIndex != -1)
            {
                lista2.Items.Add(lista1.SelectedItem);
                lista1.Items.Remove(lista1.SelectedItem);
            }

            else
            {
                MessageBox.Show("Escolha um item na lista","AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void btVolta_Click(object sender, EventArgs e)
        {
            if (lista2.SelectedIndex != -1)
            {
                lista1.Items.Add(lista2.SelectedItem);
                lista2.Items.Remove(lista2.SelectedItem);
            }

            else
            {
                MessageBox.Show("Escolha um item na lista", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            
        }

        private void btvaitudo_Click(object sender, EventArgs e)
        {
            int i, tam;
            tam = lista1.Items.Count - 1;
            for (i = 0; i <= tam; i++)
            {
                lista2.Items.Add(lista1.Items[i]);
            }
            lista1.Items.Clear();
        }

        private void btvoltatudo_Click(object sender, EventArgs e)
        {
            int i, tam;
            tam = lista2.Items.Count - 1;
            for (i = 0; i <= tam; i++)
            {
                lista1.Items.Add(lista2.Items[i]);
            }
            lista2.Items.Clear();
        }
    }
}
