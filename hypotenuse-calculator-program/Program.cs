using System;

namespace hypotenuse_calculator_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter side A
            Console.WriteLine("Enter side A:");
            // Read and convert side A input to a double
            double a = Convert.ToDouble(Console.ReadLine());
            
            // Prompt the user to enter side B
            Console.WriteLine("Enter side B:");
            // Read and convert side B input to a double
            double b = Convert.ToDouble(Console.ReadLine());

            // Calculate the hypotenuse using the Pythagorean theorem
            double c = Math.Sqrt((a * a) + (b * b));
            
            // Output the calculated hypotenuse
            Console.WriteLine("The Hypotenuse is: " + c);

            // Watermark
            Console.WriteLine("Made By Gaurav Khatri love from Pakistan");
            
            // Wait for user input to close the console window (optional)
            Console.ReadKey();
        }
    }
}
