using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSW.Training.WebUI.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get { return string.Format("{0} {1}",FirstName, LastName); } }
    }
}