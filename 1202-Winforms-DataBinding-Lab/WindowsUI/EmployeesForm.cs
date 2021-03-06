﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using DataAccess;

namespace WindowsUI
{
    public partial class EmployeesForm : Form
    {
        private NorthwindEntities db;
        public EmployeesForm()
        {
            InitializeComponent();

            db = new NorthwindEntities();
            db.Employees.OrderBy(e=>e.LastName).Load();
            employeeBindingSource.DataSource = db.Employees.Local.ToBindingList();
        }

        //note: this worked in Linq to SQL
        //db = new NorthwindEntities();
        //var employeeQuery = from employee in db.Employees
        //                    orderby employee.LastName
        //                    select employee;
        //employeeBindingSource.DataSource = employeeQuery;
        

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            db.SaveChanges();
            MessageBox.Show("Records are updated");

        }

        private void employeeBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Employee();
        }

        private void ShowOrderButton_Click(object sender, EventArgs e)
        {
            var employee = employeeBindingSource.Current as Employee;
            
            if (employee == null) return;

            var orderForm = new OrdersForm(employee.EmployeeID);

            orderForm.ShowDialog();

            

        }
    }
}
