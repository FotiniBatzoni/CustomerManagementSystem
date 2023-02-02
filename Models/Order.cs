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
        }

        public Guid OrderId { get; set; }

        public DateTimeOffset? OrderDate { get; set; }

        public string ShippingAdress { get; set; }

        public Product Product { get; set; }

        public Customer Customer { get; set; }

        public OrderItem OrderItem { get; set; }


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
