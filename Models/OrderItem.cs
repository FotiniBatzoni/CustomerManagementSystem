namespace CustomerManagementSystem.Models
{
    public class OrderItem
    {
        public Guid OrderId { get; set; }

        public float Quantity { get; set; }

        public decimal PurchasePrice { get; set; }
    }
}
