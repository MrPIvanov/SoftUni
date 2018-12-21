using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P03_SalesDatabase.Data.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        public double Quantity { get; set; }

        public decimal Price { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Description { get; set; }

        public int SaleId { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
