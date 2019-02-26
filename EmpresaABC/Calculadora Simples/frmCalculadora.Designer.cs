namespace Calculadora_Simples
{
    partial class frmCalculadora
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
            this.gpbOperador = new System.Windows.Forms.GroupBox();
            this.rdbAdicao = new System.Windows.Forms.RadioButton();
            this.rdbSubtracao = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdbDivisao = new System.Windows.Forms.RadioButton();
            this.lblVar1 = new System.Windows.Forms.Label();
            this.lblVar2 = new System.Windows.Forms.Label();
            this.txtVar1 = new System.Windows.Forms.TextBox();
            this.txtVar2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResul = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSair = new System.Windows.Forms.Button();
            this.gpbOperador.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbOperador
            // 
            this.gpbOperador.Controls.Add(this.rdbDivisao);
            this.gpbOperador.Controls.Add(this.rdbMultiplicacao);
            this.gpbOperador.Controls.Add(this.rdbSubtracao);
            this.gpbOperador.Controls.Add(this.rdbAdicao);
            this.gpbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOperador.Location = new System.Drawing.Point(22, 150);
            this.gpbOperador.Name = "gpbOperador";
            this.gpbOperador.Size = new System.Drawing.Size(200, 163);
            this.gpbOperador.TabIndex = 0;
            this.gpbOperador.TabStop = false;
            this.gpbOperador.Text = "Operador";
            // 
            // rdbAdicao
            // 
            this.rdbAdicao.AutoSize = true;
            this.rdbAdicao.Location = new System.Drawing.Point(6, 19);
            this.rdbAdicao.Name = "rdbAdicao";
            this.rdbAdicao.Size = new System.Drawing.Size(109, 24);
            this.rdbAdicao.TabIndex = 0;
            this.rdbAdicao.TabStop = true;
            this.rdbAdicao.Text = "Adição (+)";
            this.rdbAdicao.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            this.rdbSubtracao.AutoSize = true;
            this.rdbSubtracao.Location = new System.Drawing.Point(7, 43);
            this.rdbSubtracao.Name = "rdbSubtracao";
            this.rdbSubtracao.Size = new System.Drawing.Size(133, 24);
            this.rdbSubtracao.TabIndex = 1;
            this.rdbSubtracao.TabStop = true;
            this.rdbSubtracao.Text = "Subtração (-)";
            this.rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            this.rdbMultiplicacao.AutoSize = true;
            this.rdbMultiplicacao.Location = new System.Drawing.Point(6, 67);
            this.rdbMultiplicacao.Name = "rdbMultiplicacao";
            this.rdbMultiplicacao.Size = new System.Drawing.Size(155, 24);
            this.rdbMultiplicacao.TabIndex = 2;
            this.rdbMultiplicacao.TabStop = true;
            this.rdbMultiplicacao.Text = "Multiplicação (*)";
            this.rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbDivisao
            // 
            this.rdbDivisao.AutoSize = true;
            this.rdbDivisao.Location = new System.Drawing.Point(7, 91);
            this.rdbDivisao.Name = "rdbDivisao";
            this.rdbDivisao.Size = new System.Drawing.Size(107, 24);
            this.rdbDivisao.TabIndex = 3;
            this.rdbDivisao.TabStop = true;
            this.rdbDivisao.Text = "Divisão (/)";
            this.rdbDivisao.UseVisualStyleBackColor = true;
            this.rdbDivisao.CheckedChanged += new System.EventHandler(this.rdbDivisao_CheckedChanged);
            // 
            // lblVar1
            // 
            this.lblVar1.AutoSize = true;
            this.lblVar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVar1.Location = new System.Drawing.Point(18, 36);
            this.lblVar1.Name = "lblVar1";
            this.lblVar1.Size = new System.Drawing.Size(78, 20);
            this.lblVar1.TabIndex = 1;
            this.lblVar1.Text = "Variável 1";
            // 
            // lblVar2
            // 
            this.lblVar2.AutoSize = true;
            this.lblVar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVar2.Location = new System.Drawing.Point(18, 84);
            this.lblVar2.Name = "lblVar2";
            this.lblVar2.Size = new System.Drawing.Size(78, 20);
            this.lblVar2.TabIndex = 2;
            this.lblVar2.Text = "Variável 2";
            // 
            // txtVar1
            // 
            this.txtVar1.Location = new System.Drawing.Point(122, 36);
            this.txtVar1.Name = "txtVar1";
            this.txtVar1.Size = new System.Drawing.Size(145, 20);
            this.txtVar1.TabIndex = 3;
            this.txtVar1.TextChanged += new System.EventHandler(this.txtVar1_TextChanged);
            // 
            // txtVar2
            // 
            this.txtVar2.Location = new System.Drawing.Point(122, 86);
            this.txtVar2.Name = "txtVar2";
            this.txtVar2.Size = new System.Drawing.Size(145, 20);
            this.txtVar2.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(261, 150);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(90, 20);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado :";
            // 
            // lblResul
            // 
            this.lblResul.Location = new System.Drawing.Point(265, 192);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(131, 49);
            this.lblResul.TabIndex = 7;
            this.lblResul.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCalcular.Location = new System.Drawing.Point(22, 366);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(81, 40);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpar.Location = new System.Drawing.Point(158, 366);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(81, 40);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblSair
            // 
            this.lblSair.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSair.Location = new System.Drawing.Point(302, 366);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(81, 40);
            this.lblSair.TabIndex = 10;
            this.lblSair.Text = "Sair";
            this.lblSair.UseVisualStyleBackColor = false;
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 421);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtVar2);
            this.Controls.Add(this.txtVar1);
            this.Controls.Add(this.lblVar2);
            this.Controls.Add(this.lblVar1);
            this.Controls.Add(this.gpbOperador);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora Simples";
            this.gpbOperador.ResumeLayout(false);
            this.gpbOperador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbOperador;
        private System.Windows.Forms.RadioButton rdbDivisao;
        private System.Windows.Forms.RadioButton rdbMultiplicacao;
        private System.Windows.Forms.RadioButton rdbSubtracao;
        private System.Windows.Forms.RadioButton rdbAdicao;
        private System.Windows.Forms.Label lblVar1;
        private System.Windows.Forms.Label lblVar2;
        private System.Windows.Forms.TextBox txtVar1;
        private System.Windows.Forms.TextBox txtVar2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button lblResul;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button lblSair;
    }
}