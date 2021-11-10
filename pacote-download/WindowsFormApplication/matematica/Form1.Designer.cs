namespace matematica
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
            this.btraiz = new System.Windows.Forms.Button();
            this.potencia = new System.Windows.Forms.Button();
            this.ceiling = new System.Windows.Forms.Button();
            this.floor = new System.Windows.Forms.Button();
            this.round = new System.Windows.Forms.Button();
            this.btmodulo = new System.Windows.Forms.Button();
            this.btsinal = new System.Windows.Forms.Button();
            this.txtraio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btarea = new System.Windows.Forms.Button();
            this.lblresul = new System.Windows.Forms.Label();
            this.bttamanho = new System.Windows.Forms.Button();
            this.btsubstring = new System.Windows.Forms.Button();
            this.btreplace = new System.Windows.Forms.Button();
            this.btinsert = new System.Windows.Forms.Button();
            this.btremove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btraiz
            // 
            this.btraiz.Location = new System.Drawing.Point(21, 12);
            this.btraiz.Name = "btraiz";
            this.btraiz.Size = new System.Drawing.Size(75, 23);
            this.btraiz.TabIndex = 0;
            this.btraiz.Text = "Raiz";
            this.btraiz.UseVisualStyleBackColor = true;
            this.btraiz.Click += new System.EventHandler(this.btraiz_Click);
            // 
            // potencia
            // 
            this.potencia.Location = new System.Drawing.Point(102, 12);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(75, 23);
            this.potencia.TabIndex = 1;
            this.potencia.Text = "Potência";
            this.potencia.UseVisualStyleBackColor = true;
            this.potencia.Click += new System.EventHandler(this.potencia_Click);
            // 
            // ceiling
            // 
            this.ceiling.Location = new System.Drawing.Point(183, 12);
            this.ceiling.Name = "ceiling";
            this.ceiling.Size = new System.Drawing.Size(75, 23);
            this.ceiling.TabIndex = 2;
            this.ceiling.Text = "Ceiling";
            this.ceiling.UseVisualStyleBackColor = true;
            this.ceiling.Click += new System.EventHandler(this.ceiling_Click);
            // 
            // floor
            // 
            this.floor.Location = new System.Drawing.Point(264, 12);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(75, 23);
            this.floor.TabIndex = 3;
            this.floor.Text = "Floor";
            this.floor.UseVisualStyleBackColor = true;
            this.floor.Click += new System.EventHandler(this.floor_Click);
            // 
            // round
            // 
            this.round.Location = new System.Drawing.Point(345, 12);
            this.round.Name = "round";
            this.round.Size = new System.Drawing.Size(75, 23);
            this.round.TabIndex = 4;
            this.round.Text = "Round";
            this.round.UseVisualStyleBackColor = true;
            this.round.Click += new System.EventHandler(this.round_Click);
            // 
            // btmodulo
            // 
            this.btmodulo.Location = new System.Drawing.Point(21, 41);
            this.btmodulo.Name = "btmodulo";
            this.btmodulo.Size = new System.Drawing.Size(75, 23);
            this.btmodulo.TabIndex = 5;
            this.btmodulo.Text = "Módulo";
            this.btmodulo.UseVisualStyleBackColor = true;
            this.btmodulo.Click += new System.EventHandler(this.btmodulo_Click);
            // 
            // btsinal
            // 
            this.btsinal.Location = new System.Drawing.Point(102, 41);
            this.btsinal.Name = "btsinal";
            this.btsinal.Size = new System.Drawing.Size(75, 23);
            this.btsinal.TabIndex = 6;
            this.btsinal.Text = "Sinal";
            this.btsinal.UseVisualStyleBackColor = true;
            this.btsinal.Click += new System.EventHandler(this.btsinal_Click);
            // 
            // txtraio
            // 
            this.txtraio.Location = new System.Drawing.Point(21, 93);
            this.txtraio.Name = "txtraio";
            this.txtraio.Size = new System.Drawing.Size(100, 20);
            this.txtraio.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Digite o raio";
            // 
            // btarea
            // 
            this.btarea.Location = new System.Drawing.Point(127, 90);
            this.btarea.Name = "btarea";
            this.btarea.Size = new System.Drawing.Size(91, 23);
            this.btarea.TabIndex = 9;
            this.btarea.Text = "Area do Circulo";
            this.btarea.UseVisualStyleBackColor = true;
            this.btarea.Click += new System.EventHandler(this.btarea_Click);
            // 
            // lblresul
            // 
            this.lblresul.AutoSize = true;
            this.lblresul.Location = new System.Drawing.Point(21, 116);
            this.lblresul.Name = "lblresul";
            this.lblresul.Size = new System.Drawing.Size(16, 13);
            this.lblresul.TabIndex = 10;
            this.lblresul.Text = "...";
            // 
            // bttamanho
            // 
            this.bttamanho.Location = new System.Drawing.Point(18, 144);
            this.bttamanho.Name = "bttamanho";
            this.bttamanho.Size = new System.Drawing.Size(75, 23);
            this.bttamanho.TabIndex = 11;
            this.bttamanho.Text = "Tamanho";
            this.bttamanho.UseVisualStyleBackColor = true;
            this.bttamanho.Click += new System.EventHandler(this.bttamanho_Click);
            // 
            // btsubstring
            // 
            this.btsubstring.Location = new System.Drawing.Point(100, 144);
            this.btsubstring.Name = "btsubstring";
            this.btsubstring.Size = new System.Drawing.Size(75, 23);
            this.btsubstring.TabIndex = 12;
            this.btsubstring.Text = "Substring";
            this.btsubstring.UseVisualStyleBackColor = true;
            this.btsubstring.Click += new System.EventHandler(this.btsubstring_Click);
            // 
            // btreplace
            // 
            this.btreplace.Location = new System.Drawing.Point(181, 144);
            this.btreplace.Name = "btreplace";
            this.btreplace.Size = new System.Drawing.Size(75, 23);
            this.btreplace.TabIndex = 13;
            this.btreplace.Text = "Replace";
            this.btreplace.UseVisualStyleBackColor = true;
            this.btreplace.Click += new System.EventHandler(this.btreplace_Click);
            // 
            // btinsert
            // 
            this.btinsert.Location = new System.Drawing.Point(263, 144);
            this.btinsert.Name = "btinsert";
            this.btinsert.Size = new System.Drawing.Size(75, 23);
            this.btinsert.TabIndex = 14;
            this.btinsert.Text = "Insert";
            this.btinsert.UseVisualStyleBackColor = true;
            this.btinsert.Click += new System.EventHandler(this.btinsert_Click);
            // 
            // btremove
            // 
            this.btremove.Location = new System.Drawing.Point(345, 144);
            this.btremove.Name = "btremove";
            this.btremove.Size = new System.Drawing.Size(75, 23);
            this.btremove.TabIndex = 15;
            this.btremove.Text = "Remove";
            this.btremove.UseVisualStyleBackColor = true;
            this.btremove.Click += new System.EventHandler(this.btremove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 342);
            this.Controls.Add(this.btremove);
            this.Controls.Add(this.btinsert);
            this.Controls.Add(this.btreplace);
            this.Controls.Add(this.btsubstring);
            this.Controls.Add(this.bttamanho);
            this.Controls.Add(this.lblresul);
            this.Controls.Add(this.btarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtraio);
            this.Controls.Add(this.btsinal);
            this.Controls.Add(this.btmodulo);
            this.Controls.Add(this.round);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.ceiling);
            this.Controls.Add(this.potencia);
            this.Controls.Add(this.btraiz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btraiz;
        private System.Windows.Forms.Button potencia;
        private System.Windows.Forms.Button ceiling;
        private System.Windows.Forms.Button floor;
        private System.Windows.Forms.Button round;
        private System.Windows.Forms.Button btmodulo;
        private System.Windows.Forms.Button btsinal;
        private System.Windows.Forms.TextBox txtraio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btarea;
        private System.Windows.Forms.Label lblresul;
        private System.Windows.Forms.Button bttamanho;
        private System.Windows.Forms.Button btsubstring;
        private System.Windows.Forms.Button btreplace;
        private System.Windows.Forms.Button btinsert;
        private System.Windows.Forms.Button btremove;
    }
}

