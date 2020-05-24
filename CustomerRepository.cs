using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }

        //retrieve one customer
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            //code that retrieves the defined customer

            //temporary hard coded values to return a populated customer

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCusomerId(customerId).ToList();
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            // code that saves the passed customer
            return true;
        }

    }
}
