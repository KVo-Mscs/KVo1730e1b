using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KVo1730e1b
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //txtTotal.Text = "10";
            //txtTotal.ReadOnly = false;
            txtDiscountamount.Text = 
                (Convert.ToDecimal (txtSubtotal.Text) * Convert.ToDecimal(txtDiscountpercent.Text)/ 100).ToString("0.00");
            txtTotal.Text =
                (Convert.ToDecimal(txtSubtotal.Text) - Convert.ToDecimal(txtDiscountamount.Text)).ToString("0.00");

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInvoiceTotal_Load(object sender, EventArgs e)
        {
           
        }
    }
}
