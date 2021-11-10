using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pq
{
    public partial class Form1 : Form
    {
        int pos = 0, pontos = 0;
        string [,] matriz = new string[5, 6];
        string correta, resposta="";

        public Form1()
        {
            InitializeComponent();
        }

        private void grupo_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblpontos.Text = "0";
            btiniciar.Enabled = true;
            grupo.Visible = false;

            matriz[0, 0] = "Qual a cor do céu";
            matriz[0, 1] = "Amarelo";
            matriz[0, 2] = "Azul";
            matriz[0, 3] = "Verde";
            matriz[0, 4] = "Marrom";
            matriz[0, 5] = "Azul";

            matriz[1, 0] = "Qual é o animal que late?";
            matriz[1, 1] = "Elefante";
            matriz[1, 2] = "Gato";
            matriz[1, 3] = "Rato";
            matriz[1, 4] = "Cachorro";
            matriz[1, 5] = "Cachorro";

            matriz[2, 0] = "Qual é o professor mais gado da Fatec?";
            matriz[2, 1] = "João";
            matriz[2, 2] = "Adilson";
            matriz[2, 3] = "Pavon";
            matriz[2, 4] = "Sebastion";
            matriz[2, 5] = "Pavon";

            matriz[3, 0] = "Qual personagem morre pegando a jóia?";
            matriz[3, 1] = "Tony Stark";
            matriz[3, 2] = "Viúva Negra";
            matriz[3, 3] = "Gavião arqueiro";
            matriz[3, 4] = "Nebulosa";
            matriz[3, 5] = "Viúva Negra";

            matriz[4, 0] = "Quem matou o Tony Stark";
            matriz[4, 1] = "Sua mãe";
            matriz[4, 2] = "Viúva Negra";
            matriz[4, 3] = "As jóias do Thanos";
            matriz[4, 4] = "Thanos";
            matriz[4, 5] = "As jóias do Thanos";
        }

        private void Preencher()
        {
            if (pos <= 4)
            {
                lblpergunta.Text = matriz[pos, 0];
                chka.Text = matriz[pos, 1];
                chkb.Text = matriz[pos, 2];
                chkc.Text = matriz[pos, 3];
                chkd.Text = matriz[pos, 4];
                correta = matriz[pos, 5];
            }
            else
            {
                lblpontos.Text = "0";
                pontos = 0;
                btiniciar.Enabled = true;
                grupo.Visible = false;
                pos = 0;
                MessageBox.Show("Você fez " + pontos + " pontos", "Pontuação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }








        private void btconfirmar_Click(object sender, EventArgs e)
        {
            if (resposta == correta)
            {
                pontos = pontos + 100;
                lblpontos.Text = pontos.ToString();
            }

            pos++;
            Preencher();

        }

        private void btiniciar_Click(object sender, EventArgs e)
        {
            lblpontos.Text = "0";
            pontos = 0;
            pos = 0;
            btiniciar.Enabled = false;
            grupo.Visible = true;
            Preencher();
        }

        private void chka_CheckedChanged(object sender, EventArgs e)
        {
            resposta = chka.Text;
        }

        private void chkb_CheckedChanged(object sender, EventArgs e)
        {
            resposta = chkb.Text;
        }

        private void chkc_CheckedChanged(object sender, EventArgs e)
        {
            resposta = chkc.Text;
        }

        private void chkd_CheckedChanged(object sender, EventArgs e)
        {
            resposta = chkd.Text;
        }
    }
}
