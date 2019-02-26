namespace Atividade.cs
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnGerenciarFunc = new System.Windows.Forms.Button();
            this.btnGerenciarProd = new System.Windows.Forms.Button();
            this.btnGerenciarForne = new System.Windows.Forms.Button();
            this.btnGerenciarUsu = new System.Windows.Forms.Button();
            this.btnVoltarMenup = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGerenciarFunc
            // 
            this.btnGerenciarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnGerenciarFunc.Image")));
            this.btnGerenciarFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerenciarFunc.Location = new System.Drawing.Point(103, 198);
            this.btnGerenciarFunc.Name = "btnGerenciarFunc";
            this.btnGerenciarFunc.Size = new System.Drawing.Size(304, 34);
            this.btnGerenciarFunc.TabIndex = 1;
            this.btnGerenciarFunc.Text = "Gerenciar Funcionários";
            this.btnGerenciarFunc.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarProd
            // 
            this.btnGerenciarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnGerenciarProd.Image")));
            this.btnGerenciarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerenciarProd.Location = new System.Drawing.Point(103, 352);
            this.btnGerenciarProd.Name = "btnGerenciarProd";
            this.btnGerenciarProd.Size = new System.Drawing.Size(304, 34);
            this.btnGerenciarProd.TabIndex = 3;
            this.btnGerenciarProd.Text = "Gerenciar Produtos";
            this.btnGerenciarProd.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarForne
            // 
            this.btnGerenciarForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarForne.Image = ((System.Drawing.Image)(resources.GetObject("btnGerenciarForne.Image")));
            this.btnGerenciarForne.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerenciarForne.Location = new System.Drawing.Point(103, 277);
            this.btnGerenciarForne.Name = "btnGerenciarForne";
            this.btnGerenciarForne.Size = new System.Drawing.Size(304, 35);
            this.btnGerenciarForne.TabIndex = 2;
            this.btnGerenciarForne.Text = "Gerenciar Fornecedores";
            this.btnGerenciarForne.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarUsu
            // 
            this.btnGerenciarUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarUsu.Image = ((System.Drawing.Image)(resources.GetObject("btnGerenciarUsu.Image")));
            this.btnGerenciarUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerenciarUsu.Location = new System.Drawing.Point(103, 124);
            this.btnGerenciarUsu.Name = "btnGerenciarUsu";
            this.btnGerenciarUsu.Size = new System.Drawing.Size(304, 36);
            this.btnGerenciarUsu.TabIndex = 0;
            this.btnGerenciarUsu.Text = "Gerenciar Usuário";
            this.btnGerenciarUsu.UseVisualStyleBackColor = true;
            // 
            // btnVoltarMenup
            // 
            this.btnVoltarMenup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarMenup.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarMenup.Image")));
            this.btnVoltarMenup.Location = new System.Drawing.Point(577, 409);
            this.btnVoltarMenup.Name = "btnVoltarMenup";
            this.btnVoltarMenup.Size = new System.Drawing.Size(111, 36);
            this.btnVoltarMenup.TabIndex = 4;
            this.btnVoltarMenup.Text = "Volta&r";
            this.btnVoltarMenup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltarMenup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltarMenup.UseVisualStyleBackColor = true;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMenu.Location = new System.Drawing.Point(221, 35);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(116, 42);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Menu";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(700, 457);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnVoltarMenup);
            this.Controls.Add(this.btnGerenciarUsu);
            this.Controls.Add(this.btnGerenciarForne);
            this.Controls.Add(this.btnGerenciarProd);
            this.Controls.Add(this.btnGerenciarFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerenciarFunc;
        private System.Windows.Forms.Button btnGerenciarProd;
        private System.Windows.Forms.Button btnGerenciarForne;
        private System.Windows.Forms.Button btnGerenciarUsu;
        private System.Windows.Forms.Button btnVoltarMenup;
        private System.Windows.Forms.Label lblMenu;
    }
}