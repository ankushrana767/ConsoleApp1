using System;

namespace ConsoleApp1
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        private int stock;

        public Product()
        {
            Console.Write("Enter Product ID (1-1000): ");
            ProductID = int.Parse(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            ProductName = Console.ReadLine();

            Console.Write("Enter Price ($1-100): ");
            Price = double.Parse(Console.ReadLine());

            Console.Write("Enter Stock (1-1000): ");
            stock = int.Parse(Console.ReadLine());
        }

        // Increase stock
        public void IncreaseStock(int quantity)
        {
            stock += quantity;
            Console.WriteLine($"Stock increased by {quantity}. New stock: {stock}");
        }

        // Decrease stock
        public void DecreaseStock(int quantity)
        {
            if (stock >= quantity)
            {
                stock -= quantity;
                Console.WriteLine($"Stock decreased by {quantity}. New stock: {stock}");
            }
            else
            {
                Console.WriteLine("Insufficient stock.");
            }
        }

        // Display product details
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product ID: {ProductID}");
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine($"Stock: {stock}");
        }
    }
}
