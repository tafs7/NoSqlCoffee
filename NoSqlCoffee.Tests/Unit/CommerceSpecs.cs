using FluentAssertions;
using NoSqlCoffee.Domain.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NoSqlCoffee.Tests.Unit
{
    public class CommerceSpecs
    {
        [Fact]
        public void Adding_item_to_cart_should_add_specified_qty_of_item()
        {
            var cart = GetCartWithSameItems(5);
            var items = cart.GetAllItems();
            items.Should().HaveCount(5);
            items[0].Sku.Should().Be("123");
        }

        [Fact]
        public void Removing_item_from_cart_should_remove_all_quantities_of_specified_item()
        {
            var cart = GetCartWithSameItems(5);
            cart.RemoveItem(0);
            cart.GetAllItems().Should().BeEmpty();
        }

        private Cart GetCartWithSameItems(int itemCount)
        {

            var cart = new Cart(User.Anonymous);
            cart.AddItem(new Product("test", "123", "test item", 2.50m), itemCount);

            return cart;
        }
    }
}
