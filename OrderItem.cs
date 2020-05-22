namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        //retrieve one order item

        public OrderItem Retrieve(int orderItemId)
        {
            //code that retrieves the defined order item
            return new OrderItem();
        }

        //Save a order
        public bool Save()
        {
            //code that saves the defined order item
            return true;
        }

        //Validates the order item data
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        } 

    }
}
