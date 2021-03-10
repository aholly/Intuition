using Intuition.Domain.Models;
using System;
using System.Collections.Generic;

namespace Intuition.Domain.TaxCalculation
{
    public class CartTotal
    {
        private IEnumerable<Product> ProductList { get; }
        private decimal TotalSalesTax { get; }
        private decimal TotalAmount { get; }

        public CartTotal(IEnumerable<Product> prod, decimal tax, decimal amount)
        {
            ProductList = prod;
            TotalSalesTax = tax;
            TotalAmount = amount;
        }



        public override string ToString()
        {
            string cartTotal = "";
            Console.WriteLine("***************");
            foreach (var p in ProductList)
            {
                cartTotal += p + "\n";
            }

            cartTotal += "Total sales tax = " + TotalSalesTax + "\n";
            cartTotal += "Total amount = " + TotalAmount + "\n";

            return cartTotal;
        }
    }
}
