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
    /// 1. Explain the code
    /// 2. Open the page in two different browsers
    /// 3. Refresh the page in each different browser
    /// </summary>

    public partial class SessionAndAppStateDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IncrementApplicationState();

            IncrementSessionState();

            RefreshDisplay();
        }

        private void IncrementApplicationState()
        {
            if (Application["pageLoadCount"] == null)
            {
                Application["pageLoadCount"] = 0;
            }

            int number = (int) Application["pageLoadCount"];
            number++;
            Application["pageLoadCount"] = number;
        }

        private void IncrementSessionState()
        {
            if (Session["pageLoadCount"] == null)
            {
                Session["pageLoadCount"] = 0;
            }

            int number = (int)Session["pageLoadCount"];
            number++;
            Session["pageLoadCount"] = number;
        }

        private void RefreshDisplay()
        {
            SessionStateLabel.Text = Session["pageLoadCount"].ToString();

            ApplicationStateLabel.Text = Application["pageLoadCount"].ToString();
        }
    }
}