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
    public partial class Exercicio : Form
    {
        public Exercicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nasc, idade, resul;

            nasc = Convert.ToInt16(textBox1.Text);
            idade = Convert.ToInt16(textBox2.Text);
            resul = idade - nasc;

            label3.Text = String.Format("{0}", resul);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double vraio, area;
            

            vraio = Convert.ToDouble(textBox3.Text);
            area = Math.PI * (vraio * vraio);
            label5.Text = String.Format("{0} cm²", area);




        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, c, delta, rdelta, x1, x2;

            
            a = Convert.ToDouble(textBox4.Text);
            b = Convert.ToDouble(textBox5.Text);
            c = Convert.ToDouble(textBox6.Text);

            delta = b * b - 4 * a * c;
            rdelta = Math.Sqrt(delta);
            x1 = (-b + rdelta) / 2 * a;
            x2 = (-b - rdelta) / 2 * a;

            label11.Text = String.Format("{0}", x1);
            label12.Text = String.Format("{0}", x2);
        }
    }
}
