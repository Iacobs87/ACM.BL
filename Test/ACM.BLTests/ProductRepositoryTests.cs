using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class ProductRepositoryTests
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Assorted size set of 4 bright yellow mini sunflowers",
                ProductName = "Sunflowers"
            };

            //act

            var actual = productRepository.Retrieve(2);

            //assert

            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);

        }

        [TestMethod]
        public void SaveTestValid()
        {
            //arrange 

            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "Assorted Size Set of 4 Bright yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //act
            var actual = productRepository.Save(updatedProduct);

            //assert
            Assert.AreEqual(true, actual);

        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //arrange 

            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Assorted Size Set of 4 Bright yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //act
            var actual = productRepository.Save(updatedProduct);

            //assert
            Assert.AreEqual(false, actual);
        }
    }
}
