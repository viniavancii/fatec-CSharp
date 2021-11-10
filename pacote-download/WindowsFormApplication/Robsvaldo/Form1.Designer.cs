namespace Robsvaldo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbmasculino = new System.Windows.Forms.RadioButton();
            this.rdbfeminino = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbsolteiro = new System.Windows.Forms.RadioButton();
            this.rdbcasado = new System.Windows.Forms.RadioButton();
            this.grupomasc = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grupofem = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grupomasc.SuspendLayout();
            this.grupofem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbmasculino);
            this.groupBox1.Controls.Add(this.rdbfeminino);
            this.groupBox1.Location = new System.Drawing.Point(14, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo:";
            // 
            // rdbmasculino
            // 
            this.rdbmasculino.AutoSize = true;
            this.rdbmasculino.Location = new System.Drawing.Point(8, 43);
            this.rdbmasculino.Name = "rdbmasculino";
            this.rdbmasculino.Size = new System.Drawing.Size(82, 17);
            this.rdbmasculino.TabIndex = 0;
            this.rdbmasculino.TabStop = true;
            this.rdbmasculino.Text = "Masculino";
            this.rdbmasculino.UseVisualStyleBackColor = true;
            this.rdbmasculino.CheckedChanged += new System.EventHandler(this.rdbmasculino_CheckedChanged);
            // 
            // rdbfeminino
            // 
            this.rdbfeminino.AutoSize = true;
            this.rdbfeminino.Location = new System.Drawing.Point(8, 20);
            this.rdbfeminino.Name = "rdbfeminino";
            this.rdbfeminino.Size = new System.Drawing.Size(75, 17);
            this.rdbfeminino.TabIndex = 0;
            this.rdbfeminino.TabStop = true;
            this.rdbfeminino.Text = "Feminino";
            this.rdbfeminino.UseVisualStyleBackColor = true;
            this.rdbfeminino.CheckedChanged += new System.EventHandler(this.rdbfeminino_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbsolteiro);
            this.groupBox2.Controls.Add(this.rdbcasado);
            this.groupBox2.Location = new System.Drawing.Point(268, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado Civil:";
            // 
            // rdbsolteiro
            // 
            this.rdbsolteiro.AutoSize = true;
            this.rdbsolteiro.Location = new System.Drawing.Point(8, 43);
            this.rdbsolteiro.Name = "rdbsolteiro";
            this.rdbsolteiro.Size = new System.Drawing.Size(68, 17);
            this.rdbsolteiro.TabIndex = 1;
            this.rdbsolteiro.TabStop = true;
            this.rdbsolteiro.Text = "Solteiro";
            this.rdbsolteiro.UseVisualStyleBackColor = true;
            // 
            // rdbcasado
            // 
            this.rdbcasado.AutoSize = true;
            this.rdbcasado.Location = new System.Drawing.Point(8, 20);
            this.rdbcasado.Name = "rdbcasado";
            this.rdbcasado.Size = new System.Drawing.Size(67, 17);
            this.rdbcasado.TabIndex = 0;
            this.rdbcasado.TabStop = true;
            this.rdbcasado.Text = "Casado";
            this.rdbcasado.UseVisualStyleBackColor = true;
            // 
            // grupomasc
            // 
            this.grupomasc.Controls.Add(this.checkBox3);
            this.grupomasc.Controls.Add(this.checkBox2);
            this.grupomasc.Controls.Add(this.checkBox1);
            this.grupomasc.Location = new System.Drawing.Point(15, 162);
            this.grupomasc.Name = "grupomasc";
            this.grupomasc.Size = new System.Drawing.Size(233, 100);
            this.grupomasc.TabIndex = 2;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 65);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(42, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "TV";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 41);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Cerveja";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Futebol";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // grupofem
            // 
            this.grupofem.Controls.Add(this.checkBox4);
            this.grupofem.Controls.Add(this.checkBox5);
            this.grupofem.Controls.Add(this.checkBox6);
            this.grupofem.Location = new System.Drawing.Point(268, 161);
            this.grupofem.Name = "grupofem";
            this.grupofem.Size = new System.Drawing.Size(233, 100);
            this.grupofem.TabIndex = 0;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(8, 66);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(67, 17);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Cinema";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(8, 42);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(74, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Compras";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(8, 18);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(70, 17);
            this.checkBox6.TabIndex = 3;
            this.checkBox6.Text = "Sorvete";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 373);
            this.Controls.Add(this.grupofem);
            this.Controls.Add(this.grupomasc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grupomasc.ResumeLayout(false);
            this.grupomasc.PerformLayout();
            this.grupofem.ResumeLayout(false);
            this.grupofem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbmasculino;
        private System.Windows.Forms.RadioButton rdbfeminino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbsolteiro;
        private System.Windows.Forms.RadioButton rdbcasado;
        private System.Windows.Forms.Panel grupomasc;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel grupofem;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
    }
}

