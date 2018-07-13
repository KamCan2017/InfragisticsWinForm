using Domain.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Database.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {

        public async Task<IEnumerable<Supplier>> FindAllAsync()
        {
            using (var context = new BloggingContext())
            {
                return await context.Suppliers.ToListAsync();
            }
        }
    }
}
