using SalesPlatform.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Domain.ValueObjects
{
    public class CustomerName : ValueObject
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public CustomerName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return $"{FirstName} {LastName}";
        }
    }
}
