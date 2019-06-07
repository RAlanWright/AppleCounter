using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleCounter
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new string('*', 100));

            Console.WriteLine("This program will take in a number and calculate the price for" +
                " the number of apples you enter in.");

            Console.WriteLine(new string('*', 100));

            Console.Write("How many apples would you like? ");
            Console.WriteLine();

            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(new string('*', 100));
            Console.WriteLine(new string('*', 100));


            Apple granny = new Apple("Granny Smith", 1.49, count);
            Apple fuji = new Apple("Fuji", 1.56, count);

            Console.WriteLine();
            Console.WriteLine("The price of {0} {1} apples would be: ${2}.", count, granny.name, ApplePrice(granny.name, count, granny.price));
            Console.WriteLine();

            Console.WriteLine(new string('*', 100));

            Console.WriteLine();
            Console.WriteLine("The price of {0} {1} apples would be: ${2}.", count, fuji.name, ApplePrice(fuji.name, count, fuji.price));
            Console.WriteLine();

            Console.WriteLine(new string('*', 100));

            Console.ReadLine();
        }
        public static double ApplePrice(string name, int count, double price)
        {
            double total = 0.0;
            if (name == "Granny Smith")
            {
                total = count * price;

                return total;
            }
            else
            {
                total = count * price;
                return total;
            }
        }
    }
}
