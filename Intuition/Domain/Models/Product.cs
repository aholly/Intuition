using Intuition.Domain.TaxCalculation;
using System;

namespace Intuition.Domain.Models
{


    public class Product
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }

        public decimal TaxedCost { get; set; }


        // Should use strategy pattern here with abstract class for localisation 
        public decimal GetTaxValue(string country)
        {
            if (country == "us")
                return LocalisationTaxValues.Us;
            else
                return LocalisationTaxValues.Ca;
        }


    }

}
