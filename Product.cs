namespace ACM.BL
{

    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        //retrieve one product
        public Product Retrieve(int productId)
        {
            //code that retrieves the defined product
            return new Product();
        }

        //saves the current product
        public bool Save()
        {
            //code that saves the defined product
            return true;
        }

        //Validates the product data
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

    }
}
