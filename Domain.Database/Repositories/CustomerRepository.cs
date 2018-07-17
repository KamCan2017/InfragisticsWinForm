using Common.Dtos;
using Common.Interfaces;
using Domain.Database.Interfaces;
using Domain.Database.Mapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Domain.Database.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private CustomerMapper _customerMapper;


        public CustomerRepository()
        {
            _customerMapper = new CustomerMapper();
        }

        public IBaseMapper<Customer, CustomerDto> Mapper { get { return _customerMapper; } }

        public async Task<CustomerDto> SaveAsync(CustomerDto dto)
        {
            var entity = _customerMapper.Convert(dto);
            entity.Id = Guid.NewGuid();

            using (var context = new BloggingContext())
            {
                var obj = context.Customers.Add(entity);
                await context.SaveChangesAsync();
                return Mapper.Convert(obj);
            }
        }

        public async Task<IEnumerable<CustomerDto>> FindAllAsync()
        {
            using (var context = new BloggingContext())
            {
                return Mapper.Convert(await context.Customers.ToListAsync());
            }
        }
    }
}
