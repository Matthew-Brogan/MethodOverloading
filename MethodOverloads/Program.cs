using System;
using System.Diagnostics.CodeAnalysis;

namespace MethodOverloads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets add two numbers, Which numbers should we add?");
            int s = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            var sumation = Add(s, r);
            Console.WriteLine(sumation);
            Console.WriteLine("Do it again but with decimals!");
            decimal t = decimal.Parse(Console.ReadLine());
            decimal l = decimal.Parse(Console.ReadLine());
            var deci = Add(t, l);
            Console.WriteLine(deci);
            Console.WriteLine("Please give me a number!");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please give me another number!");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("You want to see this in dollars?(true/false)");
            bool isTrue = bool.Parse(Console.ReadLine());
            var answer = Add(a,b,isTrue);
            Console.WriteLine(answer);
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public static string Add(int a , int b , bool isTrue)
        {
            int sum = a + b;
            if( isTrue == true && sum > 1)
            {
                return $"{sum} dollars";
               
            }
            else if (isTrue == true && sum <= 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return $"{sum}";
            }
        }
    }
}
