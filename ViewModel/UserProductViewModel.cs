using Ecommerce.Models;
using Ecommerce.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.ViewModel
{
    public class UserProductViewModel : Pagination
    {
        public List<User> Users { get; set; }
        public List<Product> Products { get; set; }
        public List<News> LatestNews { get; set; }
        public Product Product { get; set; }
        public bool IsSuccess { get; set; }
    }
}

