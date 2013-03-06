using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1201_WinForms_Intro
{
    public partial class MainSwitchboardForm : Form
    {
        public MainSwitchboardForm()
        {
            InitializeComponent();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            OpenCustomerForm();
        }
  
        private void OpenCustomerForm()
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCustomerForm();
        }

        private void MainSwitchboardForm_Load(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToShortDateString();
        }
    }
}
