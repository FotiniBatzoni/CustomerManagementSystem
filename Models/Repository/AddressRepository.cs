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

        public IEnumerable<Address> RetrieveByCustomerId(Guid customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(Guid.Parse("1A3B944E-3632-467B-A53A-206305310BA1"))
            {
                StreetLine1 = "Zaloggou 23",
                StreetLine2 = "Pierion 23",
                State = "Greece",
                City = "Corfu",
                Country = "Greece",
                PostalCode = "65551"
            };
            addressList.Add(address);   

            address = new Address(Guid.Parse("1A3B944E-3632-467B-A53A-206305310BA2"))
            {
                StreetLine1 = "Anteon 23",
                StreetLine2 = "Lixouri 23",
                State = "Greece",
                City = "Corfu",
                Country = "Greece",
                PostalCode = "65551"
            };
            addressList.Add(address);

            return addressList;
        }

        


        public bool Save (Address address)
        {
            return true;
        }
    }
}
