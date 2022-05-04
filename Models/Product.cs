using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class Product : BaseClass
    {
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public decimal UnitPrice { get; set; }
        public bool Featured { get; set; }
        public int NumberOfSale { get; set; }
        public int Ratings { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }
        public decimal DiscountedUnitPrice { get; set; }
        public int PercentOff { get; set; }
        public int Quantity { get; set; }
        public bool Availability { get; set; }
        public Category Category { get; set; }
        public ICollection<Color> Colors { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
