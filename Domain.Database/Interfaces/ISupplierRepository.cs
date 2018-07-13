using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Database.Interfaces
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<Supplier>> FindAllAsync();
    }
}