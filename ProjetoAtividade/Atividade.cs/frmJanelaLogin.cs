using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade.cs
{
    public partial class frmJanelaLogin : Form
    {
        public frmJanelaLogin()
        {
            InitializeComponent();
        }

        private void JanelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = "pedroeduardo902@gmail.com";
            string senha = "123456pedro";

            if ((txtUsuario.Text.Equals(usuario)) && (txtSenha.Text.Equals(senha))) 
            {
                MessageBox.Show("Acesso Concedido");
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Acesso Negado");
            }
            
           
            
        }
    }
}
