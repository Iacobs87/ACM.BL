using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{

    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        private string _lastName;
        private string _firstName;

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;

            }            
            
        }

        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public static int InstanceCount { get; set; }

        // Validates the customers data
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
        
        // Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            //code that retrieves the defined customer
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            //code that retrieves the defined customer
            return new List<Customer>();
        }

        // save the current customer

        public bool Save()
        {
            //code that save the defined customer
            return true;
        }

    }
}
