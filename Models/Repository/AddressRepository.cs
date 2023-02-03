namespace CustomerManagementSystem.Models.Repository
{
    public class AddressRepository
    {
        public Address Retrieve(Guid addressId)
        {
            Address address = new Address(addressId);

            if(Guid.TryParse("1A3B944E-3632-467B-A53A-206305310BA1", out Guid parsedGuid))
            {
                address.AddressId = parsedGuid;
                address.StreetLine1 = "Zaloggou 23";
                address.StreetLine1 = "Pierion 23";
                address.State = "Greece";
                address.City = "Corfu";
                address.Country = "Greece";
                address.PostalCode = "65551";
            }

            return address;
        }

        public bool Save (Address address)
        {
            return true;
        }
    }
}
