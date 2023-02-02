namespace CustomerManagementSystem.Models
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName {
            get{
                string fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrEmpty(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            } 
        }

        public static int  InstanceCount { get; set; }

        public string Email { get; set; }

        public string HomeAddress { get; set; }

        public string WorkAddress { get; set; }


        //Validate the customer data
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(LastName))
            {
                isValid = false;
            }

            if (string.IsNullOrEmpty(Email))
            {
                isValid = false;
            }

            return isValid;
        }

        //Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        //Retrireve all customers
        //overloading!!!
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        //Saves the current customer
        public bool Save()
        {
            return true;
        }

    }
}
