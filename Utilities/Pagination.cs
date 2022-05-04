using Ecommerce.Contracts;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Ecommerce.Utilities
{
    public class Pagination
    {
        public int ProductPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount(List<Product> products)
        {
            return Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(products.Count) / Convert.ToDecimal(ProductPerPage)));
        }

        public IEnumerable<T> Paginate<T>(List<T> products) where T : class
        {
            int start = (CurrentPage - 1) * ProductPerPage;
            return products.Skip(start).Take(ProductPerPage);
        }
      
    }
}
