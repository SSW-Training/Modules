using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SSW.Training.WebUI
{
    public partial class Wizard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowCustomerDetails();
            }
        }


        private void ShowCustomerDetails()
        {
            CustomerDetailsPanel.Visible = true;
            PaymentDetailsPanel.Visible = false;
        }
        private void ShowPaymentDetails()
        {
            CustomerDetailsPanel.Visible = false;
            PaymentDetailsPanel.Visible = true;
        }

        protected void NextButton_Click(object sender, EventArgs e)
        {
            ShowPaymentDetails();
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            ShowCustomerDetails();
        }


    }
}