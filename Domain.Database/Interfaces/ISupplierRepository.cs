using Common.Dtos;
using Common.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Database.Interfaces
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<SupplierDto>> FindAllAsync();

        IBaseMapper<Supplier, SupplierDto> Mapper { get; }
    }
}