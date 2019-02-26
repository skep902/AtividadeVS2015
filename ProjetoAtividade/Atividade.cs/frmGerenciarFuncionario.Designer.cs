namespace Atividade.cs
{
    partial class frmGerenciarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarFuncionario));
            this.btnVoltarFunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltarFunc
            // 
            this.btnVoltarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarFunc.Image")));
            this.btnVoltarFunc.Location = new System.Drawing.Point(577, 409);
            this.btnVoltarFunc.Name = "btnVoltarFunc";
            this.btnVoltarFunc.Size = new System.Drawing.Size(111, 36);
            this.btnVoltarFunc.TabIndex = 5;
            this.btnVoltarFunc.Text = "Volta&r";
            this.btnVoltarFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltarFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltarFunc.UseVisualStyleBackColor = true;
            // 
            // frmGerenciarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(700, 457);
            this.Controls.Add(this.btnVoltarFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerenciarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Funcionários";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarFunc;
    }
}