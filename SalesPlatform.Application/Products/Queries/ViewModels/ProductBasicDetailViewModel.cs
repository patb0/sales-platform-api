using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Queries.ViewModel
{
    public class ProductBasicDetailViewModel
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }

        //to do: average rating for product
        //public float AvgRating { get; set; }
    }
}
