﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class CustomerForm : Form
    {
        public string FormType { get; set; }
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            switch (this.Tag)
            {
                case "AddForm":
                    {
                        this.lbCustomerHeader.Text = this.Text = "THÊM THÔNG TIN KHÁCH";
                        this.lbCustomerHeader.Left = (this.ClientSize.Width - lbCustomerHeader.Size.Width) / 2 + 32;
                        this.imgCustomer.Left = this.lbCustomerHeader.Left - 45;
                        break;
                    }

                case "EditForm":
                    {
                        this.lbCustomerHeader.Text = this.Text = "THAY ĐỔI THÔNG TIN KHÁCH";
                        break;
                    }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}