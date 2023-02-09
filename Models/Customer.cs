namespace CustomerManagementSystem.Models
{
    public class Customer
    {
        //Default Constructor
        public Customer()
        {

        }

        //Parameterized Constructor
        public Customer(Guid customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }


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

        public List<Address> AddressList { get; set; }

        public int CustomerType { get; set; }

        //public string Log()
        //{
        //    var logString = CustomerId + ":" + FullName + " Email:" + Email; // + "Status: " + EntityState.ToString();
        //        return logString;
        //}

        public string Log() => $"{CustomerId}: {FullName} Email: {Email}";

        public override string ToString()
        {
            return FullName;
        }

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

    }
}
