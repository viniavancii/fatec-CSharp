using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mensagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Corpo da mensagem", "Título");
            MessageBox.Show("Testando conjunto de botoes", "teste", MessageBoxButtons.OKCancel);
            MessageBox.Show("Testando conjunto de icones", "teste", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            MessageBox.Show("Erro", "Erro2", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("O Pavão é Pavão", "Pense bem...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                MessageBox.Show("Obrigado", "Valeu");
            }

            else
            {
                MessageBox.Show("Você reprovou", "Tá ferrado");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resposta2;
            resposta2 =  MessageBox.Show("Deseja realmente sair?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta2 == DialogResult.Yes)
            {
                MessageBox.Show("Bye, bye", "Até mais", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show("Continue comigo", "Oba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        
        }

        

       
    }
}
