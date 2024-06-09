// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI;
using Bussiness.Concrete;

public static class Program {
    public static void Main(string[] args)
    {
        ProductTest();
        //CategoryTest();
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category);
        }
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        
        var result = productManager.GetProductDetails();
        
        if(result.Success)
        {
            foreach (var product in result.Data)
            {
                Console.WriteLine(product);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }
}