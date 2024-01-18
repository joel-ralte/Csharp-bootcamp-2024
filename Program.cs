using System;
using System.Collections.Generic;

namespace Project_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string userInput;
            int FindInput;
            Dictionary<int, Product> products = new Dictionary<int, Product>();

            do
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Find");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        do
                        {
                            Console.WriteLine("Enter Product Id: ");
                            int prodId = Convert.ToInt32(Console.ReadLine());

                            if (!products.ContainsKey(prodId))
                            {
                                Product prod = new Product();
                                prod.ProdId = prodId;

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

                                products.Add(prodId, prod);
                                Console.WriteLine("Product added successfully.");

                                Console.Write("Do you want to add another product? (yes/no): ");
                            }
                            else
                            {
                                Console.WriteLine("Product with the same ID already exists. Choose a different ID.");
                                Console.Write("Do you want to add another product with a different ID? (yes/no): ");
                            }

                        } while (Console.ReadLine().ToLower() == "yes");
                        break;

                    case "2":
                        foreach (var kvp in products)
                        {
                            Console.WriteLine(kvp.Value.Display());
                        }
                        break;

                    case "3":
                        Console.WriteLine("Enter Product ID: ");
                        FindInput = Convert.ToInt32(Console.ReadLine());

                        if (products.ContainsKey(FindInput))
                        {
                            Console.WriteLine(products[FindInput].Display());
                        }
                        else
                        {
                            Console.WriteLine("Not found");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Enter Product ID to delete: ");
                        int deleteInput = Convert.ToInt32(Console.ReadLine());

                        if (products.ContainsKey(deleteInput))
                        {
                            products.Remove(deleteInput);
                            Console.WriteLine("Product deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Product not found. Unable to delete.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (userInput != "5");
        }
    }
}
