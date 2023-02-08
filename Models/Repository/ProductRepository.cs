namespace CustomerManagementSystem.Models.Repository
{
    public class ProductRepository
    {
        public Product Retrieve(Guid productId)
        {
            Product product = new Product(productId);

            if(Guid.TryParse("1A3B944E-3632-467B-A53A-206305310BAB", out Guid parsedGuid))
            {
                product.ProductId = parsedGuid;
                product.ProductName = "Gum";
                product.ProductDescription = "lorem ipsum";
                product.CurrentPrice = (decimal?)0.45;
            }

            return product;
        }

        public bool Save (Product product)
        {
           var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //Call an Insert Stored Procedure
                    }
                    else
                    {
                        //call an Update Stored Procedure
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
