using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Models;
using Npgsql;
using NpgsqlTypes;

namespace Employees.Data
{
    public class EmployeeData
    {
        string connectionString = "server=localhost;port=5432;userid=postgres;password=123;database=postgres";

        public void DeleteEmployee(int id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM employee WHERE id = @id";
    
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string sql = "UPDATE employee SET first_name = @first_name, last_name = @last_name, " +
                             "email = @email, job_title = @job_title " +
                             "WHERE id = @id";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@first_name", employee.FirstName);
                    command.Parameters.AddWithValue("@last_name", employee.LastName);
                    command.Parameters.AddWithValue("@email", employee.Email);
                    command.Parameters.AddWithValue("@job_title", employee.JobTitle);
                    command.Parameters.AddWithValue("@id", employee.Id); 

                    command.ExecuteNonQuery();
                }
            }
        }


        public void AddEmployee(Employee employee)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO employee (first_name, last_name, email, job_title) " +
                             "VALUES(@first_name, @last_name, @email, @jobtitle)";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@first_name", employee.FirstName);
                    command.Parameters.AddWithValue("@last_name", employee.LastName);
                    command.Parameters.AddWithValue("@email", employee.Email);
                    command.Parameters.AddWithValue("@jobtitle", employee.JobTitle);

                    command.ExecuteNonQuery();
                }
            }
        }

        public Employee? GetEmployee(int id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM employee WHERE id = @id";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.Id = reader.GetInt32(0);
                            employee.FirstName = reader.GetString(1);
                            employee.LastName = reader.GetString(2);
                            employee.Email = reader.GetString(3);
                            employee.JobTitle = reader.GetString(4);

                            return employee;
                        }
                    }
                }
            }
            return null;
        }

        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM employee ORDER BY id DESC";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", 1);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.Id = reader.GetInt32(0);
                            employee.FirstName = reader.GetString(1);
                            employee.LastName = reader.GetString(2);
                            employee.Email = reader.GetString(3);
                            employee.JobTitle = reader.GetString(4);

                            employees.Add(employee);
                        }
                    }
                }
            }
            return employees;
        }
    }

   
    
}
