namespace _01Day_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                if (i > 0)
                {

                    Console.Write("*");
                }

                Console.WriteLine();
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int k = i; k < n - 2; k++)
                {
                    Console.Write("  ");
                }
                if (i < n - 2)
                {

                    Console.Write("*");
                }


                Console.WriteLine();
            }
        }
    }
}