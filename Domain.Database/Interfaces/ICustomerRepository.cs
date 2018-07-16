using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Database.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> FindAllAsync();

        Task<Customer> SaveAsync(Customer entity);
    }
}