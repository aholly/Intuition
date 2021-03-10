using Intuition.Domain.Models;
using System.Collections.Generic;

namespace Intuition.Domain.TaxCalculation
{
    public interface IBill
    {
        public decimal CalcTotalTax(IEnumerable<Product> prodList);

        public decimal CalculateTax(decimal price, decimal tax);

        public decimal CalcTotalProductCost(decimal price, decimal tax);

        public decimal CalcTotalAmount(List<Product> prodList);
        public CartTotal CreateNewReceipt(List<Product> productList, decimal totalTax, decimal totalAmount);

        public void GenerateReceipt(CartTotal r);
    }
}
