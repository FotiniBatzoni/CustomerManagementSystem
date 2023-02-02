﻿namespace CustomerManagementSystem.Models
{
    public class Product
    {
        public Product()
        {

        }

        public Product(Guid productId)
        {
            ProductId = productId;
        }

        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set; }


        //Validate the product data
        public bool Validate()
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
