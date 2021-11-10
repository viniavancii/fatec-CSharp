namespace Aleatorio
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
            this.components = new System.ComponentModel.Container();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.nemcavaloguenta = new System.Windows.Forms.Timer(this.components);
            this.btjogar = new System.Windows.Forms.Button();
            this.btchegada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic3
            // 
            this.pic3.Image = global::Aleatorio.Properties.Resources.cavalo3;
            this.pic3.Location = new System.Drawing.Point(22, 219);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(58, 67);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = global::Aleatorio.Properties.Resources.cavalo2;
            this.pic2.Location = new System.Drawing.Point(22, 119);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(58, 67);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Image = global::Aleatorio.Properties.Resources.cavalo1;
            this.pic1.Location = new System.Drawing.Point(22, 20);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(58, 67);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // nemcavaloguenta
            // 
            this.nemcavaloguenta.Interval = 400;
            this.nemcavaloguenta.Tick += new System.EventHandler(this.nemcavaloguenta_Tick);
            // 
            // btjogar
            // 
            this.btjogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btjogar.Location = new System.Drawing.Point(185, 326);
            this.btjogar.Name = "btjogar";
            this.btjogar.Size = new System.Drawing.Size(87, 33);
            this.btjogar.TabIndex = 3;
            this.btjogar.Text = "Jugar";
            this.btjogar.UseVisualStyleBackColor = true;
            this.btjogar.Click += new System.EventHandler(this.btjogar_Click);
            // 
            // btchegada
            // 
            this.btchegada.BackColor = System.Drawing.Color.Red;
            this.btchegada.Location = new System.Drawing.Point(423, 20);
            this.btchegada.Name = "btchegada";
            this.btchegada.Size = new System.Drawing.Size(17, 266);
            this.btchegada.TabIndex = 4;
            this.btchegada.UseVisualStyleBackColor = false;
            this.btchegada.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 395);
            this.Controls.Add(this.btchegada);
            this.Controls.Add(this.btjogar);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Timer nemcavaloguenta;
        private System.Windows.Forms.Button btjogar;
        private System.Windows.Forms.Button btchegada;


    }
}

