using SalesPlatform.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        //one place to configure the date time
        public DateTime Now => DateTime.Now;
    }
}
