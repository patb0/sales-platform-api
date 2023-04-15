using SalesPlatform.Domain.Common;
using SalesPlatform.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public string UserName { get; set; }
        public string Domain { get; set; }

        public static Email For(string email)
        {
            var customerEmail = new Email();

            try
            {
                var emailParts = email.Split('@');
                customerEmail.UserName = emailParts[0];
                customerEmail.Domain = emailParts[1];
            }
            catch (Exception ex)
            {
                throw new WrongEmailException(email, ex);
            }

            return customerEmail;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
