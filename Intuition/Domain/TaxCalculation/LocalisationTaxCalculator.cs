namespace Intuition.Domain.TaxCalculation
{
    /// <summary>
    /// It Calculates Total Tax Cost According to Local Region Specification.
    /// </summary>
    public class LocalisationTaxCalculator : ITaxCalculator
    {
        public decimal CalculateTax(decimal price, decimal localTax)
        {
            decimal tax = price * localTax;
            return tax;
        }
    }
}
