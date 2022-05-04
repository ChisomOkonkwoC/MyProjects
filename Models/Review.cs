namespace Ecommerce.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string Details { get; set; }
        public int Rate { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
    }
}
