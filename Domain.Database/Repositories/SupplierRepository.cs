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
    public class SupplierRepository : ISupplierRepository
    {
        private SupplierMapper _supplierMapper;

        public SupplierRepository()
        {
            _supplierMapper = new SupplierMapper();
        }

        public IBaseMapper<Supplier, SupplierDto> Mapper { get { return _supplierMapper; } }


        public async Task<SupplierDto> SaveAsync(SupplierDto dto)
        {
            var entity = Mapper.Convert(dto);
            entity.Id = Guid.NewGuid();

            using (var context = new BloggingContext())
            {
                var obj = context.Suppliers.Add(entity);
                await context.SaveChangesAsync();
                return Mapper.Convert(obj);
            }
        }

        public async Task<IEnumerable<SupplierDto>> FindAllAsync()
        {
            using (var context = new BloggingContext())
            {
                return Mapper.Convert(await context.Suppliers.ToListAsync());
            }
        }

        public async Task<bool> DeleteAsync(SupplierDto dto)
        {
            if (dto == null)
                return false;

            using (var context = new BloggingContext())
            {
                var objToDelete = await context.Suppliers.FirstOrDefaultAsync(d => d.Id == dto.Id);
                if (objToDelete == null)
                    return false;

                context.Suppliers.Remove(objToDelete);
                await context.SaveChangesAsync();
                return true;
            }
        }
    }
}
