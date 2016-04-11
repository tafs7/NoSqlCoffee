using NoSqlCoffee.Domain.Common;
using System;

namespace NoSqlCoffee.Domain.Models.Commerce
{
    public class Product : Entity
    {
        public virtual string Name { get; set; }
        public virtual string Sku { get; set; }
        public virtual string Description { get; set; }
        public decimal ListPrice { get; set; }

        public Product(string name, string sku, string description, decimal listPrice)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("name");

            if (string.IsNullOrWhiteSpace(sku))
                throw new ArgumentNullException("sku");

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentNullException("description");

            if (listPrice < 0m)
                throw new ArgumentOutOfRangeException("listPrice", "List price must be greater than or equal to zero.");

            Sku = sku;
            Name = name;
            Description = description;
            ListPrice = listPrice;
        }
    }
}
