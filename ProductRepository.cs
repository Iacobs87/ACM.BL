using System;

namespace ACM.BL
{

    public class ProductRepository
    {
       //retrieve one product
       public Product Retrieve(int productId)
        {
            //create the instance of the product class
            var product = new Product(productId);

            //code that retrieves the defined product

            //temporary hard coded values to return a populated product

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted size set of 4 bright yellow mini sunflowers";
                product.CurrentPrice = 15.96M;
            }

            Object myobject = new Object();
            Console.WriteLine($"Object: {myobject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");

            return product;     
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //call an insert stored procedure
                    }
                    else
                    {
                        //call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
