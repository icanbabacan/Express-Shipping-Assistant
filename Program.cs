using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display initial welcome message
            DisplayWelcome();
            
            // Get and validate package weight
            float weight = GetPackageWeight();
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }
            
            // Get and validate package dimensions
            float width = GetDimension("width");
            float height = GetDimension("height");
            float length = GetDimension("length");
            
            // Check total dimensions
            if (IsTooLarge(width, height, length))
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }
            
            // Calculate and display shipping quote
            DisplayShippingQuote(width, height, length, weight);
            
            Console.ReadLine(); // Keep console window open
        }
        
        // Displays welcome message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        }
        
        // Gets package weight from user
        static float GetPackageWeight()
        {
            Console.WriteLine("Please enter the package weight:");
            return float.Parse(Console.ReadLine());
        }
        
        // Gets a specific dimension from user
        static float GetDimension(string dimensionName)
        {
            Console.WriteLine($"Please enter the package {dimensionName}:");
            return float.Parse(Console.ReadLine());
        }
        
        // Checks if the package dimensions are too large
        static bool IsTooLarge(float width, float height, float length)
        {
            return width + height + length > 50;
        }
        
        // Calculates and displays shipping quote
        static void DisplayShippingQuote(float width, float height, float length, float weight)
        {
            float quote = (width * height * length * weight) / 100;
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}