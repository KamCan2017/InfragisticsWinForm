using Domain.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Domain.Database.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public async Task<Customer> SaveAsync(Customer entity)
        {
            entity.Id = Guid.NewGuid();

            using (var context = new BloggingContext())
            {
                var obj = context.Customers.Add(entity);
                await context.SaveChangesAsync();
                return obj;
            }
        }

        public async Task<IEnumerable<Customer>> FindAllAsync()
        {
            using (var context = new BloggingContext())
            {
                return await context.Customers.ToListAsync();
            }
        }
    }
}
