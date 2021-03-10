using Intuition.Domain.Models;
using System.Collections.Generic;

namespace Intuition.Domain.TaxCalculation
{
    public class Payment
    {
        private IBill _bill;
        private CartTotal _receipt;
        private List<Product> _productList;
        private readonly string _country;

        public Payment(string country)
        {
            this._country = country;
        }

        public void Calculate(Cart cart)
        {
            _productList = cart.GetItemsFromCart();

            foreach (Product p in _productList)
            {
                _bill = GetBill(_country);
                decimal productTax = _bill.CalculateTax(p.Price, p.GetTaxValue(_country));
                decimal taxedCost = _bill.CalcTotalProductCost(p.Price, productTax);
                p.TaxedCost = taxedCost;
            }
        }

        public CartTotal GetReceipt()
        {
            decimal totalTax = _bill.CalcTotalTax(_productList);
            decimal totalAmount = _bill.CalcTotalAmount(_productList);
            _receipt = _bill.CreateNewReceipt(_productList, totalTax, totalAmount);
            return _receipt;
        }

        public void PrintReceipt(CartTotal receipt)
        {
            _bill.GenerateReceipt(receipt);
        }

        public IBill GetBill(string strategy)
        {
            TaxCalculatorFactory factory = new TaxCalculatorFactory();
            ITaxCalculator taxCal = factory.GetTaxCalculator(strategy);
            return new Bill(taxCal);
        }
    }
}
