using MongoDB.Driver.Core.Connections;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localhost; port=5432; Database=CustomerDb; user Id=postgres; password=5227";
        void EmployeeList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Employees";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
        void DeparmentsList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Departments";
            var command = new NpgsqlCommand( query, connection);    
            var adapter = new NpgsqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            cmbEmployeDepartment.DisplayMember = "DepartmentName";
            cmbEmployeDepartment.ValueMember = "DepartmentId";
            cmbEmployeDepartment.DataSource = dataTable;
            connection.Close();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            EmployeeList();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            EmployeeList();
            DeparmentsList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmployeName.Text;
            string employeeSurname = txtEmployeSurname.Text;
            decimal employeeSalary = decimal.Parse(txtEmployeSalary.Text);
            int departmentId = int.Parse(cmbEmployeDepartment.SelectedValue.ToString());
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Insert into Employess (EmployeeName, EmployeeSurname, EmployeeSalary, DepartmentId) Values (@employeName, @employeSurname, @employeSalary, @departmentId)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@employeName", employeeName);
            command.Parameters.AddWithValue("@employeSurname", employeeSurname);
            command.Parameters.AddWithValue("@employeSalary", employeeSalary);
            command.Parameters.AddWithValue("@departmentId", departmentId);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ekleme işlemi başrılı.");

        }
    }
}
