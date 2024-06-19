using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace hypotenuse_calculator_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side A:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter side B:");
            double b = Convert.ToDouble(Console.ReadLine());


            double c = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine("This Hypotenuse is: " + c);
            Console.ReadKey();
        }
    }
}
