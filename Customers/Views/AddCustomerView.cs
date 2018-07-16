using Customers.Logic;
using Domain.Database;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Customers.Views
{
    public partial class AddCustomerView : Form
    {
        private CustomerLogic _customerLogic;
        public AddCustomerView()
        {
            InitializeComponent();
            Icon = new Icon("buying.ico");
        }

        public AddCustomerView(CustomerLogic customerLogic):this()
        {
            _customerLogic = customerLogic;
        }

        private async void save_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Name = textBox1.Text,
                Age = (int)numericUpDown1.Value,
                Continent = (string)comboBox1.SelectedItem
            };

            if(!_customerLogic.IsModelValid(customer))
            {
                MessageBox.Show("Invalid Inputs", "Error", MessageBoxButtons.OK);
                return;
            }

            try
            {
                await _customerLogic.SaveCustomer(customer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);               
            }
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
