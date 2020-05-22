using System;
using System.Data;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            //create the instance of the order class
            //pass in the requested Id

            Order order = new Order(orderId);

            //code that retrieves the defined order

            //temp hard coded values to return a populated order
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }


        public bool Save(Order order)
        {
            //code that saves the passed in order
            return true;
        }
    }
}
