using Common.Dtos;
using Common.Interfaces;
using Domain.Database;
using Domain.Database.Interfaces;
using Domain.Database.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customers.Logic
{
    public class CustomerLogic
    {
        private ICustomerRepository _customerRepository;

        public CustomerLogic()
        {
            _customerRepository = new CustomerRepository();
        }

        public IBaseMapper<Customer, CustomerDto> Mapper { get { return _customerRepository.Mapper; } }

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

        public async Task<IEnumerable<CustomerDto>> LoadCustomers()
        {
            return await _customerRepository.FindAllAsync();
        }

        public async Task<CustomerDto> SaveCustomer(CustomerDto model)
        {
            return await _customerRepository.SaveAsync(model);
        }

        public bool IsModelValid(CustomerDto customer)
        {
            if (customer == null)
                return false;

            if (string.IsNullOrEmpty(customer.Name) || string.IsNullOrEmpty(customer.Continent))
                return false;

            if (customer.Age < 18)
                return false;

            return true;
        }
    }
}
