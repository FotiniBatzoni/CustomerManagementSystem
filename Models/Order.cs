namespace CustomerManagementSystem.Models
{
    public class Order
    {
        public Order() 
        { 

        }

        public Order(Guid orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public Guid OrderId { get; set; }

        public DateTimeOffset? OrderDate { get; set; }

        public string ShippingAdress { get; set; }

        public Product Product { get; set; }

        public Guid CustomerId { get; set; }

        public Guid ShippingAddressId { get; set; }

        public List<OrderItem> OrderItems { get; set; }


        //Validate the order data
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null)
            {
                isValid = false;
            }

            return isValid;
        }

    }
}
