using System;

namespace SMS.Models
{
    public class Product
    {
        public Product()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string CartId { get; set; }

        public Cart Cart { get; set; }

    }
}
