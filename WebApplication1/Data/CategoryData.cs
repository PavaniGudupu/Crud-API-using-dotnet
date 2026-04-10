using WebApplication1.Model;

namespace WebApplication1.Data
{
    public class CategoryData
    {
        public static List<CategoryModel> Categories = new List<CategoryModel>
        {
            new CategoryModel { CategoryId = 1, CategoryName = "Electronics" },
            new CategoryModel { CategoryId = 2, CategoryName = "Fashion" },
            new CategoryModel { CategoryId = 3, CategoryName = "Furniture" },
            new CategoryModel { CategoryId = 4, CategoryName = "Grocery" },
            new CategoryModel { CategoryId = 5, CategoryName = "Books" }
        };
    }
}