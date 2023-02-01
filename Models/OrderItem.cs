namespace CustomerManagementSystem.Models
{
    public class OrderItem
    {
        public Guid OrderItemId { get; set; }

        public float Quantity { get; set; }

        public decimal PurchasePrice { get; set; }
    }
}
