namespace CustomerManagementSystem.Models.Repository
{
    public class OrderRepository
    {
        public Order Retrieve(Guid orderId)
        {
            Order order = new Order(orderId);

            if(Guid.TryParse("1A3B944E-3632-467B-A53A-206305310BAC", out Guid parsedGuid))
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }

        public bool Save (Order order)
        {
            return true;
        }
    }
}
