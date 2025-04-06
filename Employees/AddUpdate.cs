using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees.Data;
using Employees.Models;

namespace Employees
{
    public partial class AddUpdate : Form
    {
        private int employeeId = 0;
        public AddUpdate()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        public void UpdateEmployee(Employee employee)
        {
            this.Text = "Update Emplyee";
            this.lbTitle.Text = "Update Employee";
            this.lbEmployeeId.Text = "" + employee.Id;
            this.tbFirstName.Text = employee.FirstName;
            this.tbLastName.Text = employee.LastName;
            this.tbEmail.Text = employee.Email;
            this.tbJobTitle.Text = employee.JobTitle;
            this.employeeId = employee.Id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Id = this.employeeId;
            employee.FirstName = this.tbFirstName.Text;
            employee.LastName = this.tbLastName.Text;
            employee.Email = this.tbEmail.Text;
            employee.JobTitle = this.tbJobTitle.Text;

            var data = new EmployeeData();
            
            if (employee.Id == 0)
                data.AddEmployee(employee);
            else
                data.UpdateEmployee(employee);
            
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
