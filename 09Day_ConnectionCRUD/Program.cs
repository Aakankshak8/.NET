using _09Day_ConnectionCRUD.DAL;
using _09Day_ConnectionCRUD.Models;

namespace _09Day_ConnectionCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IETDbContext ietcontext = new IETDbContext();
            int noOFRowsAffected = 0;
            while (true)
            {
                Console.WriteLine("Enter Db Operation Choice : 1.Insert 2.Select 3.Update 4.Delete");
                int opchoice = Convert.ToInt32(Console.ReadLine());
                switch (opchoice)
                {
                    case 1:
                        Product productToBeInserted = new Product();

                        Console.WriteLine("Enter Name of Product");
                        productToBeInserted.ProductName = Console.ReadLine();
                        Console.WriteLine("Enter Product Price");
                        productToBeInserted.ProductPrice = Convert.ToInt32(Console.ReadLine());

                        noOFRowsAffected = ietcontext.InsertProductRecord(productToBeInserted);
                        if (noOFRowsAffected > 0)
                        {
                            Console.WriteLine("Product inserted successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Error with insert query!");
                        }
                        break;

                    case 2:
                        var records = ietcontext.getAllProducts();
                        foreach (var Product in records)
                        {
                            Console.WriteLine($"Id: {Product.ProductId}, Name: {Product.ProductName}, Price: {Product.ProductPrice}");

                        }


                        break;

                    case 3:
                        Product ProductToBeUpdated = new Product();
                        Console.WriteLine("Enter Id of Product to be updated");
                        ProductToBeUpdated.ProductId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name of Product to be updated");
                        ProductToBeUpdated.ProductName = Console.ReadLine();
                        Console.WriteLine("Enter Price of Product  to be updated");
                        ProductToBeUpdated.ProductPrice = Convert.ToInt32(Console.ReadLine());

                        noOFRowsAffected = ietcontext.UpdateProductRecord(ProductToBeUpdated.ProductId, ProductToBeUpdated);
                        if (noOFRowsAffected > 0)
                        {
                            Console.WriteLine("Record updated successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Error with update query!");
                        }

                        break;

                    case 4:

                        Console.WriteLine("Enter Product Id to be Deleted");
                        int id = Convert.ToInt32(Console.ReadLine());

                        int rows = ietcontext.DeleteProduct(id);
                        if (rows > 0)
                        {
                            Console.WriteLine("Product has been deleted successfully");
                        }
                        else
                        {
                            Console.WriteLine("Unable to delete the product");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Do you want continue? y/n");
                string ynChoice = Console.ReadLine();
                if (ynChoice == "n")
                {
                    break;
                }
            }
        }
    }
}