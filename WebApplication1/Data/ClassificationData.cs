using WebApplication1.Model;

namespace WebApplication1.Data
{
    public class ClassificationData
    {
        public static List<ClassificationModel> Classifications = new List<ClassificationModel>
        {
            new ClassificationModel { ClassificationId = 1, ClassificationName = "Mobile" },
            new ClassificationModel { ClassificationId = 2, ClassificationName = "Laptop" },
            new ClassificationModel { ClassificationId = 3, ClassificationName = "Television" },
            new ClassificationModel { ClassificationId = 4, ClassificationName = "Footwear" },
            new ClassificationModel { ClassificationId = 5, ClassificationName = "Home" }
        };
    }
}