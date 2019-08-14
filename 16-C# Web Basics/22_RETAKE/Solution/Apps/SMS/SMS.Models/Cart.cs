using System;
using System.Collections;
using System.Collections.Generic;

namespace SMS.Models
{
    public class Cart
    {
        public Cart()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Products = new HashSet<Product>();
        }

        public string Id { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
