using System.Data;
using Employees.Data;

namespace Employees
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            PopulateEmployee();
        }

        private void PopulateEmployee()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("E-Mail");
            dataTable.Columns.Add("Job Title");

            var data = new EmployeeData();
            var employees = data.GetEmployees();

            foreach (var employee in employees)
            {
                var row = dataTable.NewRow();
                row["ID"] = employee.Id;
                row["Name"] = employee.FirstName + " " + employee.LastName;
                row["E-Mail"] = employee.Email;
                row["Job Title"] = employee.JobTitle;

                dataTable.Rows.Add(row);
            }

            this.employeeGrid.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdate addUpdate = new AddUpdate();
            if (addUpdate.ShowDialog() == DialogResult.OK)
                PopulateEmployee();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = this.employeeGrid.SelectedRows[0].Cells[0].Value.ToString();
            if (id == null || id.Length == 0)
                return;

            int employeeId = int.Parse(id);

            var data = new EmployeeData();
            var employee = data.GetEmployee(employeeId);
            if (employee == null)
                return;

            AddUpdate addUpdate = new AddUpdate();
            addUpdate.UpdateEmployee(employee);
            if (addUpdate.ShowDialog() == DialogResult.OK)
                PopulateEmployee();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = this.employeeGrid.SelectedRows[0].Cells[0].Value.ToString();
            if (id == null || id.Length == 0)
                return;

            int employeeId = int.Parse(id);

            DialogResult dialogResult = MessageBox.Show("Do you really want to delete this employee?", 
                "Delete Employee", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
                return;

            var data = new EmployeeData();
            data.DeleteEmployee(employeeId);
            PopulateEmployee(); 
        }
    }
}
