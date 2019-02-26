namespace Atividade.cs
{
    partial class frmGerenciarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarUsuario));
            this.btnVoltarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltarUsuario
            // 
            this.btnVoltarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarUsuario.Image")));
            this.btnVoltarUsuario.Location = new System.Drawing.Point(577, 409);
            this.btnVoltarUsuario.Name = "btnVoltarUsuario";
            this.btnVoltarUsuario.Size = new System.Drawing.Size(111, 36);
            this.btnVoltarUsuario.TabIndex = 5;
            this.btnVoltarUsuario.Text = "Volta&r";
            this.btnVoltarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltarUsuario.UseVisualStyleBackColor = true;
            // 
            // frmGerenciarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(700, 457);
            this.Controls.Add(this.btnVoltarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerenciarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Usuario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarUsuario;
    }
}