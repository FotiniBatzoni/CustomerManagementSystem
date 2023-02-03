namespace CustomerManagementSystem.Models.Repository
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }


        public Customer Retrieve(Guid customerId)
        {
            Customer customer = new Customer(customerId);

            if(Guid.TryParse("1A3B944E-3632-467B-A53A-206305310BAE", out Guid parsedGuid))
            {
                customer.CustomerId = parsedGuid;
                customer.FirstName = "Tony";
                customer.LastName = "Balis";
                customer.Email = "tony@example.com";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        public bool Save (Customer customer)
        {
            return true;
        }
    }
}
