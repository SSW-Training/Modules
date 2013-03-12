using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SSW.Training.WebUI
{

    /// <summary>
    /// Instructions:
    ///     1. Open the master page and explain it
    ///     2. Open the aspx page and explain it
    ///     3. Load the page in the browser and show that it works the same
    /// </summary>

    public partial class MasterPageDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Welcome, " + TextBox1.Text;
        }
    }
}