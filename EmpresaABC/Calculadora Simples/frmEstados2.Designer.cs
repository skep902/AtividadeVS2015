namespace Calculadora_Simples
{
    partial class Estados
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
            this.lblEstados = new System.Windows.Forms.Label();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.btnCarrega = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.ltbEstado = new System.Windows.Forms.ListBox();
            this.btnCarregalista = new System.Windows.Forms.Button();
            this.lblCarregaLabel = new System.Windows.Forms.Label();
            this.lblEstados2 = new System.Windows.Forms.Label();
            this.btnCarregaLabel = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstados.Location = new System.Drawing.Point(13, 25);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(68, 20);
            this.lblEstados.TabIndex = 0;
            this.lblEstados.Text = "Estados";
            // 
            // cboEstados
            // 
            this.cboEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(16, 51);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(131, 28);
            this.cboEstados.TabIndex = 1;
            this.cboEstados.SelectedIndexChanged += new System.EventHandler(this.cboEstados_SelectedIndexChanged);
            // 
            // btnCarrega
            // 
            this.btnCarrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrega.Location = new System.Drawing.Point(16, 166);
            this.btnCarrega.Name = "btnCarrega";
            this.btnCarrega.Size = new System.Drawing.Size(142, 36);
            this.btnCarrega.TabIndex = 2;
            this.btnCarrega.Text = "Carrega Estados";
            this.btnCarrega.UseVisualStyleBackColor = true;
            this.btnCarrega.Click += new System.EventHandler(this.btnCarrega_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(518, 234);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 32);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // ltbEstado
            // 
            this.ltbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbEstado.FormattingEnabled = true;
            this.ltbEstado.ItemHeight = 20;
            this.ltbEstado.Location = new System.Drawing.Point(518, 78);
            this.ltbEstado.Name = "ltbEstado";
            this.ltbEstado.Size = new System.Drawing.Size(120, 124);
            this.ltbEstado.TabIndex = 4;
            this.ltbEstado.SelectedIndexChanged += new System.EventHandler(this.ltbEstado_SelectedIndexChanged);
            // 
            // btnCarregalista
            // 
            this.btnCarregalista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregalista.Location = new System.Drawing.Point(16, 208);
            this.btnCarregalista.Name = "btnCarregalista";
            this.btnCarregalista.Size = new System.Drawing.Size(142, 35);
            this.btnCarregalista.TabIndex = 5;
            this.btnCarregalista.Text = "Carrega Lista";
            this.btnCarregalista.UseVisualStyleBackColor = true;
            this.btnCarregalista.Click += new System.EventHandler(this.btnCarregalista_Click);
            // 
            // lblCarregaLabel
            // 
            this.lblCarregaLabel.AutoSize = true;
            this.lblCarregaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregaLabel.Location = new System.Drawing.Point(192, 208);
            this.lblCarregaLabel.Name = "lblCarregaLabel";
            this.lblCarregaLabel.Size = new System.Drawing.Size(0, 20);
            this.lblCarregaLabel.TabIndex = 6;
            // 
            // lblEstados2
            // 
            this.lblEstados2.AutoSize = true;
            this.lblEstados2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstados2.Location = new System.Drawing.Point(523, 37);
            this.lblEstados2.Name = "lblEstados2";
            this.lblEstados2.Size = new System.Drawing.Size(68, 20);
            this.lblEstados2.TabIndex = 7;
            this.lblEstados2.Text = "Estados";
            // 
            // btnCarregaLabel
            // 
            this.btnCarregaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaLabel.Location = new System.Drawing.Point(16, 249);
            this.btnCarregaLabel.Name = "btnCarregaLabel";
            this.btnCarregaLabel.Size = new System.Drawing.Size(142, 32);
            this.btnCarregaLabel.TabIndex = 8;
            this.btnCarregaLabel.Text = "Carrega Label";
            this.btnCarregaLabel.UseVisualStyleBackColor = true;
            this.btnCarregaLabel.Click += new System.EventHandler(this.btnCarregaLabel_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(397, 78);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(0, 13);
            this.lblLista.TabIndex = 9;
            // 
            // Estados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(650, 397);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btnCarregaLabel);
            this.Controls.Add(this.lblEstados2);
            this.Controls.Add(this.lblCarregaLabel);
            this.Controls.Add(this.btnCarregalista);
            this.Controls.Add(this.ltbEstado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCarrega);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.lblEstados);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Estados";
            this.Text = "frmEstados2";
            this.Load += new System.EventHandler(this.frmEstados2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.Button btnCarrega;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListBox ltbEstado;
        private System.Windows.Forms.Button btnCarregalista;
        private System.Windows.Forms.Label lblCarregaLabel;
        private System.Windows.Forms.Label lblEstados2;
        private System.Windows.Forms.Button btnCarregaLabel;
        private System.Windows.Forms.Label lblLista;
    }
}