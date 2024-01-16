using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Product prod = new Product();
            string userInput;

            do
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Write("Enter Product Id: ");
                        prod.ProdId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Product Name: ");
                        prod.ProdName = Console.ReadLine();

                        Console.Write("Enter Product MfgDate: ");
                        prod.ProdMfgDate = Convert.ToDateTime(Console.ReadLine());

                        Console.Write("Enter Product Warranty: ");
                        prod.ProdWarranty = Console.ReadLine();

                        Console.Write("Enter Product Price: ");
                        prod.ProdPrice = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter Product Stock: ");
                        prod.ProdStock = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Product GST: ");
                        prod.ProdGST = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Product Discount: ");
                        prod.ProdDiscount = Convert.ToInt32(Console.ReadLine());

                        break;

                    case "2":
                        Console.WriteLine(prod.Display());
                        break;

                    case "3":
                        Console.WriteLine("You selected Option 3.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (userInput != "3");
        }

    }
}
