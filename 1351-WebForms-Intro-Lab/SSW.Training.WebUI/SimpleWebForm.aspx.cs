using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SSW.Training.WebUI
{
    public partial class SimpleWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ResultLabel.Text = "Page_Load";
        }

        protected void TestButton_Click(object sender, EventArgs e)
        {
            ResultLabel.Text = DateTime.Now.ToString();
        }
    }
}