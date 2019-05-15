using System;
using System.Windows.Forms;

namespace Hotel_Management.Bill
{
    public partial class BillDetailForm : Form
    {
        public BillDetailForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTaxDetail_Click(object sender, EventArgs e)
        {
            var TaxForm = new BillTaxForm();
            TaxForm.ShowDialog();
        }
    }
}
