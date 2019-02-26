namespace Atividade.cs
{
    partial class frmGerenciarFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarFornecedores));
            this.btnVoltarForne = new System.Windows.Forms.Button();
            this.pnlFornecedores = new System.Windows.Forms.Panel();
            this.lblFormularioForne = new System.Windows.Forms.Label();
            this.lblCodForne = new System.Windows.Forms.Label();
            this.txtCodForne = new System.Windows.Forms.TextBox();
            this.lblNomeEmpresaForne = new System.Windows.Forms.Label();
            this.txtNomeEmpresaForne = new System.Windows.Forms.TextBox();
            this.lblEnderecoForne = new System.Windows.Forms.Label();
            this.txtEnderecoForne = new System.Windows.Forms.TextBox();
            this.lblEmailForne = new System.Windows.Forms.Label();
            this.txtEmailForne = new System.Windows.Forms.TextBox();
            this.lblTelefoneForne = new System.Windows.Forms.Label();
            this.txtTelefoneForne = new System.Windows.Forms.TextBox();
            this.lblSexoForne = new System.Windows.Forms.Label();
            this.rdbMascForne = new System.Windows.Forms.RadioButton();
            this.rdbFemiForne = new System.Windows.Forms.RadioButton();
            this.lblCpfForne = new System.Windows.Forms.Label();
            this.mdbCpfForne = new System.Windows.Forms.MaskedTextBox();
            this.lblCidadeForne = new System.Windows.Forms.Label();
            this.txtCidadeForne = new System.Windows.Forms.TextBox();
            this.btnNovoForne = new System.Windows.Forms.Button();
            this.btnCadastrarForne = new System.Windows.Forms.Button();
            this.btnAlterarForne = new System.Windows.Forms.Button();
            this.btnApagarForne = new System.Windows.Forms.Button();
            this.btnBuscarForne = new System.Windows.Forms.Button();
            this.pnlFornecedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltarForne
            // 
            this.btnVoltarForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarForne.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarForne.Image")));
            this.btnVoltarForne.Location = new System.Drawing.Point(577, 414);
            this.btnVoltarForne.Name = "btnVoltarForne";
            this.btnVoltarForne.Size = new System.Drawing.Size(111, 36);
            this.btnVoltarForne.TabIndex = 5;
            this.btnVoltarForne.Text = "Volta&r";
            this.btnVoltarForne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltarForne.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltarForne.UseVisualStyleBackColor = true;
            // 
            // pnlFornecedores
            // 
            this.pnlFornecedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlFornecedores.Controls.Add(this.txtCidadeForne);
            this.pnlFornecedores.Controls.Add(this.lblCidadeForne);
            this.pnlFornecedores.Controls.Add(this.mdbCpfForne);
            this.pnlFornecedores.Controls.Add(this.lblCpfForne);
            this.pnlFornecedores.Controls.Add(this.rdbFemiForne);
            this.pnlFornecedores.Controls.Add(this.rdbMascForne);
            this.pnlFornecedores.Controls.Add(this.lblSexoForne);
            this.pnlFornecedores.Controls.Add(this.txtTelefoneForne);
            this.pnlFornecedores.Controls.Add(this.lblTelefoneForne);
            this.pnlFornecedores.Controls.Add(this.txtEmailForne);
            this.pnlFornecedores.Controls.Add(this.lblEmailForne);
            this.pnlFornecedores.Controls.Add(this.txtEnderecoForne);
            this.pnlFornecedores.Controls.Add(this.lblEnderecoForne);
            this.pnlFornecedores.Controls.Add(this.txtNomeEmpresaForne);
            this.pnlFornecedores.Controls.Add(this.lblNomeEmpresaForne);
            this.pnlFornecedores.Controls.Add(this.txtCodForne);
            this.pnlFornecedores.Controls.Add(this.lblCodForne);
            this.pnlFornecedores.Location = new System.Drawing.Point(12, 52);
            this.pnlFornecedores.Name = "pnlFornecedores";
            this.pnlFornecedores.Size = new System.Drawing.Size(676, 326);
            this.pnlFornecedores.TabIndex = 6;
            // 
            // lblFormularioForne
            // 
            this.lblFormularioForne.AutoSize = true;
            this.lblFormularioForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormularioForne.Location = new System.Drawing.Point(267, 9);
            this.lblFormularioForne.Name = "lblFormularioForne";
            this.lblFormularioForne.Size = new System.Drawing.Size(140, 29);
            this.lblFormularioForne.TabIndex = 0;
            this.lblFormularioForne.Text = "Formulário";
            // 
            // lblCodForne
            // 
            this.lblCodForne.AutoSize = true;
            this.lblCodForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodForne.Location = new System.Drawing.Point(21, 10);
            this.lblCodForne.Name = "lblCodForne";
            this.lblCodForne.Size = new System.Drawing.Size(171, 20);
            this.lblCodForne.TabIndex = 0;
            this.lblCodForne.Text = "Código do Fornecedor:";
            // 
            // txtCodForne
            // 
            this.txtCodForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodForne.Location = new System.Drawing.Point(21, 37);
            this.txtCodForne.Name = "txtCodForne";
            this.txtCodForne.Size = new System.Drawing.Size(204, 26);
            this.txtCodForne.TabIndex = 0;
            this.txtCodForne.TextChanged += new System.EventHandler(this.txtCodForne_TextChanged);
            // 
            // lblNomeEmpresaForne
            // 
            this.lblNomeEmpresaForne.AutoSize = true;
            this.lblNomeEmpresaForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresaForne.Location = new System.Drawing.Point(21, 73);
            this.lblNomeEmpresaForne.Name = "lblNomeEmpresaForne";
            this.lblNomeEmpresaForne.Size = new System.Drawing.Size(145, 20);
            this.lblNomeEmpresaForne.TabIndex = 2;
            this.lblNomeEmpresaForne.Text = "Nome da Empresa:";
            // 
            // txtNomeEmpresaForne
            // 
            this.txtNomeEmpresaForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEmpresaForne.Location = new System.Drawing.Point(21, 100);
            this.txtNomeEmpresaForne.Name = "txtNomeEmpresaForne";
            this.txtNomeEmpresaForne.Size = new System.Drawing.Size(204, 26);
            this.txtNomeEmpresaForne.TabIndex = 1;
            // 
            // lblEnderecoForne
            // 
            this.lblEnderecoForne.AutoSize = true;
            this.lblEnderecoForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoForne.Location = new System.Drawing.Point(21, 132);
            this.lblEnderecoForne.Name = "lblEnderecoForne";
            this.lblEnderecoForne.Size = new System.Drawing.Size(82, 20);
            this.lblEnderecoForne.TabIndex = 4;
            this.lblEnderecoForne.Text = "Endereço:";
            // 
            // txtEnderecoForne
            // 
            this.txtEnderecoForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoForne.Location = new System.Drawing.Point(21, 159);
            this.txtEnderecoForne.Name = "txtEnderecoForne";
            this.txtEnderecoForne.Size = new System.Drawing.Size(204, 26);
            this.txtEnderecoForne.TabIndex = 2;
            // 
            // lblEmailForne
            // 
            this.lblEmailForne.AutoSize = true;
            this.lblEmailForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailForne.Location = new System.Drawing.Point(21, 191);
            this.lblEmailForne.Name = "lblEmailForne";
            this.lblEmailForne.Size = new System.Drawing.Size(149, 20);
            this.lblEmailForne.TabIndex = 6;
            this.lblEmailForne.Text = "Email para Contato:";
            // 
            // txtEmailForne
            // 
            this.txtEmailForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailForne.Location = new System.Drawing.Point(21, 218);
            this.txtEmailForne.Name = "txtEmailForne";
            this.txtEmailForne.Size = new System.Drawing.Size(203, 26);
            this.txtEmailForne.TabIndex = 3;
            // 
            // lblTelefoneForne
            // 
            this.lblTelefoneForne.AutoSize = true;
            this.lblTelefoneForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneForne.Location = new System.Drawing.Point(21, 250);
            this.lblTelefoneForne.Name = "lblTelefoneForne";
            this.lblTelefoneForne.Size = new System.Drawing.Size(75, 20);
            this.lblTelefoneForne.TabIndex = 8;
            this.lblTelefoneForne.Text = "Telefone:";
            // 
            // txtTelefoneForne
            // 
            this.txtTelefoneForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneForne.Location = new System.Drawing.Point(21, 277);
            this.txtTelefoneForne.Name = "txtTelefoneForne";
            this.txtTelefoneForne.Size = new System.Drawing.Size(203, 26);
            this.txtTelefoneForne.TabIndex = 4;
            // 
            // lblSexoForne
            // 
            this.lblSexoForne.AutoSize = true;
            this.lblSexoForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoForne.Location = new System.Drawing.Point(332, 37);
            this.lblSexoForne.Name = "lblSexoForne";
            this.lblSexoForne.Size = new System.Drawing.Size(49, 20);
            this.lblSexoForne.TabIndex = 10;
            this.lblSexoForne.Text = "Sexo:";
            this.lblSexoForne.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdbMascForne
            // 
            this.rdbMascForne.AutoSize = true;
            this.rdbMascForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMascForne.Location = new System.Drawing.Point(407, 39);
            this.rdbMascForne.Name = "rdbMascForne";
            this.rdbMascForne.Size = new System.Drawing.Size(98, 24);
            this.rdbMascForne.TabIndex = 5;
            this.rdbMascForne.TabStop = true;
            this.rdbMascForne.Text = "Masculino";
            this.rdbMascForne.UseVisualStyleBackColor = true;
            // 
            // rdbFemiForne
            // 
            this.rdbFemiForne.AutoSize = true;
            this.rdbFemiForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemiForne.Location = new System.Drawing.Point(527, 39);
            this.rdbFemiForne.Name = "rdbFemiForne";
            this.rdbFemiForne.Size = new System.Drawing.Size(92, 24);
            this.rdbFemiForne.TabIndex = 6;
            this.rdbFemiForne.TabStop = true;
            this.rdbFemiForne.Text = "Feminino";
            this.rdbFemiForne.UseVisualStyleBackColor = true;
            // 
            // lblCpfForne
            // 
            this.lblCpfForne.AutoSize = true;
            this.lblCpfForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfForne.Location = new System.Drawing.Point(332, 90);
            this.lblCpfForne.Name = "lblCpfForne";
            this.lblCpfForne.Size = new System.Drawing.Size(44, 20);
            this.lblCpfForne.TabIndex = 13;
            this.lblCpfForne.Text = "CPF:";
            // 
            // mdbCpfForne
            // 
            this.mdbCpfForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdbCpfForne.Location = new System.Drawing.Point(407, 90);
            this.mdbCpfForne.Mask = "999,999,999-99";
            this.mdbCpfForne.Name = "mdbCpfForne";
            this.mdbCpfForne.Size = new System.Drawing.Size(140, 26);
            this.mdbCpfForne.TabIndex = 7;
            // 
            // lblCidadeForne
            // 
            this.lblCidadeForne.AutoSize = true;
            this.lblCidadeForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeForne.Location = new System.Drawing.Point(332, 148);
            this.lblCidadeForne.Name = "lblCidadeForne";
            this.lblCidadeForne.Size = new System.Drawing.Size(63, 20);
            this.lblCidadeForne.TabIndex = 15;
            this.lblCidadeForne.Text = "Cidade:";
            // 
            // txtCidadeForne
            // 
            this.txtCidadeForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeForne.Location = new System.Drawing.Point(407, 148);
            this.txtCidadeForne.Name = "txtCidadeForne";
            this.txtCidadeForne.Size = new System.Drawing.Size(176, 26);
            this.txtCidadeForne.TabIndex = 8;
            // 
            // btnNovoForne
            // 
            this.btnNovoForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoForne.Location = new System.Drawing.Point(12, 419);
            this.btnNovoForne.Name = "btnNovoForne";
            this.btnNovoForne.Size = new System.Drawing.Size(95, 31);
            this.btnNovoForne.TabIndex = 7;
            this.btnNovoForne.Text = "Novo";
            this.btnNovoForne.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarForne
            // 
            this.btnCadastrarForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarForne.Location = new System.Drawing.Point(113, 419);
            this.btnCadastrarForne.Name = "btnCadastrarForne";
            this.btnCadastrarForne.Size = new System.Drawing.Size(95, 31);
            this.btnCadastrarForne.TabIndex = 8;
            this.btnCadastrarForne.Text = "Cadastrar";
            this.btnCadastrarForne.UseVisualStyleBackColor = true;
            // 
            // btnAlterarForne
            // 
            this.btnAlterarForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarForne.Location = new System.Drawing.Point(214, 419);
            this.btnAlterarForne.Name = "btnAlterarForne";
            this.btnAlterarForne.Size = new System.Drawing.Size(95, 31);
            this.btnAlterarForne.TabIndex = 9;
            this.btnAlterarForne.Text = "Alterar";
            this.btnAlterarForne.UseVisualStyleBackColor = true;
            // 
            // btnApagarForne
            // 
            this.btnApagarForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarForne.Location = new System.Drawing.Point(315, 419);
            this.btnApagarForne.Name = "btnApagarForne";
            this.btnApagarForne.Size = new System.Drawing.Size(95, 31);
            this.btnApagarForne.TabIndex = 10;
            this.btnApagarForne.Text = "Apagar";
            this.btnApagarForne.UseVisualStyleBackColor = true;
            // 
            // btnBuscarForne
            // 
            this.btnBuscarForne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarForne.Location = new System.Drawing.Point(416, 419);
            this.btnBuscarForne.Name = "btnBuscarForne";
            this.btnBuscarForne.Size = new System.Drawing.Size(95, 31);
            this.btnBuscarForne.TabIndex = 11;
            this.btnBuscarForne.Text = "Buscar";
            this.btnBuscarForne.UseVisualStyleBackColor = true;
            // 
            // frmGerenciarFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(700, 457);
            this.Controls.Add(this.btnBuscarForne);
            this.Controls.Add(this.btnApagarForne);
            this.Controls.Add(this.btnAlterarForne);
            this.Controls.Add(this.btnCadastrarForne);
            this.Controls.Add(this.btnNovoForne);
            this.Controls.Add(this.lblFormularioForne);
            this.Controls.Add(this.pnlFornecedores);
            this.Controls.Add(this.btnVoltarForne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerenciarFornecedores";
            this.Text = "Gerenciamento de Fornecedores";
            this.pnlFornecedores.ResumeLayout(false);
            this.pnlFornecedores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarForne;
        private System.Windows.Forms.Panel pnlFornecedores;
        private System.Windows.Forms.Label lblFormularioForne;
        private System.Windows.Forms.TextBox txtTelefoneForne;
        private System.Windows.Forms.Label lblTelefoneForne;
        private System.Windows.Forms.TextBox txtEmailForne;
        private System.Windows.Forms.Label lblEmailForne;
        private System.Windows.Forms.TextBox txtEnderecoForne;
        private System.Windows.Forms.Label lblEnderecoForne;
        private System.Windows.Forms.TextBox txtNomeEmpresaForne;
        private System.Windows.Forms.Label lblNomeEmpresaForne;
        private System.Windows.Forms.TextBox txtCodForne;
        private System.Windows.Forms.Label lblCodForne;
        private System.Windows.Forms.Label lblSexoForne;
        private System.Windows.Forms.TextBox txtCidadeForne;
        private System.Windows.Forms.Label lblCidadeForne;
        private System.Windows.Forms.MaskedTextBox mdbCpfForne;
        private System.Windows.Forms.Label lblCpfForne;
        private System.Windows.Forms.RadioButton rdbFemiForne;
        private System.Windows.Forms.RadioButton rdbMascForne;
        private System.Windows.Forms.Button btnNovoForne;
        private System.Windows.Forms.Button btnCadastrarForne;
        private System.Windows.Forms.Button btnAlterarForne;
        private System.Windows.Forms.Button btnApagarForne;
        private System.Windows.Forms.Button btnBuscarForne;
    }
}