using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms: ");
            int n = int.Parse(Console.ReadLine());
            int[] fib = new int[n];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            Console.WriteLine("The Fibonacci sequence up to " + n + " terms is:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(fib[i]);
            }
        }
    }
}
