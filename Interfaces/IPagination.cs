using Ecommerce.Models;
using System.Collections.Generic;

namespace Ecommerce.Contracts
{
    public interface IPagination
    {
        int PageCount(List<Product> products);
        IEnumerable<Product> Paginate(List<Product> products);
    }
}
