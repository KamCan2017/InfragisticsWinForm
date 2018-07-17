using System;

namespace Common.Dtos
{
    public class SupplierDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Place { get; set; }

        public int Employees { get; set; }
    }
}
