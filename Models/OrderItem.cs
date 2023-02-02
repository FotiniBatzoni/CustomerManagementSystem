namespace CustomerManagementSystem.Models
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(Guid orderItemId)
        {
            OrderItemId = orderItemId;
        }


        public Guid OrderItemId { get; set; }

        public Guid ProductId { get; set; }

        public float Quantity { get; set; }

        public decimal? PurchasePrice { get; set; }


        //Validate the order item data
        public bool Validate()
        {
            var isValid = true;
            if (Quantity <= 0)
            {
                isValid = false;
            }

            if (PurchasePrice == null)
            {
                isValid = false;
            }


            return isValid;
        }

        //Retrieve one order item
        public OrderItem Retrieve(Guid orderItemId)
        {
            return new OrderItem();
        }

        //Retrireve all order items
        //overloading!!!
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        //Saves the current order Item
        public bool Save()
        {
            return true;
        }
    }
}
