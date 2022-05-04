using System;

namespace Ecommerce.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        User User { get; set; }
        Product Product { get; set; }
    }
}
