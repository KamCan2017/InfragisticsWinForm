using Common.Constants;
using System;
using System.Linq;
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

            Load += CustomersView_Load;

            _customersLogic = new Logic.CustomerLogic();
        }

        private async Task UpdateInfoCustomer()
        {
            var customers = await _customersLogic.LoadCustomers();

            var count = customers.Where(d => d.Continent == Continent.Africa).Count();
            africaButton.Text = Continent.Africa + string.Format(" ({0})", count);

            count = customers.Where(d => d.Continent == Continent.Europe).Count();
            europeButton.Text = Continent.Europe + string.Format(" ({0})", count);

            count = customers.Where(d => d.Continent == Continent.NordAmerica).Count();
            nordAmericaButton.Text = Continent.NordAmerica + string.Format(" ({0})", count);
        }

        private async void CustomersView_Load(object sender, EventArgs e)
        {
            await UpdateInfoCustomer();
        }

        private void africaButton_Click(object sender, EventArgs e)
        {
            _customersLogic.OpenCustomerAfrica();
        }

        private void europeButton_Click(object sender, EventArgs e)
        {
            _customersLogic.OpenCustomerEu();
        }

        private void nordAmericaButton_Click(object sender, EventArgs e)
        {
            _customersLogic.OpenCustomerNordAmerica();
        }

        private async void addCustomers_Click(object sender, EventArgs e)
        {
            var addCustomer = new AddCustomerView(_customersLogic);
            addCustomer.ShowDialog();
            await UpdateInfoCustomer();
        }
    }
}
