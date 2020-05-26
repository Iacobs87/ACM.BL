using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class LoggingServiceTests
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //arrange 
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };

            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };

            changedItems.Add(product);

            //act
            LoggingService.WriteToFile(changedItems);

            //assert
            //nothing to assert
        }
    }
}
