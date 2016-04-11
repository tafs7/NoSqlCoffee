using NoSqlCoffee.Domain.Common;
using System.Collections.Generic;
using System.Linq;

namespace NoSqlCoffee.Domain.Models.Commerce
{
    public class Cart : AggregateRoot
    {
        public virtual User Owner { get; protected set; }
        protected virtual List<Product> Items { get; }

        public Cart(User owner)
        {
            Owner = owner;
            Items = new List<Product>();
        }

        public IReadOnlyList<Product> GetAllItems()
        {
            return Items.OrderBy(i => i.Name).ToList();
        }

        public void AddItem(Product item, int quantity)
        {
            if (item != null && quantity > 0)
            {
                for (int i = 0; i < quantity; i++)
                {
                    Items.Add(item);
                }
            }
        }

        public void RemoveItem(long id)
        {
            Items.RemoveAll(i => i.Id == id);
        }
    }
}
