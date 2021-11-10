namespace Letreiro
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
            this.lblnome = new System.Windows.Forms.Label();
            this.lblrelogio = new System.Windows.Forms.Label();
            this.letreiro = new System.Windows.Forms.Timer(this.components);
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnome.Location = new System.Drawing.Point(86, 138);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(207, 42);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Vini Santos";
            this.lblnome.Click += new System.EventHandler(this.lblnome_Click);
            // 
            // lblrelogio
            // 
            this.lblrelogio.AutoSize = true;
            this.lblrelogio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblrelogio.Location = new System.Drawing.Point(12, 9);
            this.lblrelogio.Name = "lblrelogio";
            this.lblrelogio.Size = new System.Drawing.Size(21, 20);
            this.lblrelogio.TabIndex = 1;
            this.lblrelogio.Text = "...";
            // 
            // letreiro
            // 
            this.letreiro.Enabled = true;
            this.letreiro.Interval = 300;
            this.letreiro.Tick += new System.EventHandler(this.letreiro_Tick);
            // 
            // relogio
            // 
            this.relogio.Enabled = true;
            this.relogio.Interval = 1;
            this.relogio.Tick += new System.EventHandler(this.relogio_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(380, 368);
            this.Controls.Add(this.lblrelogio);
            this.Controls.Add(this.lblnome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Letreiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblrelogio;
        private System.Windows.Forms.Timer letreiro;
        private System.Windows.Forms.Timer relogio;
    }
}

