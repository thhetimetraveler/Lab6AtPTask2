using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6AtPTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number for x (x > 0): ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Enter any number for k: ");
            double k = double.Parse(Console.ReadLine());

            if (x > 0)
            {
                double a = Math.Log(x);
                double b = Math.Exp(k) + a;
                double y = Math.Pow(a, 2) + Math.Pow(b, 2);

                Console.WriteLine($"a = {a:F4}");
                Console.WriteLine($"b = {b:F4}");
                Console.WriteLine($"y = {y:F4}");
            }
            else
            {
                Console.WriteLine("Invalid input: x must be greater than 0.");
            }
        }
    }
}
