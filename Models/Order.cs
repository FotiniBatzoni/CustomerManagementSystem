namespace CustomerManagementSystem.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public string ShippingAdress { get; set; }

        public Product Product { get; set; }

        public Customer Customer { get; set; }

        public OrderItem OrderItem { get; set; }        
    }
}
