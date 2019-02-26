using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAula04
{
    public partial class Exercicio03 : Form
    {
        public Exercicio03()
        {
            InitializeComponent();
        }

        private void btnAumento5_Click(object sender, EventArgs e)
        {
            double salo, aumento;

            salo = Convert.ToDouble(txtSal.Text);
            aumento = salo * 1.05;
            lblSal2.Text = String.Format("{0:c}", aumento);
        }

        private void btnAumento10_Click(object sender, EventArgs e)
        {
            double salo, aumento;

            salo = Convert.ToDouble(txtSal.Text);
            aumento = salo * 1.10;

            lblSal2.Text = String.Format("{0:c}", aumento);
        }

        private void btnAumento15_Click(object sender, EventArgs e)
        {
            double salo, aumento;

            salo = Convert.ToDouble(txtSal.Text);
            aumento = salo * 1.15;

            lblSal2.Text = String.Format("{0:c}", aumento);
        }

        private void btnAumento20_Click(object sender, EventArgs e)
        {
            double salo, aumento;

            salo = Convert.ToDouble(txtSal.Text);
            aumento = salo * 1.20;

            lblSal2.Text = String.Format("{0:c}", aumento);
        }
    }
}
