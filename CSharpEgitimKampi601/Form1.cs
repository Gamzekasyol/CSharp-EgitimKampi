using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Services;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CustomerOperations customerOperations= new CustomerOperations();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerName = txtCustomerName.Text,
                CustomerSurname = txtCutomerSurname.Text,
                CustomerCity = txtCustomerCity.Text,
                CustomerBalance = decimal.Parse(txtCustomerBalance.Text),
                CustomerShoppingCount = int.Parse(txtCustomerTotalPrice.Text),
            };
            customerOperations.Addcustomer(customer);
        MessageBox.Show("Ekleme işlemi başarılı", "Uyarı");
        }

    
        private void btnDelete_Click(object sender, EventArgs e)
        {
            customerOperations.DeleteCustomer(txtCustomerId.Text);
            MessageBox.Show("Silme işlemi başarılı", "Uyarı");
        }

        private void btnList_Click_1(object sender, EventArgs e)
        {

            dataGridView1.DataSource = customerOperations.GetAllCostomer();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text;
            var customer = new Customer
            {
                CustomerName = txtCustomerName.Text,
                CustomerSurname = txtCutomerSurname.Text,
                CustomerCity = txtCustomerCity.Text,
                CustomerBalance = decimal.Parse(txtCustomerBalance.Text),
                CustomerShoppingCount = int.Parse(txtCustomerTotalPrice.Text),
                CustomerId = id
            };
            customerOperations.UpdateCustomer(customer);
            MessageBox.Show("Güncelleme işlemi başarılı", "Uyarı");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text;
            Customer customer = customerOperations.GetCustomerById(id);
            dataGridView1.DataSource = new List<Customer> { customer };
        }
    }
}
