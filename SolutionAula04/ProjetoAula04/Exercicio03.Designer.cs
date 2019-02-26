namespace ProjetoAula04
{
    partial class Exercicio03
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
            this.lblSala = new System.Windows.Forms.Label();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.btnAumento5 = new System.Windows.Forms.Button();
            this.btnAumento10 = new System.Windows.Forms.Button();
            this.btnAumento15 = new System.Windows.Forms.Button();
            this.btnAumento20 = new System.Windows.Forms.Button();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblSal2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.Location = new System.Drawing.Point(13, 22);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(65, 20);
            this.lblSala.TabIndex = 0;
            this.lblSala.Text = "Salário";
            // 
            // txtSal
            // 
            this.txtSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSal.Location = new System.Drawing.Point(12, 53);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(156, 26);
            this.txtSal.TabIndex = 1;
            // 
            // btnAumento5
            // 
            this.btnAumento5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumento5.Location = new System.Drawing.Point(290, 22);
            this.btnAumento5.Name = "btnAumento5";
            this.btnAumento5.Size = new System.Drawing.Size(192, 57);
            this.btnAumento5.TabIndex = 2;
            this.btnAumento5.Text = "Aumento 5%";
            this.btnAumento5.UseVisualStyleBackColor = true;
            this.btnAumento5.Click += new System.EventHandler(this.btnAumento5_Click);
            // 
            // btnAumento10
            // 
            this.btnAumento10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumento10.Location = new System.Drawing.Point(290, 82);
            this.btnAumento10.Name = "btnAumento10";
            this.btnAumento10.Size = new System.Drawing.Size(192, 57);
            this.btnAumento10.TabIndex = 3;
            this.btnAumento10.Text = "Aumento 10%";
            this.btnAumento10.UseVisualStyleBackColor = true;
            this.btnAumento10.Click += new System.EventHandler(this.btnAumento10_Click);
            // 
            // btnAumento15
            // 
            this.btnAumento15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumento15.Location = new System.Drawing.Point(290, 141);
            this.btnAumento15.Name = "btnAumento15";
            this.btnAumento15.Size = new System.Drawing.Size(192, 57);
            this.btnAumento15.TabIndex = 4;
            this.btnAumento15.Text = "Aumento 15%";
            this.btnAumento15.UseVisualStyleBackColor = true;
            this.btnAumento15.Click += new System.EventHandler(this.btnAumento15_Click);
            // 
            // btnAumento20
            // 
            this.btnAumento20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumento20.Location = new System.Drawing.Point(290, 204);
            this.btnAumento20.Name = "btnAumento20";
            this.btnAumento20.Size = new System.Drawing.Size(192, 57);
            this.btnAumento20.TabIndex = 5;
            this.btnAumento20.Text = "Aumento 20%";
            this.btnAumento20.UseVisualStyleBackColor = true;
            this.btnAumento20.Click += new System.EventHandler(this.btnAumento20_Click);
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal.Location = new System.Drawing.Point(12, 312);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(125, 20);
            this.lblSal.TabIndex = 6;
            this.lblSal.Text = "Novo Salário =";
            // 
            // lblSal2
            // 
            this.lblSal2.AutoSize = true;
            this.lblSal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal2.Location = new System.Drawing.Point(157, 312);
            this.lblSal2.Name = "lblSal2";
            this.lblSal2.Size = new System.Drawing.Size(15, 20);
            this.lblSal2.TabIndex = 7;
            this.lblSal2.Text = "-";
            // 
            // Exercicio03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 389);
            this.Controls.Add(this.lblSal2);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.btnAumento20);
            this.Controls.Add(this.btnAumento15);
            this.Controls.Add(this.btnAumento10);
            this.Controls.Add(this.btnAumento5);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.lblSala);
            this.Name = "Exercicio03";
            this.Text = "Exercicio03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Button btnAumento5;
        private System.Windows.Forms.Button btnAumento10;
        private System.Windows.Forms.Button btnAumento15;
        private System.Windows.Forms.Button btnAumento20;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblSal2;
    }
}