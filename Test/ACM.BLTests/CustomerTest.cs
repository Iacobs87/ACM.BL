using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange

            Customer customer = new Customer
            {
                FirstName = "Beo",
                LastName = "Wolf"
            };

            string expected = "Wolf, Beo";

            //act
            string actual = customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange

            Customer customer = new Customer
            {            
                LastName = "Wolf"
            };

            string expected = "Wolf";

            //act
            string actual = customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange

            Customer customer = new Customer
            {
                FirstName = "Beo",               
            };

            string expected = "Beo";

            //act
            string actual = customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
