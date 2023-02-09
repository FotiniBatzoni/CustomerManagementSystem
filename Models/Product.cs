using Common;

namespace CustomerManagementSystem.Models
{
    public class Product : EntityBase, ILoggable
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
                //using a static method (StringHandler)
              //  return StringHandler.InsertSpaces(_productName);

                //using StringHandler as an Extension method
                return _productName.InsertSpaces();
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

        public string Log() => $"{ProductId}: {ProductName} Detail: {ProductDescription}  Status: {EntityState.ToString()}";

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
