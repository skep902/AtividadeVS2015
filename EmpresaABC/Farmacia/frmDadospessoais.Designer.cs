namespace Farmacia
{
    partial class frmDadospessoais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDadospessoais));
            this.lblDadospessoais = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.ckbCrianca = new System.Windows.Forms.CheckBox();
            this.ckbJovem = new System.Windows.Forms.CheckBox();
            this.ckbAdulto = new System.Windows.Forms.CheckBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lbtEscolha = new System.Windows.Forms.ListBox();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDadospessoais
            // 
            this.lblDadospessoais.AutoSize = true;
            this.lblDadospessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadospessoais.Location = new System.Drawing.Point(236, 9);
            this.lblDadospessoais.Name = "lblDadospessoais";
            this.lblDadospessoais.Size = new System.Drawing.Size(138, 20);
            this.lblDadospessoais.TabIndex = 0;
            this.lblDadospessoais.Text = "Dados Pessoais";
            this.lblDadospessoais.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(55, 53);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(55, 97);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(56, 20);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(55, 141);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(55, 181);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(116, 20);
            this.lblDepartamento.TabIndex = 4;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(144, 55);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(371, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(144, 97);
            this.txtCargo.MaxLength = 50;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(371, 20);
            this.txtCargo.TabIndex = 1;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(144, 141);
            this.txtTelefone.MaxLength = 30;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 2;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Items.AddRange(new object[] {
            "Recursos Humanos",
            "Secretaria",
            "Administração Central",
            "Almoxarifado"});
            this.cboDepartamento.Location = new System.Drawing.Point(177, 180);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(338, 21);
            this.cboDepartamento.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(59, 386);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(133, 34);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(346, 386);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(133, 34);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Volta&r";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sexo:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasculino.Location = new System.Drawing.Point(130, 222);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(98, 24);
            this.rdbMasculino.TabIndex = 3;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFeminino.Location = new System.Drawing.Point(346, 222);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(92, 24);
            this.rdbFeminino.TabIndex = 4;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // ckbCrianca
            // 
            this.ckbCrianca.AutoSize = true;
            this.ckbCrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCrianca.Location = new System.Drawing.Point(130, 277);
            this.ckbCrianca.Name = "ckbCrianca";
            this.ckbCrianca.Size = new System.Drawing.Size(68, 19);
            this.ckbCrianca.TabIndex = 5;
            this.ckbCrianca.Text = "Criança";
            this.ckbCrianca.UseVisualStyleBackColor = true;
            // 
            // ckbJovem
            // 
            this.ckbJovem.AutoSize = true;
            this.ckbJovem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbJovem.Location = new System.Drawing.Point(130, 304);
            this.ckbJovem.Name = "ckbJovem";
            this.ckbJovem.Size = new System.Drawing.Size(62, 19);
            this.ckbJovem.TabIndex = 6;
            this.ckbJovem.Text = "Jovem";
            this.ckbJovem.UseVisualStyleBackColor = true;
            // 
            // ckbAdulto
            // 
            this.ckbAdulto.AutoSize = true;
            this.ckbAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAdulto.Location = new System.Drawing.Point(130, 329);
            this.ckbAdulto.Name = "ckbAdulto";
            this.ckbAdulto.Size = new System.Drawing.Size(60, 19);
            this.ckbAdulto.TabIndex = 7;
            this.ckbAdulto.Text = "Adulto";
            this.ckbAdulto.UseVisualStyleBackColor = true;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(55, 274);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 13;
            this.lblTipo.Text = "Tipo:";
            // 
            // lbtEscolha
            // 
            this.lbtEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtEscolha.FormattingEnabled = true;
            this.lbtEscolha.ItemHeight = 20;
            this.lbtEscolha.Items.AddRange(new object[] {
            "Calça",
            "Camisa",
            "Gravata",
            "Saia"});
            this.lbtEscolha.Location = new System.Drawing.Point(359, 265);
            this.lbtEscolha.Name = "lbtEscolha";
            this.lbtEscolha.Size = new System.Drawing.Size(156, 104);
            this.lbtEscolha.TabIndex = 14;
            this.lbtEscolha.SelectedIndexChanged += new System.EventHandler(this.lbtEscolha_SelectedIndexChanged);
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolha.Location = new System.Drawing.Point(270, 274);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(70, 20);
            this.lblEscolha.TabIndex = 15;
            this.lblEscolha.Text = "Escolha:";
            // 
            // frmDadospessoais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 459);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.lbtEscolha);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.ckbAdulto);
            this.Controls.Add(this.ckbJovem);
            this.Controls.Add(this.ckbCrianca);
            this.Controls.Add(this.rdbFeminino);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cboDepartamento);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblDadospessoais);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDadospessoais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmácia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDadospessoais;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.CheckBox ckbCrianca;
        private System.Windows.Forms.CheckBox ckbJovem;
        private System.Windows.Forms.CheckBox ckbAdulto;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ListBox lbtEscolha;
        private System.Windows.Forms.Label lblEscolha;
    }
}