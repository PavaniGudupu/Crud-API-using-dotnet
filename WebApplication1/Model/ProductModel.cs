namespace WebApplication1.Model
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int Mrp { get; set; }
        public int Sp { get; set; }
        public int Cp { get; set; }
        public string Classification { get; set; }
        public string Size { get; set; }
    }
}
