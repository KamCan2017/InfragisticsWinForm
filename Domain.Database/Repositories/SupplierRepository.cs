using Common.Dtos;
using Common.Interfaces;
using Domain.Database.Interfaces;
using Domain.Database.Mapper;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Domain.Database.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private SupplierMapper _supplierMapper;

        public SupplierRepository()
        {
            _supplierMapper = new SupplierMapper();
        }

        public IBaseMapper<Supplier, SupplierDto> Mapper { get { return _supplierMapper; } }

        public async Task<IEnumerable<SupplierDto>> FindAllAsync()
        {
            using (var context = new BloggingContext())
            {
                return Mapper.Convert(await context.Suppliers.ToListAsync());
            }
        }
    }
}
