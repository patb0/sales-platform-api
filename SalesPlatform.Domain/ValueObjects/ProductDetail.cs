using SalesPlatform.Domain.Common;
using SalesPlatform.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Domain.ValueObjects
{
    public class ProductDetail : ValueObject
    {
        public string ProducerName { get; set; }
        public string Country { get; set; }
        public string Color { get; set; }

        public ProductDetail(string producerName, string country, string color)
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
