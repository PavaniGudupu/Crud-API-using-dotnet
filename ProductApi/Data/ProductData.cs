using ProductApi.Models;

namespace ProductApi.Data
{
    public static class ProductData
    {
        public static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                ProductName = "iPhone",
                CategoryId = 10,
                Mrp = 5000,
                Sp = 48000,
                Cp = 45000,
                Classification = "Electronics",
                Size = "Medium",
                Category = "Mobile"
            },
            new Product
            {
                Id = 2,
                ProductName = "Pen",
                CategoryId = 2,
                Mrp = 10,
                Sp = 8,
                Cp = 5,
                Classification = "Stationery",
                Size = "Small",
                Category = "Office"
            }
            // 👉 Add up to 20 products here
        };
    }
}