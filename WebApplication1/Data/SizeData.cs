using WebApplication1.Model;

namespace WebApplication1.Data
{
    public class SizeData
    {
        public static List<SizeModel> Sizes = new List<SizeModel>
        {
            new SizeModel { SizeId = 1, SizeName = "128GB" },
            new SizeModel { SizeId = 2, SizeName = "256GB" },
            new SizeModel { SizeId = 3, SizeName = "32 inch" },
            new SizeModel { SizeId = 4, SizeName = "55 inch" },
            new SizeModel { SizeId = 5, SizeName = "XL" }
        };
    }
}