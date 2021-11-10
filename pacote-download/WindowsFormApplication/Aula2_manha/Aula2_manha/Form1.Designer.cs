namespace Aula2_manha
{
    partial class form1
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
            this.lbldistancia = new System.Windows.Forms.Label();
            this.lbltempo = new System.Windows.Forms.Label();
            this.lblvelocidade = new System.Windows.Forms.Label();
            this.txtdistancia = new System.Windows.Forms.TextBox();
            this.txttempo = new System.Windows.Forms.TextBox();
            this.txtvelocidade = new System.Windows.Forms.TextBox();
            this.btok = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldistancia
            // 
            this.lbldistancia.AutoSize = true;
            this.lbldistancia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldistancia.ForeColor = System.Drawing.Color.White;
            this.lbldistancia.Location = new System.Drawing.Point(20, 26);
            this.lbldistancia.Name = "lbldistancia";
            this.lbldistancia.Size = new System.Drawing.Size(69, 17);
            this.lbldistancia.TabIndex = 0;
            this.lbldistancia.Text = "Distância";
            // 
            // lbltempo
            // 
            this.lbltempo.AutoSize = true;
            this.lbltempo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltempo.ForeColor = System.Drawing.Color.White;
            this.lbltempo.Location = new System.Drawing.Point(20, 86);
            this.lbltempo.Name = "lbltempo";
            this.lbltempo.Size = new System.Drawing.Size(54, 17);
            this.lbltempo.TabIndex = 1;
            this.lbltempo.Text = "Tempo";
            // 
            // lblvelocidade
            // 
            this.lblvelocidade.AutoSize = true;
            this.lblvelocidade.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvelocidade.ForeColor = System.Drawing.Color.White;
            this.lblvelocidade.Location = new System.Drawing.Point(20, 149);
            this.lblvelocidade.Name = "lblvelocidade";
            this.lblvelocidade.Size = new System.Drawing.Size(79, 17);
            this.lblvelocidade.TabIndex = 2;
            this.lblvelocidade.Text = "Velocidade";
            // 
            // txtdistancia
            // 
            this.txtdistancia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdistancia.Location = new System.Drawing.Point(104, 23);
            this.txtdistancia.Name = "txtdistancia";
            this.txtdistancia.Size = new System.Drawing.Size(103, 25);
            this.txtdistancia.TabIndex = 3;
            this.txtdistancia.Text = "0";
            // 
            // txttempo
            // 
            this.txttempo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttempo.Location = new System.Drawing.Point(104, 83);
            this.txttempo.Name = "txttempo";
            this.txttempo.Size = new System.Drawing.Size(103, 25);
            this.txttempo.TabIndex = 4;
            this.txttempo.Text = "0";
            // 
            // txtvelocidade
            // 
            this.txtvelocidade.Enabled = false;
            this.txtvelocidade.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvelocidade.Location = new System.Drawing.Point(104, 146);
            this.txtvelocidade.Name = "txtvelocidade";
            this.txtvelocidade.ReadOnly = true;
            this.txtvelocidade.Size = new System.Drawing.Size(103, 25);
            this.txtvelocidade.TabIndex = 5;
            this.txtvelocidade.Text = "0";
            // 
            // btok
            // 
            this.btok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btok.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btok.ForeColor = System.Drawing.Color.White;
            this.btok.Location = new System.Drawing.Point(23, 203);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(66, 29);
            this.btok.TabIndex = 6;
            this.btok.Text = "OK";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlimpar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpar.ForeColor = System.Drawing.Color.White;
            this.btlimpar.Location = new System.Drawing.Point(140, 203);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(67, 29);
            this.btlimpar.TabIndex = 7;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(227, 257);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.txtvelocidade);
            this.Controls.Add(this.txttempo);
            this.Controls.Add(this.txtdistancia);
            this.Controls.Add(this.lblvelocidade);
            this.Controls.Add(this.lbltempo);
            this.Controls.Add(this.lbldistancia);
            this.Name = "form1";
            this.Text = "Cálculo de Velocidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldistancia;
        private System.Windows.Forms.Label lbltempo;
        private System.Windows.Forms.Label lblvelocidade;
        private System.Windows.Forms.TextBox txtdistancia;
        private System.Windows.Forms.TextBox txttempo;
        private System.Windows.Forms.TextBox txtvelocidade;
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.Button btlimpar;
    }
}

