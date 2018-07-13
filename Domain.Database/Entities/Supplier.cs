namespace Domain.Database
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Supplier
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Column(Order = 1)]
        [StringLength(200)]
        public string Name { get; set; }

        [Column(Order = 2)]
        [StringLength(50)]
        public string Place { get; set; }

        [Column(Order = 3)]
        public int Employees { get; set; }
    }
}
