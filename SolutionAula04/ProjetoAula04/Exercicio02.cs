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
    public partial class Exercicio02 : Form
    {
        public Exercicio02()
        {
            InitializeComponent();
        }

        private void Exercicio02_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double not1, not2, not3, not4, media;

            not1 = Convert.ToDouble(txtNota1.Text);
            not2 = Convert.ToDouble(txtNota2.Text);
            not3 = Convert.ToDouble(txtNota3.Text);
            not4 = Convert.ToDouble(txtNota4.Text);

            media = (not1 + not2 + not3 + not4) / 4;

            lblMedia.Text = String.Format("{0}", media);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
