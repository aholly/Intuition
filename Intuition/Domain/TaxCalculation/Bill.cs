using Intuition.Domain.Models;
using System;
using System.Collections.Generic;

namespace Intuition.Domain.TaxCalculation
{
    public class Bill : IBill
    {
        readonly ITaxCalculator _taxCalculator;

        public Bill(ITaxCalculator taxCalc)
        {
            _taxCalculator = taxCalc;
        }

        public decimal CalculateTax(decimal price, decimal tax)
        {

            decimal totalProductTax = _taxCalculator.CalculateTax(price, tax);
            return totalProductTax;
        }

        public decimal CalcTotalProductCost(decimal price, decimal tax)
        {
            return price + tax;
        }

        public decimal CalcTotalTax(IEnumerable<Product> prodList)
        {
            decimal totalTax = 0.0M;

            foreach (Product p in prodList)
            {
                totalTax += p.TaxedCost - p.Price;
            }

            return totalTax;
        }

        public decimal CalcTotalAmount(List<Product> prodList)
        {
            decimal totalAmount = 0.0M;

            foreach (Product p in prodList)
            {
                totalAmount += p.TaxedCost;
            }

            return totalAmount;
        }

        public CartTotal CreateNewReceipt(List<Product> productList, decimal totalTax, decimal totalAmount)
        {
            return new CartTotal(productList, totalTax, totalAmount);
        }

        public void GenerateReceipt(CartTotal r)
        {
            string receipt = r.ToString();
            Console.WriteLine(receipt);
        }

    }
}
