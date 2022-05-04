using System.Collections.Generic;

namespace Ecommerce.Models
{
    public class Category : BaseClass
    {
        ICollection<Product> Product { get; set; }
    }
}
