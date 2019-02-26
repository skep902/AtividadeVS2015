namespace ProjetoTeste
{
    partial class frmTeste
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
            this.lblEscolha = new System.Windows.Forms.Label();
            this.txtEscolha = new System.Windows.Forms.TextBox();
            this.btnEscolha = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnTestaNome = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolha.Location = new System.Drawing.Point(89, 52);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(193, 20);
            this.lblEscolha.TabIndex = 0;
            this.lblEscolha.Text = "Escolha números de 1 a 5";
            // 
            // txtEscolha
            // 
            this.txtEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscolha.Location = new System.Drawing.Point(89, 92);
            this.txtEscolha.Name = "txtEscolha";
            this.txtEscolha.Size = new System.Drawing.Size(193, 26);
            this.txtEscolha.TabIndex = 1;
            // 
            // btnEscolha
            // 
            this.btnEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolha.Location = new System.Drawing.Point(89, 250);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(112, 36);
            this.btnEscolha.TabIndex = 2;
            this.btnEscolha.Text = "Escolher";
            this.btnEscolha.UseVisualStyleBackColor = true;
            this.btnEscolha.Click += new System.EventHandler(this.btnEscolha_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.Location = new System.Drawing.Point(228, 250);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(112, 36);
            this.btnExibir.TabIndex = 3;
            this.btnExibir.Text = "Exibir Mensagem";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnTestaNome
            // 
            this.btnTestaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTestaNome.Location = new System.Drawing.Point(341, 144);
            this.btnTestaNome.Name = "btnTestaNome";
            this.btnTestaNome.Size = new System.Drawing.Size(121, 42);
            this.btnTestaNome.TabIndex = 4;
            this.btnTestaNome.Text = "nome";
            this.btnTestaNome.UseVisualStyleBackColor = true;
            this.btnTestaNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNome.Location = new System.Drawing.Point(337, 104);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(398, 104);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 6;
            // 
            // frmTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 399);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnTestaNome);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.txtEscolha);
            this.Controls.Add(this.lblEscolha);
            this.Name = "frmTeste";
            this.Text = "Escolha";
            this.Load += new System.EventHandler(this.frmTeste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.TextBox txtEscolha;
        private System.Windows.Forms.Button btnEscolha;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnTestaNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
    }
}