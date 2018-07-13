namespace Domain.Database
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Customer
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Column(Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Age { get; set; }
    }
}
