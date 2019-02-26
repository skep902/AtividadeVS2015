using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Simples
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void txtVar1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resu = 0;

            num1 = Convert.ToDouble(txtVar1.Text);
            num2 = Convert.ToDouble(txtVar2.Text);
            resu = num1 + num2;
            lblResul.Text = resu.ToString();

            if (rdbAdicao.Checked)
            {
                resu = num1 + num2;
                lblResul.Text = resu.ToString();
            }
            if (rdbSubtracao.Checked)
            {
                resu = num1 - num2;
                lblResul.Text = resu.ToString();
            }
            if (rdbMultiplicacao.Checked)
            {
                resu = num1 * num2;
                lblResul.Text = resu.ToString();
            }
            if (rdbDivisao.Checked)
            {
                resu = num1 / num2;
                lblResul.Text = resu.ToString();
            }
            if (rdbDivisao.Checked)
            {
                num2 = 0;
                lblResul.Text = "Impossível dividir por 0";
            }




        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbDivisao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVar1.Text = " ";
            txtVar2.Text = " ";
            lblResul.Text = " ";


        }
    }
}
