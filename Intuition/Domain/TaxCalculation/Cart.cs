using Intuition.Domain.Models;
using System.Collections.Generic;


namespace Intuition.Domain.TaxCalculation
{
    public class Cart
    {
        private List<Product> ProductList { get; }

        public Cart()
        {
            ProductList = new List<Product>();
        }

        public void AddItemToCart(Product product)
        {
            ProductList.Add(product);
        }

        public List<Product> GetItemsFromCart()
        {
            return ProductList;
        }

    }
}
