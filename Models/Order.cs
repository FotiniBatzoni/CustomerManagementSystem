using Common;

namespace CustomerManagementSystem.Models
{
    public class Order :EntityBase, ILoggable
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

        public string Log() => $"{OrderId}: Date {this.OrderDate.Value.Date} Status: {this.EntityState.ToString()}";
  

        public override string ToString()
        {
            return $"{OrderDate.Value.Date}({OrderId})";
        }


        //Validate the order data
        public override bool Validate()
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
