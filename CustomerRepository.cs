namespace ACM.BL
{
    public class CustomerRepository
    {

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
