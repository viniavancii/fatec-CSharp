namespace TesteIdade
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAtual = new System.Windows.Forms.Label();
            this.lblNasc = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.txtAtual = new System.Windows.Forms.TextBox();
            this.txtNasc = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.picfigura = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picfigura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAtual
            // 
            this.lblAtual.AutoSize = true;
            this.lblAtual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtual.ForeColor = System.Drawing.Color.White;
            this.lblAtual.Location = new System.Drawing.Point(13, 27);
            this.lblAtual.Name = "lblAtual";
            this.lblAtual.Size = new System.Drawing.Size(79, 18);
            this.lblAtual.TabIndex = 0;
            this.lblAtual.Text = "Ano Atual:";
            this.lblAtual.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNasc.ForeColor = System.Drawing.Color.White;
            this.lblNasc.Location = new System.Drawing.Point(13, 60);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(127, 18);
            this.lblNasc.TabIndex = 1;
            this.lblNasc.Text = "Ano Nascimento:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(13, 99);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(51, 18);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "Idade:";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.White;
            this.lblMensagem.Location = new System.Drawing.Point(73, 144);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(39, 32);
            this.lblMensagem.TabIndex = 3;
            this.lblMensagem.Text = "...";
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Black;
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(14, 208);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(98, 34);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.Black;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.Color.White;
            this.btLimpar.Location = new System.Drawing.Point(194, 208);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(98, 34);
            this.btLimpar.TabIndex = 5;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // txtAtual
            // 
            this.txtAtual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtual.Location = new System.Drawing.Point(155, 27);
            this.txtAtual.Name = "txtAtual";
            this.txtAtual.Size = new System.Drawing.Size(126, 26);
            this.txtAtual.TabIndex = 6;
            this.txtAtual.Text = "2019";
            // 
            // txtNasc
            // 
            this.txtNasc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNasc.Location = new System.Drawing.Point(155, 60);
            this.txtNasc.Name = "txtNasc";
            this.txtNasc.Size = new System.Drawing.Size(126, 26);
            this.txtNasc.TabIndex = 7;
            this.txtNasc.Text = "0";
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(155, 91);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(126, 26);
            this.txtIdade.TabIndex = 8;
            this.txtIdade.Text = "0";
            // 
            // picfigura
            // 
            this.picfigura.Location = new System.Drawing.Point(318, 27);
            this.picfigura.Name = "picfigura";
            this.picfigura.Size = new System.Drawing.Size(168, 207);
            this.picfigura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picfigura.TabIndex = 9;
            this.picfigura.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(520, 265);
            this.Controls.Add(this.picfigura);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNasc);
            this.Controls.Add(this.txtAtual);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNasc);
            this.Controls.Add(this.lblAtual);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picfigura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAtual;
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.TextBox txtAtual;
        private System.Windows.Forms.TextBox txtNasc;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.PictureBox picfigura;
    }
}

