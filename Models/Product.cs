using Common;

namespace CustomerManagementSystem.Models
{
    public class Product : EntityBase
    {
        public Product()
        {

        }

        public Product(Guid productId)
        {
            ProductId = productId;
        }

        public Guid ProductId { get; set; }

        private string _productName;    
        public string ProductName { 
            get 
            {
                return StringHandler.InsertSpaces(_productName);
            }
            set 
            { 
                _productName = value;
            }
        }
        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set; }

        public override string ToString()
        {
            return ProductName;
        }


        //Validate the product data
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(ProductName))
            {
                isValid = false;
            }

            if (CurrentPrice == null)
            {
                isValid = false;
            }
            return isValid;
        }

    }
}
