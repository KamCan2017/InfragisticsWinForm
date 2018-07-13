namespace Customers.Logic
{
    public class CustomerLogic
    {
        public void OpenCustomerEu()
        {
            System.Windows.Forms.MessageBox.Show("Europe customers", "Customers", System.Windows.Forms.MessageBoxButtons.OK);
        }

        public void OpenCustomerNordAmerica()
        {
            System.Windows.Forms.MessageBox.Show("Nord America customers", "Customers", System.Windows.Forms.MessageBoxButtons.OK);
        }

        public void OpenCustomerAfrica()
        {
            System.Windows.Forms.MessageBox.Show("Africa customers", "Customers", System.Windows.Forms.MessageBoxButtons.OK);
        }
    }
}
