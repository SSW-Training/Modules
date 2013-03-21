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
    /// 1. Add a Breakpoint on IsPostback, and on the Button1_Click
    /// 2. Request the page
    /// 3. Notice that the value of IsPostback is false
    ///      and that the initial value of the textbox is set
    /// 4. Click the button
    /// 5. Notice that IsPostBack is true
    /// </summary>
    
    public partial class PostbackDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

            }
            else
            {
                TextBox1.Text = "Class";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Welcome, " + TextBox1.Text;
        }
    }
}