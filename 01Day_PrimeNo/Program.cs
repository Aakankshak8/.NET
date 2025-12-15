using System;

namespace _01Day_PrimeNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int n = int.Parse(Console.ReadLine());

            if (IsPrime(n))
                Console.WriteLine($"{n} is a Prime Number");
            else
                Console.WriteLine($"{n} is Not a Prime Number");

            Console.ReadLine();
        }

        static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
