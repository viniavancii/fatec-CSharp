namespace Numero_Reynolds
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtMassa = new System.Windows.Forms.TextBox();
            this.txtVelocidade = new System.Windows.Forms.TextBox();
            this.txtDiametro = new System.Windows.Forms.TextBox();
            this.txtViscosidade = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtReynolds = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a Massa Específica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informe a Velocidade Média (m/s):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Informe o Diâmentro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Informe a Viscosidade Dinâmica:";
            // 
            // txtMassa
            // 
            this.txtMassa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMassa.Location = new System.Drawing.Point(256, 31);
            this.txtMassa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMassa.Name = "txtMassa";
            this.txtMassa.Size = new System.Drawing.Size(114, 26);
            this.txtMassa.TabIndex = 4;
            // 
            // txtVelocidade
            // 
            this.txtVelocidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVelocidade.Location = new System.Drawing.Point(256, 81);
            this.txtVelocidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVelocidade.Name = "txtVelocidade";
            this.txtVelocidade.Size = new System.Drawing.Size(114, 26);
            this.txtVelocidade.TabIndex = 5;
            // 
            // txtDiametro
            // 
            this.txtDiametro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiametro.Location = new System.Drawing.Point(256, 129);
            this.txtDiametro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiametro.Name = "txtDiametro";
            this.txtDiametro.Size = new System.Drawing.Size(114, 26);
            this.txtDiametro.TabIndex = 6;
            // 
            // txtViscosidade
            // 
            this.txtViscosidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViscosidade.Location = new System.Drawing.Point(256, 181);
            this.txtViscosidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtViscosidade.Name = "txtViscosidade";
            this.txtViscosidade.Size = new System.Drawing.Size(114, 26);
            this.txtViscosidade.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(32, 347);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 41);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(256, 347);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 41);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtReynolds
            // 
            this.txtReynolds.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReynolds.Location = new System.Drawing.Point(192, 268);
            this.txtReynolds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReynolds.Name = "txtReynolds";
            this.txtReynolds.Size = new System.Drawing.Size(152, 26);
            this.txtReynolds.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Número de Reynolds:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(386, 423);
            this.Controls.Add(this.txtReynolds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtViscosidade);
            this.Controls.Add(this.txtDiametro);
            this.Controls.Add(this.txtVelocidade);
            this.Controls.Add(this.txtMassa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Reynolds com Viscosidade Dinâmica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMassa;
        private System.Windows.Forms.TextBox txtVelocidade;
        private System.Windows.Forms.TextBox txtDiametro;
        private System.Windows.Forms.TextBox txtViscosidade;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtReynolds;
        private System.Windows.Forms.Label label5;
    }
}

