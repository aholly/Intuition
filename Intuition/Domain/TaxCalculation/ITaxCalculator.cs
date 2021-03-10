namespace Intuition.Domain.TaxCalculation
{
    /// <summary>
    /// It Computes Total Tax Cost of a Product.
    /// </summary>
    public interface ITaxCalculator
    {

        /// <summary>
        /// Calculates Tax for a Product where Tax Cost is the Sum of Sales Tax 
        /// </summary>
        /// <param name="price">The Price of the Product.</param>
        /// <param name="tax">The Tax Rate of the Product.</param>    
        /// <returns></returns>
        decimal CalculateTax(decimal price, decimal tax);
    }
}
