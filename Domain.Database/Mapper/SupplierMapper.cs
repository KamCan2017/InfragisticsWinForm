using Common.Dtos;
using Common.Mapper;
using System.Collections.Generic;

namespace Domain.Database.Mapper
{
    public class SupplierMapper: BaseMapper<Supplier, SupplierDto>
    {
        public override SupplierDto Convert(Supplier source)
        {
            var dest = base.Convert(source);
            dest.Id = source.Id;
            dest.Name = source.Name;
            dest.Place = source.Place;
            dest.Employees = source.Employees;

            return dest;
        }

        public override Supplier Convert(SupplierDto source)
        {
            var dest = base.Convert(source);
            dest.Id = source.Id;
            dest.Name = source.Name;
            dest.Place = source.Place;
            dest.Employees = source.Employees;

            return dest;
        }

        public override IEnumerable<SupplierDto> Convert(IEnumerable<Supplier> source)
        {
            var dest = new List<SupplierDto>();

            foreach (var s in source)
                dest.Add(Convert(s));

            return dest;
        }

        public override IEnumerable<Supplier> Convert(IEnumerable<SupplierDto> source)
        {
            var dest = new List<Supplier>();

            foreach (var s in source)
                dest.Add(Convert(s));

            return dest;
        }
    }
}
