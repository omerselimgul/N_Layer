using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            Console.WriteLine("Test");
            foreach (var product in productManager.GetByUnitPrice(50, 60))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}