using System;

namespace CSharpRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(100000, 0, 1));
        }

        static long Fib(int n, long a, long b)
        {
            if (n == 0)
                return a;
            if (n == 1)
                return b;

            return Fib(n - 1, b, a + b);
        }
    }
}
