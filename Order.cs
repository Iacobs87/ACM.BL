using System;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {
                
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        //Retrieve one order
        public Order Retrieve()
        {
            //code that retrieves the defined order
            return new Order();
        }

        //Saves the current order
        public bool Save()
        {
            //code that saves the defined order
            return true;
        }

        //validates the order data

        public bool Validate()
        {

            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
