namespace Atividade.cs
{
    partial class frmGerenciarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarProdutos));
            this.btnVoltarProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltarProd
            // 
            this.btnVoltarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarProd.Image")));
            this.btnVoltarProd.Location = new System.Drawing.Point(577, 409);
            this.btnVoltarProd.Name = "btnVoltarProd";
            this.btnVoltarProd.Size = new System.Drawing.Size(111, 36);
            this.btnVoltarProd.TabIndex = 5;
            this.btnVoltarProd.Text = "Volta&r";
            this.btnVoltarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltarProd.UseVisualStyleBackColor = true;
            // 
            // frmGerenciarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(700, 457);
            this.Controls.Add(this.btnVoltarProd);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerenciarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Produtos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarProd;
    }
}