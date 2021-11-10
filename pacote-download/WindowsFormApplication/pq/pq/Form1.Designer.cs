namespace pq
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
            this.grupo = new System.Windows.Forms.GroupBox();
            this.chka = new System.Windows.Forms.RadioButton();
            this.chkb = new System.Windows.Forms.RadioButton();
            this.chkc = new System.Windows.Forms.RadioButton();
            this.chkd = new System.Windows.Forms.RadioButton();
            this.btiniciar = new System.Windows.Forms.Button();
            this.lblpergunta = new System.Windows.Forms.Label();
            this.lblpontos = new System.Windows.Forms.Label();
            this.btconfirmar = new System.Windows.Forms.Button();
            this.grupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupo
            // 
            this.grupo.Controls.Add(this.btconfirmar);
            this.grupo.Controls.Add(this.lblpontos);
            this.grupo.Controls.Add(this.lblpergunta);
            this.grupo.Controls.Add(this.chkd);
            this.grupo.Controls.Add(this.chkc);
            this.grupo.Controls.Add(this.chkb);
            this.grupo.Controls.Add(this.chka);
            this.grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupo.Location = new System.Drawing.Point(37, 86);
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(496, 266);
            this.grupo.TabIndex = 0;
            this.grupo.TabStop = false;
            this.grupo.Enter += new System.EventHandler(this.grupo_Enter);
            // 
            // chka
            // 
            this.chka.AutoSize = true;
            this.chka.Location = new System.Drawing.Point(38, 62);
            this.chka.Name = "chka";
            this.chka.Size = new System.Drawing.Size(110, 22);
            this.chka.TabIndex = 0;
            this.chka.TabStop = true;
            this.chka.Text = "radioButton1";
            this.chka.UseVisualStyleBackColor = true;
            this.chka.CheckedChanged += new System.EventHandler(this.chka_CheckedChanged);
            // 
            // chkb
            // 
            this.chkb.AutoSize = true;
            this.chkb.Location = new System.Drawing.Point(38, 101);
            this.chkb.Name = "chkb";
            this.chkb.Size = new System.Drawing.Size(110, 22);
            this.chkb.TabIndex = 1;
            this.chkb.TabStop = true;
            this.chkb.Text = "radioButton2";
            this.chkb.UseVisualStyleBackColor = true;
            this.chkb.CheckedChanged += new System.EventHandler(this.chkb_CheckedChanged);
            // 
            // chkc
            // 
            this.chkc.AutoSize = true;
            this.chkc.Location = new System.Drawing.Point(38, 142);
            this.chkc.Name = "chkc";
            this.chkc.Size = new System.Drawing.Size(110, 22);
            this.chkc.TabIndex = 2;
            this.chkc.TabStop = true;
            this.chkc.Text = "radioButton3";
            this.chkc.UseVisualStyleBackColor = true;
            this.chkc.CheckedChanged += new System.EventHandler(this.chkc_CheckedChanged);
            // 
            // chkd
            // 
            this.chkd.AutoSize = true;
            this.chkd.Location = new System.Drawing.Point(38, 186);
            this.chkd.Name = "chkd";
            this.chkd.Size = new System.Drawing.Size(110, 22);
            this.chkd.TabIndex = 3;
            this.chkd.TabStop = true;
            this.chkd.Text = "radioButton4";
            this.chkd.UseVisualStyleBackColor = true;
            this.chkd.CheckedChanged += new System.EventHandler(this.chkd_CheckedChanged);
            // 
            // btiniciar
            // 
            this.btiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btiniciar.Location = new System.Drawing.Point(245, 384);
            this.btiniciar.Name = "btiniciar";
            this.btiniciar.Size = new System.Drawing.Size(80, 27);
            this.btiniciar.TabIndex = 1;
            this.btiniciar.Text = "Iniciar";
            this.btiniciar.UseVisualStyleBackColor = true;
            this.btiniciar.Click += new System.EventHandler(this.btiniciar_Click);
            // 
            // lblpergunta
            // 
            this.lblpergunta.AutoSize = true;
            this.lblpergunta.Location = new System.Drawing.Point(17, 21);
            this.lblpergunta.Name = "lblpergunta";
            this.lblpergunta.Size = new System.Drawing.Size(46, 18);
            this.lblpergunta.TabIndex = 4;
            this.lblpergunta.Text = "label1";
            // 
            // lblpontos
            // 
            this.lblpontos.AutoSize = true;
            this.lblpontos.Location = new System.Drawing.Point(414, 33);
            this.lblpontos.Name = "lblpontos";
            this.lblpontos.Size = new System.Drawing.Size(16, 18);
            this.lblpontos.TabIndex = 5;
            this.lblpontos.Text = "0";
            // 
            // btconfirmar
            // 
            this.btconfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconfirmar.Location = new System.Drawing.Point(199, 224);
            this.btconfirmar.Name = "btconfirmar";
            this.btconfirmar.Size = new System.Drawing.Size(89, 27);
            this.btconfirmar.TabIndex = 2;
            this.btconfirmar.Text = "Confirmar";
            this.btconfirmar.UseVisualStyleBackColor = true;
            this.btconfirmar.Click += new System.EventHandler(this.btconfirmar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 449);
            this.Controls.Add(this.btiniciar);
            this.Controls.Add(this.grupo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grupo.ResumeLayout(false);
            this.grupo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupo;
        private System.Windows.Forms.RadioButton chkd;
        private System.Windows.Forms.RadioButton chkc;
        private System.Windows.Forms.RadioButton chkb;
        private System.Windows.Forms.RadioButton chka;
        private System.Windows.Forms.Label lblpontos;
        private System.Windows.Forms.Label lblpergunta;
        private System.Windows.Forms.Button btiniciar;
        private System.Windows.Forms.Button btconfirmar;
    }
}

