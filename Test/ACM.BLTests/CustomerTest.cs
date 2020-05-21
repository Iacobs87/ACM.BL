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

        [TestMethod]
        public void StaticTest()
        {
            //arrange
            var c1 = new Customer();
            c1.FirstName = "Beo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Wolf";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Alex";
            Customer.InstanceCount += 1;

            //act

            //arrange

            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //Arrange

            Customer customer = new Customer
            {
                LastName = "Beo",
                EmailAddress = "Be0W@uk.com"
            };

            var expected = true;

            //act
            var actual = customer.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //Arrange

            Customer customer = new Customer
            {
                EmailAddress = "Be0W@uk.com"
            };

            var expected = false;

            //act
            var actual = customer.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
