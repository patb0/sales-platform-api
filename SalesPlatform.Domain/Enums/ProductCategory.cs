using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Domain.Enums
{
    public enum ProductCategory
    {
        [EnumMember(Value = "Electronics")]
        Electronics,
        [EnumMember(Value = "Sports")]
        Sports,
        [EnumMember(Value = "Automotive")]
        Automotive,
        [EnumMember(Value = "Fashion")]
        Fashion,
        [EnumMember(Value = "Home")]
        Home,
    }
}
