using Common.Dtos;
using Common.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Database.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<CustomerDto>> FindAllAsync();

        Task<CustomerDto> SaveAsync(CustomerDto entity);

        IBaseMapper<Customer, CustomerDto> Mapper { get; }
    }
}