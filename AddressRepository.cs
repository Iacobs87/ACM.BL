using System.Collections.Generic;
using System.Reflection.Emit;

namespace ACM.BL
{
    public class AddressRepository
    {
        //retrieve one address

        public Address Retrieve(int addressId)
        {
            //create the instance of the Address Class
            //pass in the requested Id
            Address address = new Address(addressId);

            //code that retrieves the defined address

            //temporary hard coded values to return
            //a populated address

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
                   
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCusomerId(int customerId)
        {
            //code that retrieves the deifned addresses for the customer

            //temp hard coded values to return a set of addresses for a customer

            var addressList = new List<Address>();
            var address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"
            };
            addressList.Add(address);

            return addressList;
        }

        //saves the current address
        public bool Save(Address address)
        {
            var success = true;

            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
                    {
                        //call an insert stored procedure
                    }
                    else
                    {
                        //call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
