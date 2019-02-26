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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool logica = true;
            int num = 45;
            float nreal = 3.75f;
            double nreal2 = 17.99d;
            decimal salario = 900.99m;

            label1.Text = "Valor Lógico: " + logica.ToString();
            label1.Text += "\n";
            label1.Text += "Valor Inteiro: " + num.ToString();
            //label1.Text += "\nValores reais: " + nreal.ToString() + ", " + nreal2.ToString
            //() + " e " + salario.ToString();
            label1.Text += String.Format(
                "\nValores reais: {0}, {1} e {2:c}",
                nreal, nreal2, salario);





        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2, soma;

            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            soma = num1 + num2;

            label2.Text = String.Format("{0} + {1} = {2}", num1, num2, soma);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1, num2, subtrai;

            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            subtrai = num1 - num2;

            label2.Text = String.Format("{0} - {1} = {2}", num1, num2, subtrai);


        }
    }
}
