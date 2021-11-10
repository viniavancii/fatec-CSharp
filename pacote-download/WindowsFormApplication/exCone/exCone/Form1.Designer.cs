namespace exCone
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtraio = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtvolume = new System.Windows.Forms.TextBox();
            this.btcalcular = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Volume";
            // 
            // txtraio
            // 
            this.txtraio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtraio.Location = new System.Drawing.Point(119, 29);
            this.txtraio.Name = "txtraio";
            this.txtraio.Size = new System.Drawing.Size(83, 25);
            this.txtraio.TabIndex = 3;
            // 
            // txtaltura
            // 
            this.txtaltura.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaltura.Location = new System.Drawing.Point(119, 69);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(83, 25);
            this.txtaltura.TabIndex = 4;
            // 
            // txtvolume
            // 
            this.txtvolume.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvolume.Location = new System.Drawing.Point(119, 142);
            this.txtvolume.Name = "txtvolume";
            this.txtvolume.ReadOnly = true;
            this.txtvolume.Size = new System.Drawing.Size(83, 25);
            this.txtvolume.TabIndex = 5;
            // 
            // btcalcular
            // 
            this.btcalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcalcular.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcalcular.ForeColor = System.Drawing.Color.White;
            this.btcalcular.Location = new System.Drawing.Point(23, 196);
            this.btcalcular.Name = "btcalcular";
            this.btcalcular.Size = new System.Drawing.Size(75, 29);
            this.btcalcular.TabIndex = 6;
            this.btcalcular.Text = "Calcular";
            this.btcalcular.UseVisualStyleBackColor = true;
            this.btcalcular.Click += new System.EventHandler(this.btcalcular_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlimpar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpar.ForeColor = System.Drawing.Color.White;
            this.btlimpar.Location = new System.Drawing.Point(130, 196);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(72, 29);
            this.btlimpar.TabIndex = 7;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(221, 252);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btcalcular);
            this.Controls.Add(this.txtvolume);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtraio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtraio;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtvolume;
        private System.Windows.Forms.Button btcalcular;
        private System.Windows.Forms.Button btlimpar;
    }
}

