namespace PassaPassaLista
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
            this.lista1 = new System.Windows.Forms.ListBox();
            this.lista2 = new System.Windows.Forms.ListBox();
            this.btVai = new System.Windows.Forms.Button();
            this.btVolta = new System.Windows.Forms.Button();
            this.btvaitudo = new System.Windows.Forms.Button();
            this.btvoltatudo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista1
            // 
            this.lista1.FormattingEnabled = true;
            this.lista1.Items.AddRange(new object[] {
            "Lasanha",
            "Inhoque",
            "Panqueca",
            "Batata recheada",
            "Frango",
            "Feijoada",
            "Rabada",
            "Dobradinha",
            "Sarapatel",
            "Miojo",
            "Arroz à grega",
            "Osso buco"});
            this.lista1.Location = new System.Drawing.Point(34, 54);
            this.lista1.Name = "lista1";
            this.lista1.Size = new System.Drawing.Size(120, 160);
            this.lista1.TabIndex = 0;
            // 
            // lista2
            // 
            this.lista2.FormattingEnabled = true;
            this.lista2.Location = new System.Drawing.Point(361, 54);
            this.lista2.Name = "lista2";
            this.lista2.Size = new System.Drawing.Size(120, 160);
            this.lista2.TabIndex = 1;
            // 
            // btVai
            // 
            this.btVai.Location = new System.Drawing.Point(221, 83);
            this.btVai.Name = "btVai";
            this.btVai.Size = new System.Drawing.Size(75, 23);
            this.btVai.TabIndex = 2;
            this.btVai.Text = ">";
            this.btVai.UseVisualStyleBackColor = true;
            this.btVai.Click += new System.EventHandler(this.btVai_Click);
            // 
            // btVolta
            // 
            this.btVolta.Location = new System.Drawing.Point(221, 159);
            this.btVolta.Name = "btVolta";
            this.btVolta.Size = new System.Drawing.Size(75, 23);
            this.btVolta.TabIndex = 3;
            this.btVolta.Text = "<";
            this.btVolta.UseVisualStyleBackColor = true;
            this.btVolta.Click += new System.EventHandler(this.btVolta_Click);
            // 
            // btvaitudo
            // 
            this.btvaitudo.Location = new System.Drawing.Point(221, 54);
            this.btvaitudo.Name = "btvaitudo";
            this.btvaitudo.Size = new System.Drawing.Size(75, 23);
            this.btvaitudo.TabIndex = 4;
            this.btvaitudo.Text = ">>";
            this.btvaitudo.UseVisualStyleBackColor = true;
            this.btvaitudo.Click += new System.EventHandler(this.btvaitudo_Click);
            // 
            // btvoltatudo
            // 
            this.btvoltatudo.Location = new System.Drawing.Point(221, 191);
            this.btvoltatudo.Name = "btvoltatudo";
            this.btvoltatudo.Size = new System.Drawing.Size(75, 23);
            this.btvoltatudo.TabIndex = 5;
            this.btvoltatudo.Text = "<<";
            this.btvoltatudo.UseVisualStyleBackColor = true;
            this.btvoltatudo.Click += new System.EventHandler(this.btvoltatudo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 282);
            this.Controls.Add(this.btvoltatudo);
            this.Controls.Add(this.btvaitudo);
            this.Controls.Add(this.btVolta);
            this.Controls.Add(this.btVai);
            this.Controls.Add(this.lista2);
            this.Controls.Add(this.lista1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lista1;
        private System.Windows.Forms.ListBox lista2;
        private System.Windows.Forms.Button btVai;
        private System.Windows.Forms.Button btVolta;
        private System.Windows.Forms.Button btvaitudo;
        private System.Windows.Forms.Button btvoltatudo;
    }
}

