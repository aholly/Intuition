using System.Collections.Generic;

namespace Intuition.Domain.TaxCalculation
{
    public class TaxCalculatorFactory
    {
        private readonly Dictionary<string, ITaxCalculator> _taxCalculators;

        public TaxCalculatorFactory()
        {
            _taxCalculators = new Dictionary<string, ITaxCalculator>();
            RegisterInFactory("us", new LocalisationTaxCalculator());
            RegisterInFactory("ca", new LocalisationTaxCalculator());
        }

        public void RegisterInFactory(string strategy, ITaxCalculator taxCalc)
        {
            _taxCalculators.Add(strategy, taxCalc);
        }

        public ITaxCalculator GetTaxCalculator(string strategy)
        {
            ITaxCalculator taxCalc = _taxCalculators[strategy];
            return taxCalc;
        }

    }
}
