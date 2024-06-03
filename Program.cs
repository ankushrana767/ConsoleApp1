using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Product class
            Product product = new Product();

            // Display initial product details
            product.DisplayProductDetails();

            // Increase stock
            Console.Write("Enter quantity to increase stock: ");
            int increaseQuantity = int.Parse(Console.ReadLine());
            product.IncreaseStock(increaseQuantity);

            // Decrease stock
            Console.Write("Enter quantity to decrease stock: ");
            int decreaseQuantity = int.Parse(Console.ReadLine());
            product.DecreaseStock(decreaseQuantity);

            // Display updated product details
            product.DisplayProductDetails();

            Console.ReadLine();
        }
    }
}
