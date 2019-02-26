namespace ProjetoAula04
{
    partial class Exercicio04
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClique = new System.Windows.Forms.Label();
            this.btnReduz = new System.Windows.Forms.Button();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.btnExpandir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoAula04.Properties.Resources.inglaterra;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblClique);
            this.panel1.Controls.Add(this.btnReduz);
            this.panel1.Controls.Add(this.btnOriginal);
            this.panel1.Controls.Add(this.btnExpandir);
            this.panel1.Location = new System.Drawing.Point(0, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 34);
            this.panel1.TabIndex = 1;
            // 
            // lblClique
            // 
            this.lblClique.AutoSize = true;
            this.lblClique.Location = new System.Drawing.Point(151, 13);
            this.lblClique.Name = "lblClique";
            this.lblClique.Size = new System.Drawing.Size(13, 13);
            this.lblClique.TabIndex = 3;
            this.lblClique.Text = "0";
            // 
            // btnReduz
            // 
            this.btnReduz.Location = new System.Drawing.Point(555, 8);
            this.btnReduz.Name = "btnReduz";
            this.btnReduz.Size = new System.Drawing.Size(75, 23);
            this.btnReduz.TabIndex = 2;
            this.btnReduz.Text = "Reduz";
            this.btnReduz.UseVisualStyleBackColor = true;
            this.btnReduz.Click += new System.EventHandler(this.btnReduz_Click);
            // 
            // btnOriginal
            // 
            this.btnOriginal.Location = new System.Drawing.Point(334, 8);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(75, 23);
            this.btnOriginal.TabIndex = 1;
            this.btnOriginal.Text = "Original";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // btnExpandir
            // 
            this.btnExpandir.Location = new System.Drawing.Point(18, 8);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(75, 23);
            this.btnExpandir.TabIndex = 0;
            this.btnExpandir.Text = "Expandir";
            this.btnExpandir.UseVisualStyleBackColor = true;
            this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click);
            // 
            // Exercicio04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Exercicio04";
            this.Text = "Exercicio04";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClique;
        private System.Windows.Forms.Button btnReduz;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Button btnExpandir;
    }
}