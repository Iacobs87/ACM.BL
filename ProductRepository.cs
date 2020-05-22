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

            return product;     
        }

        public bool Save(Product product)
        {
            //code that saves the passed product
            return true;
        }
    }
}
