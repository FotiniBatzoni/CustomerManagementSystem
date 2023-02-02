namespace CustomerManagementSystem.Models
{
    public class Address
    {
        public Address()
        {

        }

        public Address (Guid addressId)
        {
            AddressId = addressId;
        }

        public Guid AddressId { get; set; }
        public string StreetLine1 { get; set; }

        public string StreetLine2 { get; set; }

        public string City { get; set; }

        public string   State { get; set; }

        public int PostalCode {get; set; }

        public string Country { get; set; }

        public string AddressType { get; set; }

        public bool Validate()
        {
            bool isValid = true;
            if (StreetLine1 == null)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
