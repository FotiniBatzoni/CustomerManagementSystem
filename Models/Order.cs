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

        //Retrieve one order
        public Order Retrieve(Guid orderId)
        {
            return new Order();
        }

        //Retrireve all orders
        //overloading!!!
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        //Saves the current order
        public bool Save()
        {
            return true;
        }
    }
}
