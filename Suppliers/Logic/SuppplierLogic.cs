using Common.Dtos;
using Common.Interfaces;
using Domain.Database;
using Domain.Database.Interfaces;
using Domain.Database.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Suppliers.Logic
{
    public class SuppplierLogic
    {
        private readonly ISupplierRepository _supplierRepository;

        public SuppplierLogic()
        {
            _supplierRepository = new SupplierRepository();
        }


        public IBaseMapper<Supplier, SupplierDto> Mapper { get { return _supplierRepository.Mapper; } }

        public async Task<IEnumerable<SupplierDto>> LoadSuppliers()
        {
            return await _supplierRepository.FindAllAsync();
        }

        public async Task<bool> DeleteSupplier(SupplierDto dto)
        {
            return await _supplierRepository.DeleteAsync(dto);
        }

        public async Task<SupplierDto> SaveSupplier(SupplierDto dto)
        {
            return await _supplierRepository.SaveAsync(dto);
        }
    }
}
