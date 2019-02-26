using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class frmTestedavariavel : Form
    {
        bool bandeira = false;

        public frmTestedavariavel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "Senac Largo 13";
            lblMostrar2.Text = "Turma TI92";
            lblNum.Text = "1";
        }

        private void lblMostrar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "Senac Largo 13";
            lblMostrar2.Text = "Turma TI92";

        }

        private void btnBandeira_Click(object sender, EventArgs e)
        {
            bandeira = true;

            lblBandeira.Text = bandeira.ToString();

        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            bandeira = false;
           
        
            lblMostrar.Text = " ";
            lblMostrar2.Text = " ";
            lblNum.Text = "0";
            lblBandeira.Text = bandeira.ToString();

        }
    }
}
