namespace ProductApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int Mrp { get; set; }
        public int Sp { get; set; }
        public int Cp { get; set; }
        public string Classification { get; set; }
        public string Size { get; set; }
        public string Category { get; set; }
    }
}