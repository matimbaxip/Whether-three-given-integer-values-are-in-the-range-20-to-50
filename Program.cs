using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whether_three_given_integer_values_are_in_the_range_20_to_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter three integer values:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                int num3 = Convert.ToInt32(Console.ReadLine());

                bool result = (num1 >= 20 && num1 <= 50) || (num2 >= 20 && num2 <= 50) || (num3 >= 20 && num3 <= 50);

                Console.WriteLine("Result: " + result);

            }
        }
    }
}
