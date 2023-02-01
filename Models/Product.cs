namespace CustomerManagementSystem.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public float Price { get; set; }


    }
}
