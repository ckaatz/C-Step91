using System;

namespace C_Step91
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of your package?");
            decimal weight = Convert.ToDecimal(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("What is the width of your package?");
                decimal width = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the height of your package?");
                decimal height = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the length of your package?");
                decimal length = Convert.ToDecimal(Console.ReadLine());
                decimal dimension = length * width * height;
                decimal price = (dimension * weight) / 100;
                string quote = dimension > 50 ? "Package too big to be shipped via Package Express." : "Your shipping price is $" + price + ".";
                Console.WriteLine(quote);
                Console.ReadLine();
            }
        }
    }
}
