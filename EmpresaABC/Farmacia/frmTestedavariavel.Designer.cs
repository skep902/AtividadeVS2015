namespace Farmacia
{
    partial class frmTestedavariavel
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
            this.lblMostrar = new System.Windows.Forms.Label();
            this.lblMostrar2 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnBandeira = new System.Windows.Forms.Button();
            this.lblBandeira = new System.Windows.Forms.Label();
            this.btnResetar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMostrar
            // 
            this.lblMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrar.Location = new System.Drawing.Point(186, 38);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(176, 55);
            this.lblMostrar.TabIndex = 0;
            this.lblMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMostrar.Click += new System.EventHandler(this.lblMostrar_Click);
            // 
            // lblMostrar2
            // 
            this.lblMostrar2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrar2.Location = new System.Drawing.Point(186, 149);
            this.lblMostrar2.Name = "lblMostrar2";
            this.lblMostrar2.Size = new System.Drawing.Size(176, 63);
            this.lblMostrar2.TabIndex = 1;
            this.lblMostrar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMostrar2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(47, 38);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(103, 55);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "&Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(47, 149);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(103, 60);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnBandeira
            // 
            this.btnBandeira.Location = new System.Drawing.Point(47, 260);
            this.btnBandeira.Name = "btnBandeira";
            this.btnBandeira.Size = new System.Drawing.Size(103, 60);
            this.btnBandeira.TabIndex = 2;
            this.btnBandeira.Text = "Bandeira";
            this.btnBandeira.UseVisualStyleBackColor = true;
            this.btnBandeira.Click += new System.EventHandler(this.btnBandeira_Click);
            // 
            // lblBandeira
            // 
            this.lblBandeira.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBandeira.Location = new System.Drawing.Point(186, 260);
            this.lblBandeira.Name = "lblBandeira";
            this.lblBandeira.Size = new System.Drawing.Size(176, 63);
            this.lblBandeira.TabIndex = 3;
            this.lblBandeira.Text = "False";
            this.lblBandeira.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnResetar
            // 
            this.btnResetar.Location = new System.Drawing.Point(425, 260);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(110, 60);
            this.btnResetar.TabIndex = 4;
            this.btnResetar.Text = "Resetar";
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(462, 138);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(0, 13);
            this.lblNumero.TabIndex = 5;
            // 
            // lblNum
            // 
            this.lblNum.Location = new System.Drawing.Point(425, 38);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(103, 55);
            this.lblNum.TabIndex = 6;
            this.lblNum.UseVisualStyleBackColor = true;
            // 
            // frmTestedavariavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 373);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnResetar);
            this.Controls.Add(this.lblBandeira);
            this.Controls.Add(this.btnBandeira);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblMostrar2);
            this.Controls.Add(this.lblMostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmTestedavariavel";
            this.Text = "Teste da Variável";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Label lblMostrar2;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnBandeira;
        private System.Windows.Forms.Label lblBandeira;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button lblNum;
    }
}