﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P03_SalesDatabase.Data.Models
{
    public class Store
    {
        [Key]
        public int StoreId { get; set; }

        [Column(TypeName = "nvarchar(80)")]
        public string Name { get; set; }

        public int SaleId { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
