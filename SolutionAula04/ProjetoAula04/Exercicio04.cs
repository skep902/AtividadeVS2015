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
    public partial class Exercicio04 : Form
    {
        public Exercicio04()
        {
            InitializeComponent();
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            double contador;

           
            contador = Convert.ToDouble(lblClique.Text);

            pictureBox1.Width += +5;
            pictureBox1.Height += +5;

            lblClique.Text = String.Format("{0}", contador + 1);

        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = 160;
            pictureBox1.Height = 100;
        }

        private void btnReduz_Click(object sender, EventArgs e)
        {
            double contador;


            contador = Convert.ToDouble(lblClique.Text);

            pictureBox1.Width += -5;
            pictureBox1.Height += -5;

            lblClique.Text = String.Format("{0}", contador + 1);
        }
    }
}
