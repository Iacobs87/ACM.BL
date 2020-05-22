using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class OrderRepositoryTests
    {
        [TestMethod]
        public void TestMethod1()
        {

            //arange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            //act
            var actual = orderRepository.Retrieve(10);

            //assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

        }
    }
}
