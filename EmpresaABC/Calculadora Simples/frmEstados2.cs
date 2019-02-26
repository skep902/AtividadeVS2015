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
    public partial class Estados : Form
    {
        public Estados()
        {
            InitializeComponent();
            carregaLista();
            carregaCombo();
        }

        private void btnCarrega_Click(object sender, EventArgs e)
        {
            carregaCombo();
        }

        private void frmEstados2_Load(object sender, EventArgs e)
        {
            //cboEstados.Items.Clear();
            //cboEstados.Items.Add("São Paulo");
            //cboEstados.Items.Add("Osasco");
            //cboEstados.Items.Add("Carapicuiba");
            //cboEstados.Items.Add("Paula");
        }

        private void cboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltbEstado.Text = cboEstados.Text;
            //lblCarregaLabel.Text = cboEstados.SelectedItem.ToString();
            //Selected.Index
            
        }
        public void carregaCombo()
        {
            cboEstados.Items.Clear();
            cboEstados.Items.Add("São Paulo");
            cboEstados.Items.Add("Osasco");
            cboEstados.Items.Add("Carapicuiba");
            cboEstados.Items.Add("Paula");
        }

        private void btnCarregalista_Click(object sender, EventArgs e)
        {
            ltbEstado.Items.Clear();
            ltbEstado.Items.Add("Vasco");
            ltbEstado.Items.Add("Carapicuiba");
            ltbEstado.Items.Add("São Paulo");
            ltbEstado.Items.Add("Minas Gerais");
        }
        private void carregaLista()
        {
            ltbEstado.Items.Clear();
            ltbEstado.Items.Add("Vasco");
            ltbEstado.Items.Add("Carapicuiba");
            ltbEstado.Items.Add("São Paulo");
            ltbEstado.Items.Add("Minas Gerais");
        }

        private void btnCarregaLabel_Click(object sender, EventArgs e)
        {
            //lblCarregaLabel.Text = cboEstados.Text;
            lblCarregaLabel.Text = cboEstados.SelectedItem.ToString();

        }

        private void ltbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblLista.Text = ltbEstado.Text;
            lblLista.Text = ltbEstado.SelectedItem.ToString();
        }
    }
}
