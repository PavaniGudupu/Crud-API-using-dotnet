using WebApplication1.Model;

namespace WebApplication1.Data
{
    public class ProductData
    {
        public static List<ProductModel> Products = new List<ProductModel>
        {
            new ProductModel
            {
                ProductId = 1,
                ProductName = "iPhone 14",
                CategoryId = 1,
                CategoryName = "Electronics",
                Mrp = 80000,
                Sp = 75000,
                Cp = 70000,
                Classification = "Mobile",
                Size = "128GB",
            },
            new ProductModel
            {
                ProductId = 2,
                ProductName = "Samsung TV",
                CategoryId = 1,
                CategoryName = "Electronics",
                Mrp = 60000,
                Sp = 55000,
                Cp = 50000,
                Classification = "Television",
                Size = "55 inch",
            },
            new ProductModel
            {
                ProductId = 3,
                ProductName = "Nike Shoes",
                CategoryId = 2,
                CategoryName = "Fashion",
                Mrp = 5000,
                Sp = 4500,
                Cp = 3000,
                Classification = "Footwear",
                Size = "9",
            },
            new ProductModel
            {
                ProductId = 4,
                ProductName = "Wooden Table",
                CategoryId = 3,
                CategoryName = "Furniture",
                Mrp = 10000,
                Sp = 9000,
                Cp = 7000,
                Classification = "Home",
                Size = "4x2 ft",
            },
            new ProductModel
            {
                ProductId = 5,
                ProductName = "Dell Laptop",
                CategoryId = 1,
                CategoryName = "Electronics",
                Mrp = 70000,
                Sp = 65000,
                Cp = 60000,
                Classification = "Laptop",
                Size = "15 inch",
            }
        };
    }
}