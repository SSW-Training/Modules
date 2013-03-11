using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccess;
using System.Data.Entity;

namespace WindowsUI
{
    public partial class OrdersForm : Form
    {

        private NorthwindEntities db;

        public OrdersForm(int employeeID)
        {
            InitializeComponent();

            db = new NorthwindEntities();
            db.Orders.Where(o=>o.EmployeeID==employeeID).OrderBy(o=>o.OrderDate).Load();
            orderBindingSource.DataSource = db.Orders.Local.ToBindingList();

        }
    }
}
