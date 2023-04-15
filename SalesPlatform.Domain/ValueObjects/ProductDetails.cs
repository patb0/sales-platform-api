using SalesPlatform.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Domain.ValueObjects
{
    public class ProductDetails : ValueObject
    {
        public string ProducerName { get; private set; }
        public string Country { get; private set; }
        public string Color { get; private set; }

        public ProductDetails(string producerName, string country, string color)
        {
            ProducerName = producerName;
            Country = country;
            Color = color;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return ProducerName;
            yield return Country;
            yield return Color;
        }
    }
}
