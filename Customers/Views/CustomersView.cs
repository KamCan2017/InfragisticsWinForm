using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customers.Views
{
    public partial class CustomersView : UserControl
    {
        private Customers.Logic.CustomerLogic _customersLogic;

        public CustomersView()
        {
            InitializeComponent();

            _customersLogic = new Logic.CustomerLogic();
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            _customersLogic.OpenCustomerEu();
        }

        private void ultraButton2_Click(object sender, EventArgs e)
        {
            _customersLogic.OpenCustomerNordAmerica();
        }

        private void ultraButton3_Click(object sender, EventArgs e)
        {
            _customersLogic.OpenCustomerAfrica();
        }
    }
}
