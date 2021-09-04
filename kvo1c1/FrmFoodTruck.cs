using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kvo1c1
{
    public partial class FrmFoodTruck : Form
    {
        public FrmFoodTruck()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtHotDogSubtotal.Text = (
                4.0m * Convert.ToDecimal(txtHotDogs.Text)
                ).ToString("0.00");
            txtHamburgerSubtotal.Text = (
               5.0m * Convert.ToDecimal(txtHamburgers.Text)
               ).ToString("0.00");
            txtPretaxTotal.Text = (
               Convert.ToDecimal(txtHotDogSubtotal.Text) + Convert.ToDecimal(txtHamburgerSubtotal.Text)
               ).ToString("0.00");
            txtTax.Text = (
               Convert.ToDecimal(txtPretaxTotal.Text) * 0.06875m
               ).ToString("0.00");
            txtTotal.Text = (
                Convert.ToDecimal(txtTax.Text) + Convert.ToDecimal(txtPretaxTotal.Text)).ToString("0.00");





            btnClear.Focus();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHamburgerSubtotal.Text = "";
            txtHotDogSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
            txtHotDogs.Focus();
        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
