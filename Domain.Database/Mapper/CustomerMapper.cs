using Common.Dtos;
using Common.Mapper;
using System.Collections.Generic;

namespace Domain.Database.Mapper
{
    public class CustomerMapper: BaseMapper<Customer, CustomerDto>
    {
        public override CustomerDto Convert(Customer source)
        {
            var dest = base.Convert(source);
            dest.Id = source.Id;
            dest.Name = source.Name;
            dest.Age = source.Age;
            dest.Continent = source.Continent;

            return dest;
        }

        public override Customer Convert(CustomerDto source)
        {
            var dest = base.Convert(source);
            dest.Id = source.Id;
            dest.Name = source.Name;
            dest.Age = source.Age;
            dest.Continent = source.Continent;

            return dest;
        }

        public override IEnumerable<CustomerDto> Convert(IEnumerable<Customer> source)
        {
            var dest = new List<CustomerDto>();

            foreach (var s in source)
                dest.Add(Convert(s));

            return dest;
        }

        public override IEnumerable<Customer> Convert(IEnumerable<CustomerDto> source)
        {
            var dest = new List<Customer>();

            foreach (var s in source)
                dest.Add(Convert(s));

            return dest;
        }
    }
}
