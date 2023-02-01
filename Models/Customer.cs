namespace CustomerManagementSystem.Models
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }

        public string HomeAddress { get; set; }

        public string WorkAddress { get; set; }

    }
}
