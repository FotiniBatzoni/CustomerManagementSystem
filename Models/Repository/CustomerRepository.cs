namespace CustomerManagementSystem.Models.Repository
{
    public class CustomerRepository
    {
        public Customer Retrieve(Guid customerId)
        {
            Customer customer = new Customer(customerId);

            if(Guid.TryParse("a5b354d2-e019-4daa-ae46-15ea150ac5bd", out Guid parsedGuid))
            {
                customer.CustomerId = parsedGuid;
                customer.FirstName = "Tony";
                customer.LastName = "Balis";
                customer.Email = "tony@example.com";

            }

            return customer;
        }

        public bool Save (Customer customer)
        {
            return true;
        }
    }
}
